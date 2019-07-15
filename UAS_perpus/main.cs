using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UAS_perpus
{
    class main
    {
        private string server;
        private string database;
        private string user;
        private string pass_db;
        public static bool isLogin = false;
        public static string role = null;
        private MySqlDataAdapter MySqlDataAdapter;
        private MySqlCommand command;
        MySqlConnection connection;
        private string username;
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

        public void checkLogin(string username, string password)
        {
            this.username = username;
            this.pass = password;

            check_connection();
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select * from user where username = '" + this.username + "' and password  = '" + this.pass + "';", connection);
            MySqlDataReader cmd = command.ExecuteReader();
            cmd.Read();
            if (cmd.HasRows == true)
            {
                isLogin = true;
                role = "staff";
            }
            cmd.Close();

            if (isLogin == true)
            {
                pilihanstaff dashboard;
                dashboard = new pilihanstaff();
                dashboard.Show();
            }
            else
            {
                login loginform;
                loginform = new login();
                loginform.Show();
            }
        }

        public void logout()
        {
            isLogin = false;
            role = null;

            home home_form;
            home_form = new home();
            home_form.Show();
        }
    }
}
