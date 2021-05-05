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
    public partial class Pembelian : Form
    {
        //private MySqlConnection conn;
        //private DataSet data;

        koneksi db;
        public Pembelian()
        {
            InitializeComponent();
            getSupplier();
            displayPembelian();
            getBarang();
            getMaxNota();
        }
        public void getMaxNota()
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlCommand nota = new MySqlCommand("select max(id) as 'max_id' from h_beli", conn);

            conn.Open();
            MySqlDataReader reader = nota.ExecuteReader();

            while (reader.Read())
            {
                txtNota.Text = "192-202-0-" + reader.GetString("max_id");
            }
        }

        public void displayPembelian()
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter adapter = new MySqlDataAdapter("select hb.nota_pembelian as 'Nota Pembelian' , " +
                "s.nama_supplier as 'Nama Supplier', " +
                "b.nama_barang as 'Nama Barang', db.qty as 'Jumlah Barang'" +
                "from h_beli hb " +
                "join supplier s on hb.id_supplier=s.id " +
                "join d_beli db on db.id_h_beli=hb.id " +
                "join barang b on db.id_barang=b.id", conn);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2, "display");
            dataGridViewDisplayPembelian.DataSource = ds2.Tables["display"];
            conn.Close();
        }
        public void getSupplier()
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id , nama_supplier from supplier", conn);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "supplier");
            cbSupplier.DataSource = ds1.Tables["supplier"];
            cbSupplier.ValueMember = "id";
            cbSupplier.DisplayMember = "nama_supplier";
            conn.Close();
        }
        public void getBarang()
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,nama_barang,harga_barang FROM barang", conn);
            DataSet ds3 = new DataSet();
            da.Fill(ds3, "barang");
            cbBarang.DataSource = ds3.Tables["barang"];
            cbBarang.ValueMember = "id";
            cbBarang.DisplayMember = "nama_barang";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
