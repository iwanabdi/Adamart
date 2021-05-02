
namespace Adamart
{
    partial class Stok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttontmbktg = new System.Windows.Forms.Button();
            this.buttontmbbrg = new System.Windows.Forms.Button();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmerk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbkategori);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmerk);
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttontmbbrg);
            this.panel1.Controls.Add(this.buttontmbktg);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stok";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nama_barang,
            this.harga_barang,
            this.Merk,
            this.Stok_b,
            this.id_kategori,
            this.Kategori});
            this.dataGridView1.Location = new System.Drawing.Point(18, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.Frozen = true;
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.ReadOnly = true;
            this.nama_barang.Width = 97;
            // 
            // harga_barang
            // 
            this.harga_barang.DataPropertyName = "harga_barang";
            this.harga_barang.Frozen = true;
            this.harga_barang.HeaderText = "Harga Barang";
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.ReadOnly = true;
            this.harga_barang.Width = 98;
            // 
            // Merk
            // 
            this.Merk.DataPropertyName = "merk";
            this.Merk.Frozen = true;
            this.Merk.HeaderText = "Merk";
            this.Merk.Name = "Merk";
            this.Merk.ReadOnly = true;
            this.Merk.Width = 56;
            // 
            // Stok_b
            // 
            this.Stok_b.DataPropertyName = "Stok";
            this.Stok_b.Frozen = true;
            this.Stok_b.HeaderText = "Stok";
            this.Stok_b.Name = "Stok_b";
            this.Stok_b.ReadOnly = true;
            this.Stok_b.Width = 54;
            // 
            // id_kategori
            // 
            this.id_kategori.DataPropertyName = "id_kategori";
            this.id_kategori.Frozen = true;
            this.id_kategori.HeaderText = "Kategori ID";
            this.id_kategori.Name = "id_kategori";
            this.id_kategori.ReadOnly = true;
            this.id_kategori.Width = 85;
            // 
            // Kategori
            // 
            this.Kategori.DataPropertyName = "name";
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            this.Kategori.Width = 71;
            // 
            // buttontmbktg
            // 
            this.buttontmbktg.Location = new System.Drawing.Point(611, 316);
            this.buttontmbktg.Name = "buttontmbktg";
            this.buttontmbktg.Size = new System.Drawing.Size(124, 23);
            this.buttontmbktg.TabIndex = 5;
            this.buttontmbktg.Text = "Tambah Kategori";
            this.buttontmbktg.UseVisualStyleBackColor = true;
            // 
            // buttontmbbrg
            // 
            this.buttontmbbrg.Location = new System.Drawing.Point(611, 258);
            this.buttontmbbrg.Name = "buttontmbbrg";
            this.buttontmbbrg.Size = new System.Drawing.Size(124, 23);
            this.buttontmbbrg.TabIndex = 6;
            this.buttontmbbrg.Text = "Tambah Barang";
            this.buttontmbbrg.UseVisualStyleBackColor = true;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(598, 89);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(178, 20);
            this.txtnama.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama";
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(598, 132);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(178, 20);
            this.txtharga.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga";
            // 
            // txtmerk
            // 
            this.txtmerk.Location = new System.Drawing.Point(598, 177);
            this.txtmerk.Name = "txtmerk";
            this.txtmerk.Size = new System.Drawing.Size(178, 20);
            this.txtmerk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Merk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategori";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Harga";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(598, 222);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(178, 21);
            this.cbkategori.TabIndex = 9;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stok";
            this.Text = "Stok";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmerk;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttontmbbrg;
        private System.Windows.Forms.Button buttontmbktg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
    }
}