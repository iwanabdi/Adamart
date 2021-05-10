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
using System.Globalization;

namespace Adamart
{
    public partial class Admin : Form
    {
        Admin_Add page_add;
        private MySqlConnection conn;
        private DataSet ds;

        public Admin()
        {
            InitializeComponent();
            page_add = new Admin_Add(this);
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            loadPegawai();

        }

        public void loadPegawai()
        {
            ds.Tables.Clear();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nomor_pegawai, nama_pegawai, email, tgl_lahir, CASE WHEN jabatan = 1 THEN 'Manager' WHEN jabatan = 2 THEN 'Admin' END AS jabatan, password FROM pegawai", conn);
            da.Fill(ds, "pegawai");
            data_admin.DataSource = ds.Tables["pegawai"];
            //MessageBox.Show(data_admin.RowCount.
            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u3657402_adamartDataSet.pegawai' table. You can move, or remove it, as needed.

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            page_add.clear();
            page_add.saveInfo();
            page_add.ShowDialog();
        }

        private void data_admin_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.data_admin.Rows[e.RowIndex].Cells["no"].Value = (e.RowIndex + 1).ToString();
        }

        private void Admin_Shown(object sender, EventArgs e)
        {
            loadPegawai();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nomor_pegawai, nama_pegawai, email, tgl_lahir, CASE WHEN jabatan = 1 THEN 'Manager' WHEN jabatan = 2 THEN 'Admin' END AS jabatan, password FROM pegawai " +
                "WHERE nomor_pegawai LIKE '%"+ txtcari.Text +"%'" +
                "OR nama_pegawai LIKE '%"+ txtcari.Text +"%'", conn);
            da.Fill(ds, "pegawai");
            data_admin.DataSource = ds.Tables["pegawai"];
            //MessageBox.Show(data_admin.RowCount.
            conn.Close();
        }

        private void data_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                page_add.clear();
                page_add.nomor_pegawai = data_admin.Rows[e.RowIndex].Cells["nomor_pegawai"].Value.ToString();
                page_add.nama_pegawai = data_admin.Rows[e.RowIndex].Cells["nama_pegawai"].Value.ToString();
                page_add.jabatan = data_admin.Rows[e.RowIndex].Cells["jabatan"].Value.ToString();
                page_add.email = data_admin.Rows[e.RowIndex].Cells["email"].Value.ToString();
                page_add.password = data_admin.Rows[e.RowIndex].Cells["password"].Value.ToString();
                page_add.updateInfo();
                page_add.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 2)
            {
                String nama = data_admin.Rows[e.RowIndex].Cells["nama_pegawai"].Value.ToString();
                String id = data_admin.Rows[e.RowIndex].Cells["nomor_pegawai"].Value.ToString();

                if (MessageBox.Show("Yakin ingin menghapus data '" + nama + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String Query = "delete from pegawai where nomor_pegawai = '" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader;
                    conn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Berhasil Dihapus!");
                    conn.Close();
                    loadPegawai();
                    txtcari.ResetText();
                }
                return;
            }
        }
    }
}
