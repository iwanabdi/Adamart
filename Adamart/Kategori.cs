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
    public partial class Kategori : Form
    {
        public String nama_kategori;
        private MySqlConnection conn;
        private DataSet ds;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Kategori()
        {
            InitializeComponent();
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            loadKategori();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {

        }

        private void buttontmbktg_Click(object sender, EventArgs e)
        {
            nama_kategori = txtnama.Text;

                String Query = "insert into kategori_barang(name) values('" + nama_kategori + "');";
                cmd = new MySqlCommand(Query, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasi Tambah Data");
                conn.Close();
            txtnama.ResetText();
            loadKategori();
        }
        public void loadKategori()
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT id,name FROM kategori_barang", conn);
            da.Fill(ds, "kategori");
            data_kategori.DataSource = ds.Tables["kategori"];
            conn.Close();
        }

        private void data_kategori_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.data_kategori.Rows[e.RowIndex].Cells["no"].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datacontent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                String nama = data_kategori.Rows[e.RowIndex].Cells["nama_supplier"].Value.ToString();
                String id = data_kategori.Rows[e.RowIndex].Cells["id"].Value.ToString();
                if (MessageBox.Show("Yakin ingin menghapus data '" + nama + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String Query = "update from kategori_barang where id = '" + id + "' ";
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader;
                    conn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Berhasil Diupdate!");
                    conn.Close();
                    loadKategori();
                }
                return;
            }

            if (e.ColumnIndex == 2)
            {
                String nama = data_kategori.Rows[e.RowIndex].Cells["nama_supplier"].Value.ToString();
                String id = data_kategori.Rows[e.RowIndex].Cells["id"].Value.ToString();
                if (MessageBox.Show("Yakin ingin menghapus data '" + nama + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String Query = "delete from kategori_barang where id = '" + id + "' ";
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader;
                    conn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Berhasil Dihapus!");
                    conn.Close();
                    loadKategori();
                }
                return;
            }
        }
    }
}
