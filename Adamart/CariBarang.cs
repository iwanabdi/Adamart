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
    public partial class CariBarang : Form
    {
        private MySqlConnection conn;
        private DataSet ds;
        MySqlDataAdapter da;
        Penjualan penj;

        public CariBarang(Penjualan pejnfrm)
        {
            InitializeComponent();
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            penj = pejnfrm;
        }

        private void CariBarang_Load(object sender, EventArgs e)
        {
            loadstok();
        }

        public void loadstok()
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,b.merk,b.harga_barang,b.stok FROM barang b " +
                "left join kategori_barang k on b.id_kategori=k.id", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT b.id,b.nama_barang,b.merk,b.harga_barang,b.stok FROM barang b " +
                "LEFT JOIN kategori_barang k ON b.id_kategori=k.id " +
                "WHERE b.id LIKE '%" + txtcari.Text + "%'" +
                "OR b.nama_barang LIKE '%" + txtcari.Text + "%'" +
                "OR b.merk LIKE '%" + txtcari.Text + "%'", conn);
            da.Fill(ds, "barang");
            dataGridView1.DataSource = ds.Tables["barang"];
            conn.Close();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String nama = dataGridView1.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();
                String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                String harga = dataGridView1.Rows[e.RowIndex].Cells["harga_barang"].Value.ToString();
                String merk = dataGridView1.Rows[e.RowIndex].Cells["merk"].Value.ToString();
                penj.isidatabrng(id,nama,merk,harga);
                this.Close(); 
                return;
            }
            
        }
    }
}
