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
        prove_pembelian prove2;
        public Pembelian()
        {
            InitializeComponent();
            //prove2 = new prove_pembelian();
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
                string date = DateTime.UtcNow.ToString("yyyy");
                txtNota.ReadOnly = true;
                txtNota.Text = "1922020" + reader.GetString("max_id")+ date;
            }
        }

        public void displayPembelian()
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter adapter = new MySqlDataAdapter("select hb.nota_pembelian , " +
                "s.nama_supplier " +
                "from h_beli hb " +
                "join supplier s on hb.id_supplier=s.id ", conn);
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
            int no = 0;
            String nota = txtNota.Text;
            String supplier_id = cbSupplier.SelectedValue.ToString();
            String barang_id = cbBarang.SelectedValue.ToString();
            String qty = upQty.Text;
            //MessageBox.Show(qty);

            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlCommand get_harga = new MySqlCommand("SELECT harga_barang FROM barang where id='" + barang_id + "'", conn);
            conn.Open();
            MySqlDataReader reader = get_harga.ExecuteReader();
            int total = 0;
            while (reader.Read())
            {
                total = Int32.Parse(qty) * reader.GetInt32("harga_barang");
            }

            //int index = dataGridViewAddBarang.Rows.Add();
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridViewAddBarang);
            newRow.Cells[0].Value = (no + 1).ToString();
            newRow.Cells[1].Value = nota;
            newRow.Cells[2].Value = supplier_id;
            newRow.Cells[3].Value = barang_id;
            newRow.Cells[4].Value = qty;
            newRow.Cells[5].Value = total;
            dataGridViewAddBarang.Rows.Add(newRow);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String nota = dataGridViewAddBarang.Rows[0].Cells[1].Value.ToString();
            String supplier = dataGridViewAddBarang.Rows[0].Cells[2].Value.ToString();
            String date_now = DateTime.UtcNow.ToString("yyyy-MM-dd");
            int subtotal = 0;
            String mx_id_beli = "";
            int index = dataGridViewAddBarang.Rows.Count;

            for (int rows = 0; rows < dataGridViewAddBarang.Rows.Count - 1; rows++)
            {
                subtotal += Convert.ToInt32(dataGridViewAddBarang.Rows[rows].Cells["hargaTotal"].Value);
            }
            //MessageBox.Show(subtotal.ToString());
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            conn.Open();

            String query = "INSERT INTO h_beli(ID_SUPPLIER , NOTA_PEMBELIAN , SUBTOTAL , STATUS_APPROVE , CREATED_AT , UPDATED_AT) " +
                "VALUES(@ID_SUPPLIER , @NOTA_PEMBELIAN , @SUBTOTAL , @STATUS_APPROVE , @CREATED_AT , @UPDATED_AT)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID_SUPPLIER", supplier);
            cmd.Parameters.AddWithValue("@NOTA_PEMBELIAN", nota);
            cmd.Parameters.AddWithValue("@SUBTOTAL", subtotal.ToString());
            cmd.Parameters.AddWithValue("@CREATED_AT", date_now);
            cmd.Parameters.AddWithValue("@UPDATED_AT", date_now);
            cmd.Parameters.AddWithValue("@STATUS_APPROVE", "0");
            cmd.ExecuteNonQuery();

            MySqlCommand id_hbeli = new MySqlCommand("select id from h_beli where nota_pembelian='" + nota + "'", conn);
            MySqlDataReader reader = id_hbeli.ExecuteReader();

            while (reader.Read())
            {
                mx_id_beli = reader.GetString("id");
            }
            conn.Close();



            conn.Open();
            for (int rows = 0; rows < dataGridViewAddBarang.Rows.Count - 1; rows++)
            {
                String Note = dataGridViewAddBarang.Rows[rows].Cells["nota_pembelian"].Value.ToString();
                String id_supplier = dataGridViewAddBarang.Rows[rows].Cells["id_supplier"].Value.ToString();
                String barang_id = dataGridViewAddBarang.Rows[rows].Cells["barang_id"].Value.ToString();
                String qty = dataGridViewAddBarang.Rows[rows].Cells["qty"].Value.ToString();
                String harga = dataGridViewAddBarang.Rows[rows].Cells["hargaTotal"].Value.ToString();


                String query_detail = "INSERT INTO d_beli(id_h_beli , id_barang , nota_pembelian , qty , sub_total , created_at , updated_at) " +
                    "VALUES(@id_h_beli , @id_barang , @nota_pembelian , @qty , @sub_total , @created_at , @updated_at)";
                MySqlCommand cmdDetail = new MySqlCommand(query_detail, conn);
                cmdDetail.Parameters.AddWithValue("@id_h_beli", mx_id_beli);
                cmdDetail.Parameters.AddWithValue("@id_barang", barang_id);
                cmdDetail.Parameters.AddWithValue("@nota_pembelian", Note);
                cmdDetail.Parameters.AddWithValue("@qty", qty);
                cmdDetail.Parameters.AddWithValue("@sub_total", harga);
                cmdDetail.Parameters.AddWithValue("@created_at", date_now);
                cmdDetail.Parameters.AddWithValue("@updated_at", date_now);
                cmdDetail.ExecuteNonQuery();
            }
            conn.Close();
            getMaxNota();
            displayPembelian();
            dataGridViewAddBarang.Rows.Clear();
        }

        private void dataGridViewDisplayPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                prove2 = new prove_pembelian();
                prove2.nota = dataGridViewDisplayPembelian.Rows[e.RowIndex].Cells["nota"].Value.ToString();
                //String nota = dataGridViewDisplayPembelian.Rows[e.RowIndex].Cells["nota"].Value.ToString();
                //MessageBox.Show(nota);
                prove2.ShowDialog();
                return;
            }
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlDataAdapter adapter = new MySqlDataAdapter("select hb.nota_pembelian , " +
                "s.nama_supplier " +
                "from h_beli hb " +
                "join supplier s on hb.id_supplier=s.id where hb.nota_pembelian LIKE '%"+txtcari.Text+"%'", conn);
            
            adapter.Fill(ds2, "display");
            dataGridViewDisplayPembelian.DataSource = ds2.Tables["display"];
            conn.Close();
        }
    }
}
