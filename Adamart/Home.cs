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
    public partial class Home : Form
    {
        public Home(string nama_pegawai, string id, int jabatan)
        {
            InitializeComponent();
            MessageBox.Show("ID Pegawai yang Login : " + id.ToString());
            MessageBox.Show("Jabatang : " + jabatan);
            if (id.ToString() != "1")
            {
                btn_admin.Visible = false;
                btn_report.Visible = false;
            }
            lbl_nama.Text = nama_pegawai;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_pembelian_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_pembelian.Height;
            panel_button.Top = btn_pembelian.Top;
            panel_pembelian.Visible = true;
            panel_penjualan.Visible = false;
            panel_stok.Visible = false;
            panel_admin.Visible = false;
            panel_report.Visible = false;
        }

        private void btn_penjualan_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_penjualan.Height;
            panel_button.Top = btn_penjualan.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = true;
            panel_stok.Visible = false;
            panel_admin.Visible = false;
            panel_report.Visible = false;
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_stok.Height;
            panel_button.Top = btn_stok.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = false;
            panel_stok.Visible = true;
            panel_admin.Visible = false;
            panel_report.Visible = false;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_admin.Height;
            panel_button.Top = btn_admin.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = false;
            panel_stok.Visible = false;
            panel_admin.Visible = true;
            panel_report.Visible = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_report.Height;
            panel_button.Top = btn_report.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = false;
            panel_stok.Visible = false;
            panel_admin.Visible = false;
            panel_report.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login page_login = new Login();
            page_login.Show();
        }
    }
}
