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
    public partial class login : Form
    {
        private string server;
        private string database;
        private string user;
        private string pass_db;
        public static bool isLogin = false;
        private MySqlDataAdapter MySqlDataAdapter;
        private MySqlCommand command;
        MySqlConnection connection;

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

        private void logintest()
        {
            check_connection();
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select * from user where nama_depan = '%" + username.Text + "%';", connection);
            MySqlDataReader cmd = command.ExecuteReader();

            while (cmd.Read())
            {
                MessageBox.Show(cmd["nama_depan"].ToString());
            }

            connection.Close();
        }

        public login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main control;
            control = new main();

            control.checkLogin(username.Text, password.Text);
        }
    }
}
