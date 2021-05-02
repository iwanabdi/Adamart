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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,nama_barang,harga_barang, FROM barang", conn);
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

    }
}
