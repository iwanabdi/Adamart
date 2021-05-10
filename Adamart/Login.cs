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

namespace Adamart
{
    public partial class Login : Form
    {
        koneksi db = new koneksi();
        DataSet ds;
        public Login()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(db.conn());
            var cmd = new MySqlCommand("select * from pegawai", conn);
            /*MySqlDataReader reader;*/
            try
            {
                // Open the database
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        /*MessageBox.Show("Database Terhubung");*/
                        Console.WriteLine(reader[4]);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var email = txt_email.Text;
            var pass = txt_pass.Text;
            koneksi db;
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            var cmd = new MySqlCommand("select * from pegawai where email='"+email+"' and password='"+pass+"'", conn);
            conn.Open();
            var pegawai = cmd.ExecuteReader();
            pegawai.Read();
            if (pegawai.HasRows)
            {
                var id = pegawai[0].ToString();
                int id_jabatan = (int)pegawai[3];
                var jabatan="";
                if(id_jabatan == 1)
                {
                    jabatan = "Manager";
                }
                else
                {
                    jabatan = "Admin";
                }
                txt_email.ResetText();
                txt_pass.ResetText();
                Home page_home = new Home(pegawai[2].ToString() + "(" + jabatan + ")", id, id_jabatan);
                page_home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
                txt_email.ResetText();
                txt_pass.ResetText();
                txt_email.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_email.ResetText();
            txt_pass.ResetText();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
