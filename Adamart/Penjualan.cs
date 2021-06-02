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
    public partial class Penjualan : Form
    {
        koneksi db;
        string id_peg;
        public Penjualan(String id)
        {
            InitializeComponent();
            db = new koneksi();
            //getBarang();
            getMaxNota();
            id_peg = id;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(numqty.Value*int.Parse(txtharga.Text)+"");
            if (txtid.TextLength == 0 || numqty.Value<=0)
            {
                MessageBox.Show("Isi barang dahili");
            }
            else
            {
                String subtotal = numqty.Value * int.Parse(txtharga.Text) + "";
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewpenjualan);
                newRow.Cells[0].Value = dataGridViewpenjualan.Rows.Count + 1.ToString();
                newRow.Cells[1].Value = txtid.Text;
                newRow.Cells[2].Value = txtbarang.Text;
                newRow.Cells[3].Value = txtmerk.Text;
                newRow.Cells[4].Value = txtharga.Text;
                newRow.Cells[5].Value = numqty.Value;
                newRow.Cells[6].Value = subtotal;
                dataGridViewpenjualan.Rows.Add(newRow);

                txttotal.Text = int.Parse(txttotal.Text) + int.Parse(subtotal) + "";


                if (txtidmember.TextLength == 0)
                {
                    txtdiscount.Text = 0 + "";
                }
                else
                {
                    txtdiscount.Text = (int.Parse(txttotal.Text) * 0.05)+"";
                }

                txtnettotal.Text = int.Parse(txttotal.Text) - int.Parse(txtdiscount.Text) + "";
                clearisi();
            }
            
        }

        public void clearisi()
        {
            txtbarang.Text = "";
            txtid.Text = "";
            txtharga.Text = "";
            txtmerk.Text = "";
            numqty.Value = 0;
        }

        private void Cari_Click(object sender, EventArgs e)
        {
            CariBarang cr = new CariBarang(this);
            cr.ShowDialog();
        }

        public void getMaxNota()
        {
            MySqlConnection conn = new MySqlConnection(db.conn());
            MySqlCommand nota = new MySqlCommand("select LPAD(count(id)+1,3,0) as total from h_jual where tanggal=curdate()", conn);
            conn.Open();
            MySqlDataReader reader = nota.ExecuteReader();

            while (reader.Read())
            {
                string date = DateTime.UtcNow.ToString("yyyymmdd");
                txtNota.Text = date + reader.GetString("total");
            }
        }

        public void isidatabrng(String id,String Barang, String Merk, String Harga)
        {
            txtbarang.Text = Barang;
            txtharga.Text = Harga;
            txtmerk.Text = Merk;
            txtid.Text = id;
        }

        private void btncarimember_Click(object sender, EventArgs e)
        {

        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            if (txtbayar.Value>0) { 
                txtkembali.Text = int.Parse(txtbayar.Text) - int.Parse(txtnettotal.Text) + "";
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(db.conn());
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into h_jual(nota_jual,id_member,id_pegawai,total,bayar,kembali,diskon,tanggal) values(@notajual,0,@pegutama,@total,@bayar,@kembali,@diskon,sysdate())";
                cmd.Parameters.AddWithValue("@notajual", txtNota.Text);
                cmd.Parameters.AddWithValue("@pegutama", id_peg);
                cmd.Parameters.AddWithValue("@total", txttotal.Text);
                cmd.Parameters.AddWithValue("@bayar", txtbayar.Value);
                cmd.Parameters.AddWithValue("@kembali", txtkembali.Text);
                cmd.Parameters.AddWithValue("@diskon", txtdiscount.Text);
                cmd.ExecuteNonQuery();


                for (int i = 0; i < dataGridViewpenjualan.Rows.Count; i++)
                {
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1.CommandText = "insert into d_jual(id_barang,id_h_jual,qty,sub_total,created_at) values(@id_barang,@id_h_jual,@qty,@sub_total,sysdate())";
                    cmd1.Connection = conn;
                    cmd1.Parameters.AddWithValue("@id_h_jual", txtNota.Text);
                    cmd1.Parameters.AddWithValue("@id_barang", dataGridViewpenjualan[1,i].Value);
                    cmd1.Parameters.AddWithValue("@qty", dataGridViewpenjualan[5,i].Value);
                    cmd1.Parameters.AddWithValue("@sub_total", dataGridViewpenjualan[4,i].Value);
                    cmd1.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                trans.Rollback();
            }
        }
    }
}
