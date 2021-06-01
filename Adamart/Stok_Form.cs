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
    public partial class Stok_Form : Form
    {

        public String id, kategori, nama_barang, merk, harga_barang;
        private readonly Stok _parent;
        private MySqlConnection conn;
        private DataSet ds;

        public Stok_Form(Stok parent)
        {
            InitializeComponent();
            _parent = parent;
            koneksi cone = new koneksi();
            conn = new MySqlConnection(cone.conn());
            ds = new DataSet();
            loadkategori();
        }

        public void saveInfo()
        {
            label1.Text = "Form Tambah Data";
            btn_save.Text = "Simpan";
        }

        public void updateData()
        {
            label1.Text = "Form Edit Data";
            btn_save.Text = "Ubah";
            txtnama.Text = nama_barang;
            txtharga.Text = harga_barang;
            txtmerk.Text = merk;
            cbkategori.SelectedItem = kategori;
            //MessageBox.Show(kategori);
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            nama_barang = txtnama.Text;
            harga_barang = txtharga.Text;
            merk = txtmerk.Text;
            kategori = (cbkategori.SelectedValue).ToString();

            koneksi cone = new koneksi();
            MySqlConnection MyConn2 = new MySqlConnection(cone.conn());

            if (btn_save.Text == "Simpan")
            {
                string Query = "insert into barang(nama_barang,harga_barang,merk,id_kategori) " +
                    "values('" + nama_barang + "','" + harga_barang + "','" + merk + "','" + kategori + "');";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Berhasil Tambah Data");
                MyConn2.Close();
                clear();
            }
            if (btn_save.Text == "Ubah")
            {
                string Query = "update barang set harga_barang ='" + harga_barang + "',nama_barang ='" + nama_barang + "',Merk ='" + merk + "',id_kategori ='" + kategori + "', updated_at=sysdate()" +
                    "where id = '" + id + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Berhasil Ubah Data");
                MyConn2.Close();
                this.Close();
            }
            _parent.loadstok();

        }

        public void loadkategori()
        {
            ds.Tables.Clear();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,name FROM kategori_barang", conn);
            da.Fill(ds, "kategori");
            cbkategori.DataSource = ds.Tables["kategori"];
            cbkategori.ValueMember = "id";
            cbkategori.DisplayMember = "name";
            conn.Close();
        }

        public void clear()
        {
            txtnama.ResetText();
            txtmerk.ResetText();
            txtharga.ResetText();
            cbkategori.ResetText();
        }

    }
}
