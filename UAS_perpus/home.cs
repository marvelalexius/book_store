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
    public partial class home : Form
    {
        private string server;
        private string database;
        private string user;
        private string pass_db;
        public static bool isLogin = false;
        private MySqlDataAdapter MySqlDataAdapter;
        private MySqlCommand command;
        MySqlConnection connection;

        int[] book_id = new int[10];

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

        public home()
        {
            InitializeComponent();

            fillImage();
        }

        public void fillImage()
        {
            PictureBox[] pictures =
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10
            };

            string[] images = new string[10];
            int i = 0;

            check_connection();
            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * from buku limit 10;", connection);
            MySqlDataReader reader = command.ExecuteReader();

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            while (reader.Read())
            {
                if (i < 10)
                {
                    images[i] = reader.GetString("cover");
                    book_id[i] = reader.GetInt16("id");
                    i++;
                }
            }

            for (int s = 0; s < images.Length; s++)
            {
                if (images[s] != null)
                {
                    System.Diagnostics.Debug.WriteLine(images[s]);
                    pictures[s].Image = Image.FromFile(path + "\\Cover\\" + images[s]);
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login staff_login = new login();
            staff_login.Show();
            loginbtn.Text = "logout";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(book_id[0]);
            this.Hide();
            home_detail detail = new home_detail(book_id[0]);
            detail.Show();
        }
    }
}
