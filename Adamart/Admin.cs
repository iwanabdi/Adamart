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
    public partial class Admin : Form
    {
        private MySqlConnection conn;
        private DataSet ds;

        public Admin()
        {
            InitializeComponent();
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            generateNP();
            loadPegawai();

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

        public void loadPegawai()
        {
            ds.Tables.Clear();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nomor_pegawai, nama_pegawai, email, tgl_lahir, CASE WHEN jabatan = 1 THEN 'Manager' WHEN jabatan = 2 THEN 'Admin' END AS jabatan FROM pegawai", conn);
            da.Fill(ds, "pegawai");
            data_admin.DataSource = ds.Tables["pegawai"];

            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u3657402_adamartDataSet.pegawai' table. You can move, or remove it, as needed.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_admin_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.data_admin.Rows[e.RowIndex].Cells["no"].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String nomor_pegawai = txtnomor.Text;
            String nama_pegawai = txtnama.Text;
            int jabatan = cbjabatan.SelectedIndex+1;
            String email = txtemail.Text;
            String password = txtpassword.Text;
            String tgl_lahir = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            try
            {
                koneksi cone = new koneksi();
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into pegawai(nomor_pegawai,nama_pegawai,jabatan,email,password,tgl_lahir) " +
                    "values('" + nomor_pegawai + "','" + nama_pegawai + "','" + jabatan + "','" + email + "','" + password + "','" + tgl_lahir + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(cone.conn());
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                
                MyConn2.Close();
                loadPegawai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
