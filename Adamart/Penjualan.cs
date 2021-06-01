using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adamart
{
    public partial class Penjualan : Form
    {
        koneksi db;
        public Penjualan()
        {
            InitializeComponent();
            db = new koneksi();
            getBarang();
            getMaxNota();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        public void getBarang()
        {
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,nama_barang FROM barang", conn);
            DataSet ds3 = new DataSet();
            da.Fill(ds3, "barang");
            cbBarang.DataSource = ds3.Tables["barang"];
            cbBarang.ValueMember = "id";
            cbBarang.DisplayMember = "nama_barang";
            conn.Close();
        }

        public void getMaxNota()
        {
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlCommand nota = new MySqlCommand("select LPAD(count(id)+1,3,0) as total from h_jual where tanggal=curdate()", conn);
            conn.Open();
            MySqlDataReader reader = nota.ExecuteReader();

            while (reader.Read())
            {
                string date = DateTime.UtcNow.ToString("yyyymmdd");
                txtNota.Text = date + reader.GetString("total");
            }
        }
    }
}
