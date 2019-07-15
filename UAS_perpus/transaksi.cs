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
    public partial class transaksi : Form
    {
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

        public transaksi()
        {
            InitializeComponent();
            fill_dataTable();
        }

        private void fill_dataTable()
        {
            check_connection();
            connection.Open();

            String display = "select transaksi.id as 'ID', buku.judul as 'Judul Buku', transaksi.qty as 'Banyak Pembelian', transaksi.total_harga as 'Total Pembelian' from transaksi inner join buku on transaksi.id_buku = buku.id";

            MySqlDataAdapter cmd = new MySqlDataAdapter(display, connection);

            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            main control;
            control = new main();

            control.logout();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            home home_form = new home();
            home_form.Show();
        }
    }
}
