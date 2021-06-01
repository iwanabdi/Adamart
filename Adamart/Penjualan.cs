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
            //getBarang();
            getMaxNota();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void Cari_Click(object sender, EventArgs e)
        {
            CariBarang cr = new CariBarang(this);
            cr.ShowDialog();
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

        public void isidatabrng(String id,String Barang, String Merk, String Harga)
        {
            txtbarang.Text = Barang;
            txtharga.Text = Harga;
            txtmerk.Text = Merk;
            txtid.Text = id;
        }

        private void btncarimember_Click(object sender, EventArgs e)
        {

        }
    }
}
