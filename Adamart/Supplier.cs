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
    public partial class Supplier : Form
    {
        public String id_login;
        Supplier_Form page_add;
        koneksi db = new koneksi();
        MySqlConnection conn;
        MySqlDataAdapter da;
        DataSet ds;
        public Supplier()
        {
            InitializeComponent();
            page_add = new Supplier_Form(this);
            conn = new MySqlConnection(db.conn());
            ds = new DataSet();
            loadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            page_add.clear();
            page_add.saveData();
            page_add.ShowDialog();
        }

        public void loadData()
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT id, nomor_id, nama_supplier FROM supplier where status = 1", conn);
            da.Fill(ds, "supplier");
            data_supplier.DataSource = ds.Tables["supplier"];
            conn.Close();
        }

        private void data_supplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.data_supplier.Rows[e.RowIndex].Cells["no"].Value = (e.RowIndex + 1).ToString();
        }

        private void data_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                page_add.clear();
                page_add.id = data_supplier.Rows[e.RowIndex].Cells["id"].Value.ToString();
                page_add.nomor_id = data_supplier.Rows[e.RowIndex].Cells["nomor_id"].Value.ToString();
                page_add.nama_supplier = data_supplier.Rows[e.RowIndex].Cells["nama_supplier"].Value.ToString();
                page_add.updateData();
                page_add.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 2)
            {
                id_login = id_login;
                String nama = data_supplier.Rows[e.RowIndex].Cells["nama_supplier"].Value.ToString();
                String id = data_supplier.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //MessageBox.Show(id_login);
                if (MessageBox.Show("Yakin ingin menghapus data '" + nama + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String Query = "delete from supplier where id = '" + id + "' ";
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader;
                    conn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Berhasil Dihapus!");
                    conn.Close();
                    loadData();
                    txtcari.ResetText();
                }
                return;
            }
        }

        private void Supplier_Shown(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            conn.Open();
            da = new MySqlDataAdapter("SELECT id, nomor_id, nama_supplier FROM supplier " +
                "WHERE nomor_id LIKE '%" + txtcari.Text + "%'" +
                "OR nama_supplier LIKE '%" + txtcari.Text + "%'", conn);
            da.Fill(ds, "supplier");
            data_supplier.DataSource = ds.Tables["supplier"];
            conn.Close();
        }
    }
}
