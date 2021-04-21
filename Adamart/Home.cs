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
        public Home()
        {
            InitializeComponent();
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
        }

        private void btn_penjualan_Click(object sender, EventArgs e)
        {
            panel_button.Height = btn_penjualan.Height;
            panel_button.Top = btn_penjualan.Top;
            panel_pembelian.Visible = false;
            panel_penjualan.Visible = true;
        }
    }
}
