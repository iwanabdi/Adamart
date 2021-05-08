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
            ds.Tables.Clear();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,k.name,b.merk,b.harga_barang,b.stok FROM barang b " +
                "left join kategori_barang k on b.id_kategori=k.id", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        public void loadkategori()
        {
            ds.Tables.Clear();
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
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into barang(nama_barang,stok,harga_barang,merk,id_kategori,created_at) values(?nama,0,?harga,?merk,?kategori,?now)";
            cmd.Parameters.Add("?nama", MySqlDbType.VarChar).Value= txtnama.Text;
            cmd.Parameters.Add("?harga", MySqlDbType.VarChar).Value= txtharga.Text;
            cmd.Parameters.Add("?merk", MySqlDbType.VarChar).Value = txtmerk.Text;
            cmd.Parameters.Add("?kategori", MySqlDbType.VarChar).Value = cbkategori.SelectedValue;
            cmd.Parameters.Add("?now", MySqlDbType.VarChar).Value = DateTime.Now.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtharga.Text = "";
            txtmerk.Text = "";
            txtnama.Text = "";
            loadstok();

        }
    }
}
