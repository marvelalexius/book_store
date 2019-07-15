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
    public partial class pembelian : Form
    {
        private int book_id;
        private int book_price;
        private int grand_total;
        private int qty;

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

        public pembelian(int id)
        {
            this.book_id = id;

            InitializeComponent();
            fillData();
        }

        private void fillData()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            check_connection();

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * from buku where id = '" + this.book_id + "';", connection);

            MySqlDataReader cmd = command.ExecuteReader();

            cmd.Read();
            System.Diagnostics.Debug.WriteLine(cmd.GetString("cover"));
            System.Diagnostics.Debug.WriteLine(cmd.GetString("judul"));
            System.Diagnostics.Debug.WriteLine(cmd.GetInt16("id_author"));
            System.Diagnostics.Debug.WriteLine(cmd.GetString("sinopsis"));

            cover.Image = Image.FromFile(path + "\\Cover\\" + cmd.GetString("cover"));

            title.Text = cmd.GetString("judul");

            this.book_price = cmd.GetInt32("harga");

            price.Text = cmd.GetString("harga");

            subtotal.Text = Convert.ToString(this.book_price);

            total.Text = Convert.ToString(this.book_price);

            cmd.Close();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(quantity.Text, out this.qty);
            int subtotal_count = this.qty * this.book_price;
            this.grand_total = subtotal_count;
            subtotal.Text = Convert.ToString(subtotal_count);
            total.Text = Convert.ToString(subtotal_count);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            home home_form = new home();
            home_form.Show();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            check_connection();

            connection.Open();

            String query = "insert into transaksi(id_buku, qty, total_harga) values('" + this.book_id + "', '" + this.qty + "', '" + this.grand_total + "')";

            MySqlCommand command = new MySqlCommand(query, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Tambah Data Berhasil");
                this.Hide();

                home home_form = new home();
                home_form.Show();
            }
            else
            {
                MessageBox.Show("Tambah Data Gagal");
                this.Hide();

                home home_form = new home();
                home_form.Show();
            }

            connection.Close();
        }
    }
}
