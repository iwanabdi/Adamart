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
    public partial class Admin_Add : Form
    {
        public String nomor_pegawai, nama_pegawai, jabatan, email, password, tgl_lahir;
        private readonly Admin _parent;
        public Admin_Add(Admin parent)
        {
            InitializeComponent();
            generateNP();
            _parent = parent;
        }

        public void updateInfo()
        {
            label1.Text = "Form Edit Data";
            btn_save.Text = "Ubah";
            txtnomor.Text = nomor_pegawai;
            txtnama.Text = nama_pegawai;
            cbjabatan.SelectedItem = jabatan;
            txtemail.Text = email;
            txtpassword.Text = password;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        public void saveInfo()
        {
            label1.Text = "Form Tambah Data";
            btn_save.Text = "Simpan";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            nomor_pegawai = txtnomor.Text;
            nama_pegawai = txtnama.Text;
            jabatan = (cbjabatan.SelectedIndex + 1).ToString();
            email = txtemail.Text;
            password = txtpassword.Text;
            tgl_lahir = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            koneksi cone = new koneksi();
            MySqlConnection MyConn2 = new MySqlConnection(cone.conn());

            if (btn_save.Text == "Simpan")
            {
                string Query = "insert into pegawai(nomor_pegawai,nama_pegawai,jabatan,email,password,tgl_lahir) " +
                    "values('" + nomor_pegawai + "','" + nama_pegawai + "','" + jabatan + "','" + email + "','" + password + "','" + tgl_lahir + "');";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Berhasil Tambah Data");
                MyConn2.Close();
                clear();
            }
            if (btn_save.Text == "Ubah")
            {
                string Query = "update pegawai set nama_pegawai='" + nama_pegawai + "'," +
                    "jabatan='" + jabatan + "'," +
                    "email='" + email + "'," +
                    "password='" + password + "'" +
                    "where nomor_pegawai = '"+nomor_pegawai+"';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Berhasil Ubah Data");
                MyConn2.Close();
                this.Close();
            }
            _parent.loadPegawai();

        }

        public void clear()
        {
            txtnama.ResetText();
            txtemail.ResetText();
            cbjabatan.ResetText();
            txtpassword.ResetText();
            dateTimePicker1.ResetText();
            generateNP();
        }

        public void generateNP()
        {
            koneksi cone = new koneksi();
            MySqlConnection conn = new MySqlConnection(cone.conn());
            MySqlCommand nota = new MySqlCommand("select max(id)+1 as 'max_id' from pegawai", conn);

            conn.Open();
            MySqlDataReader reader = nota.ExecuteReader();
            while (reader.Read())
            {
                string date = DateTime.UtcNow.ToString("yyyy");
                txtnomor.ReadOnly = true;
                txtnomor.Text = "ADM" + date + reader.GetString("max_id");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
