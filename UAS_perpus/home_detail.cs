using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace UAS_perpus
{
    public partial class home_detail : Form
    {
        private int book_id;

        private string server;
        private string database;
        private string username;
        private string pass_db;
        private MySqlDataAdapter MySqlDataAdapter;
        private MySqlCommand command;
        MySqlConnection connection;
        private string user;
        private string pass;

        private void check_connection()
        {
            server = "localhost";
            database = "toko_buku";
            user = "root";
            pass_db = "marvel";
            string connectionString;

            connectionString = "datasource=" + server + ";" + "username=" + user + ";" + "password=" + pass_db + "; database=" + database + ";";

            connection = new MySqlConnection(connectionString);
        }

        public home_detail(int id)
        {
            this.book_id = id;

            InitializeComponent();
            fillData();

            if (main.role == "staff")
            {
                editbtn.Visible = true;
            } else
            {
                editbtn.Visible = false;
            }
        }

        private void fillData()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            int id;

            check_connection();

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * from buku where id = '" + this.book_id + "';", connection);

            MySqlDataReader cmd = command.ExecuteReader();

            cmd.Read();
            System.Diagnostics.Debug.WriteLine(cmd.GetString("cover"));
            System.Diagnostics.Debug.WriteLine(cmd.GetString("judul"));
            System.Diagnostics.Debug.WriteLine(cmd.GetInt16("id_author"));
            System.Diagnostics.Debug.WriteLine(cmd.GetString("sinopsis"));

            pictureBox1.Image = Image.FromFile(path + "\\Cover\\" + cmd.GetString("cover"));

            title.Text = cmd.GetString("judul");

            deskripsi.Text = cmd.GetString("sinopsis");

            price.Text = cmd.GetString("harga");

            id = cmd.GetInt16("id_author");

            cmd.Close();

            MySqlCommand author_command = new MySqlCommand("Select * from author where id = '" + id + "';", connection);

            MySqlDataReader authorcmd = author_command.ExecuteReader();

            authorcmd.Read();

            author.Text = authorcmd.GetString("nama");

            authorcmd.Close();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            pembelian form_pembelian = new pembelian(this.book_id);
            form_pembelian.Show();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            home_edit form_edit = new home_edit(this.book_id);
            form_edit.Show();
        }
    }
}
