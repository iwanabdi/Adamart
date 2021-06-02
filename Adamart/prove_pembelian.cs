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
    public partial class prove_pembelian : Form
    {
        public String nota , id_nota;
        koneksi db;
        public prove_pembelian()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            String query = "UPDATE h_beli SET STATUS_APPROVE=1 WHERE ID='"+id_nota+"'";
            conn.Open();
            MySqlCommand update = new MySqlCommand(query, conn);
            update.ExecuteNonQuery();
            conn.Close();

            
            for(int i = 0; i < dataGridDetail.Rows.Count -1; i++)
            {
                String id_barang = dataGridDetail.Rows[i].Cells["id_barang"].Value.ToString();
                int stok_baru =  Int32.Parse(dataGridDetail.Rows[i].Cells["qty"].Value.ToString());
                int stok_jum_jum = 0;


                MySqlCommand jum_stok = new MySqlCommand("select stok from barang where id='" + id_barang + "'" , conn);
                conn.Open();
                MySqlDataReader read_stok = jum_stok.ExecuteReader();
                while (read_stok.Read())
                {
                    int stok_awal = Int32.Parse(read_stok.GetString("stok"));
                    stok_jum_jum = stok_awal + stok_baru;
                    
                }
                conn.Close();
                
                String up_stok = "UPDATE barang SET stok='" + stok_jum_jum.ToString() + "' WHERE ID='" + id_barang + "'";
                conn.Open();
                MySqlCommand update_stok = new MySqlCommand(up_stok, conn);
                update_stok.ExecuteNonQuery();
                conn.Close();
            }
            this.Close();


        }

        private void prove_pembelian_Load(object sender, EventArgs e)
        {
            db = new koneksi();
            MySqlConnection conn = new MySqlConnection(db.conn());
            String approve = "";
            MySqlCommand id = new MySqlCommand("select id , status_approve from h_beli where nota_pembelian='"+nota+"' ", conn);

            conn.Open();
            MySqlDataReader reader = id.ExecuteReader();

            while (reader.Read())
            {
                id_nota = reader.GetString("id");
                approve = reader.GetString("status_approve");
            }
            conn.Close();

            if(approve == "1")
            {
                btn_approve.Visible = false;
            }


            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select db.id_barang , b.nama_barang , db.qty , db.sub_total from d_beli db join barang b on b.id=db.id_barang where id_h_beli='"+id_nota+"'", conn);
            DataSet barang = new DataSet();
            adapter.Fill(barang, "barang");
            dataGridDetail.DataSource = barang.Tables["barang"];
            conn.Close();
        }
    }
}
