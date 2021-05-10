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
    public partial class Supplier_Form : Form
    {

        public String id, nomor_id, nama_supplier;
        private readonly Supplier _parent;
        koneksi db = new koneksi();
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter da;
        DataSet ds;

        public Supplier_Form(Supplier parent)
        {
            InitializeComponent();
            _parent = parent;
            conn = new MySqlConnection(db.conn());
            ds = new DataSet();
        }

        public void saveData()
        {
            label1.Text = "Form Tambah Data";
            btn_save.Text = "Simpan";
        }

        public void updateData()
        {
            label1.Text = "Form Edit Data";
            btn_save.Text = "Ubah";
            txtnomor.Text = nomor_id;
            txtnama.Text = nama_supplier;
            //MessageBox.Show(id);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            nomor_id = txtnomor.Text;
            nama_supplier = txtnama.Text;

            if (btn_save.Text == "Simpan")
            {
                String Query = "insert into supplier(nomor_id,nama_supplier) values('" + nomor_id + "','" + nama_supplier + "');";
                cmd = new MySqlCommand(Query, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasi Tambah Data");
                conn.Close();
                clear();
            }
            if (btn_save.Text == "Ubah")
            {
                string dt;
                DateTime date = DateTime.Now;
                dt = date.ToString("yyyy-MM-dd H:mm:ss");
                String Query = "update supplier set nomor_id='" + nomor_id + "', nama_supplier='" + nama_supplier + "', updated_at='"+ dt +"' where id = '" + id + "';";
                cmd = new MySqlCommand(Query, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasi Edit Data");
                conn.Close();
                clear();
                this.Close();
            }
            _parent.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            txtnomor.ResetText();
            txtnama.ResetText();
        }
    }
}
