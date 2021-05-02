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

        public Stok()
        {
            InitializeComponent();
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            loadstok();
        }

        public void loadstok()
        {
            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,nama_barang,harga_barang, FROM barang", conn);
            da.Fill(ds, "userop");
            dataGridView1.DataSource = ds.Tables["userop"];
            conn.Close();
        }
    }
}
