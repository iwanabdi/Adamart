using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adamart
{
    public partial class Stok : Form
    {
        private MySqlConnection conn;
        private DataSet ds;

        public Stok()
        {
            InitializeComponent();
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            loadstok();
            loadkategori();
        }

        public void loadstok()
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,b.harga_barang,k.name,b.merk FROM barang b " +
                "left join kategori_barang k on k.id=b.id", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        public void loadkategori()
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,name FROM kategori_barang", conn);
            da.Fill(ds, "kategori");
            cbkategori.DataSource = ds.Tables["kategori"];
            cbkategori.ValueMember = "id";
            cbkategori.DisplayMember = "name";
            conn.Close();
        }

        private void buttontmbktg_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.ShowDialog();
        }

        private void buttontmbbrg_Click(object sender, EventArgs e)
        {
            String Nama = txtnama.Text;
            String harga = txtharga.Text;
            String merk = txtmerk.Text;
            String kategori = cbkategori.SelectedIndex.ToString();


        }
    }
}
