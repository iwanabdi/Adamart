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
        Stok_Form page_add;
        private MySqlConnection conn;
        private DataSet ds;
        MySqlDataAdapter da;

        public Stok()
        {
            InitializeComponent();
            page_add = new Stok_Form(this);
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            loadstok();
        }

        public void loadstok()
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,k.name,b.merk,b.harga_barang,b.stok FROM barang b " +
                "left join kategori_barang k on b.id_kategori=k.id", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        private void buttontmbktg_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.ShowDialog();
        }

        private void buttontmbbrg_Click(object sender, EventArgs e)
        {
            page_add.clear();
            page_add.saveInfo();
            page_add.ShowDialog();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["no"].Value = (e.RowIndex + 1).ToString();
        }

        private void Stok_Shown(object sender, EventArgs e)
        {
            loadstok();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,k.name,b.merk,b.harga_barang,b.stok FROM barang b " +
                "LEFT JOIN kategori_barang k ON b.id_kategori=k.id " +
                "WHERE b.id LIKE '%"+txtcari.Text+"%'" +
                "OR b.nama_barang LIKE '%" + txtcari.Text + "%'" +
                "OR b.merk LIKE '%"+ txtcari.Text + "%'", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                /*MessageBox.Show("Edit Okee");*/
                page_add.clear();
                page_add.id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                page_add.nama_barang = dataGridView1.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();
                page_add.harga_barang = dataGridView1.Rows[e.RowIndex].Cells["harga_barang"].Value.ToString();
                page_add.merk = dataGridView1.Rows[e.RowIndex].Cells["merk"].Value.ToString();
                page_add.kategori = dataGridView1.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
                page_add.updateData();
                page_add.ShowDialog();
                return;
            }
        }
    }
}
