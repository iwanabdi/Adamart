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

        Supplier page_supplier;
        public String id_login;
        public Home(string nama_pegawai, string id, int jabatan)
        {
            InitializeComponent();
            page_supplier = new Supplier();
            id_login = id.ToString();
            //MessageBox.Show("ID Pegawai yang Login : " + id.ToString());
            string jbt;
            if (jabatan == 1)
            {
                jbt = "Manager";
            }
            else
            {
                jbt = "Admin";
            }
            MessageBox.Show("Selamat Datang " + jbt);
            if (jabatan != 1)
            {
                btn_supplier.Visible = false;
                btn_admin.Visible = false;
                btn_report.Visible = false;
            }
            lbl_nama.Text = nama_pegawai;
        }

        private void Home_Load(object sender, EventArgs e)
        {

            panel_button.Height = btn_penjualan.Height;
            panel_button.Top = btn_penjualan.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = true;
            panel_stok.Visible = false;
            panel_admin.Visible = false;
            panel_report.Visible = false;
            panel_supplier.Visible = false;
            Penjualan page_penjualan = new Penjualan();
            page_penjualan.TopLevel = false;
            panel_penjualan.Controls.Add(page_penjualan);
            page_penjualan.Show();
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
            panel_supplier.Visible = false;
            Pembelian page_pembelian = new Pembelian();
            page_pembelian.TopLevel = false;
            panel_pembelian.Controls.Add(page_pembelian);
            page_pembelian.Show();
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
            panel_supplier.Visible = false;
            Penjualan page_penjualan = new Penjualan(id_login);
            page_penjualan.TopLevel = false;
            panel_penjualan.Controls.Add(page_penjualan);
            page_penjualan.Show();
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
            panel_supplier.Visible = false;
            Stok page_stok = new Stok();
            page_stok.TopLevel = false;
            panel_stok.Controls.Add(page_stok);
            page_stok.Show();
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
            panel_supplier.Visible = false;
            Admin page_admin = new Admin();
            page_admin.TopLevel = false;
            panel_admin.Controls.Add(page_admin);
            page_admin.Show();
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
            Report page_report = new Report();
            page_report.TopLevel = false;
            panel_report.Controls.Add(page_report);
            page_report.Show();
        }
        private void btn_supplier_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_supplier.Height;
            panel_button.Top = btn_supplier.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = false;
            panel_stok.Visible = false;
            panel_admin.Visible = false;
            panel_report.Visible = false;
            panel_supplier.Visible = true;
            page_supplier.TopLevel = false;
            panel_supplier.Controls.Add(page_supplier);
            page_supplier.id_login = id_login;
            page_supplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login page_login = new Login();
            page_login.Show();
        }

        private void panel_pembelian_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
