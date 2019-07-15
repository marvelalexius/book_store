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
    public partial class tambahbuku : Form
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

        protected void fill_author_combobox()
        {
            DataSet ds = new DataSet();

            check_connection();

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * from author;", connection);
            MySqlDataAdapter data_adapter = new MySqlDataAdapter();

            data_adapter.SelectCommand = command;
            data_adapter.Fill(ds);

            authorList.DisplayMember = "nama";
            authorList.ValueMember = "id";
            authorList.DataSource = ds.Tables[0];

            //while (cmd.Read())
            //{
            //    string author_name = cmd.GetString("nama");
            //    System.Diagnostics.Debug.WriteLine(author_name);
            //    authorList.Items.Add(author_name);
            //}
        }

        public tambahbuku()
        {
            InitializeComponent();
            fill_author_combobox();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            // folder awal pas buka browse file
            openFileDialog1.InitialDirectory = "D://";

            // title dialognya
            openFileDialog1.Title = "Upload Image";

            // tipe file yang mau diupload
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            //tunjukkin tipe file default yang dipilih pas pertama buka
            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    preview_cover.Image = new Bitmap(openFileDialog1.FileName);
                    preview_cover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Please Upload Image");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            check_connection();
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);

                string judul_buku = judul.Text;
                string deskripsi_buku = deskripsi.Text;
                string harga_buku = harga.Text;

                if (filename == null)
                {
                    MessageBox.Show("tolong pilih foto yang benar");
                }
                else
                {
                    connection.Open();

                    MySqlCommand author_command = new MySqlCommand("Select * from author where nama = '" + authorList.Text + "';", connection);
                    MySqlDataReader cmd = author_command.ExecuteReader();
                    cmd.Read();
                    int author_id = cmd.GetInt32(0);
                    System.Diagnostics.Debug.WriteLine(author_id);
                    cmd.Close();

                    string query = "insert into buku(id_author, judul, sinopsis, harga, cover) values('" + author_id + "', '" + judul_buku + "', '" + deskripsi_buku + "', '" + harga_buku + "', '" + filename + "')";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Cover\\" + filename);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("data berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "filenya dah ada");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            main control;
            control = new main();

            control.logout();
        }
    }
}
