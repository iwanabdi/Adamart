
namespace Adamart
{
    partial class Pembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewAddBarang = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_pembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barang_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisplayPembelian = new System.Windows.Forms.DataGridView();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.upQty = new System.Windows.Forms.DomainUpDown();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.panel_atas = new System.Windows.Forms.Panel();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayPembelian)).BeginInit();
            this.panel_atas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtcari);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dataGridViewAddBarang);
            this.panel1.Controls.Add(this.dataGridViewDisplayPembelian);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.upQty);
            this.panel1.Controls.Add(this.cbBarang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtcari
            // 
            this.txtcari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(521, 18);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(237, 25);
            this.txtcari.TabIndex = 17;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Adamart.Properties.Resources.search_icon_png_9985_Windows;
            this.pictureBox1.Location = new System.Drawing.Point(757, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(0, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(800, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewAddBarang
            // 
            this.dataGridViewAddBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddBarang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAddBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAddBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nota_pembelian,
            this.id_supplier,
            this.barang_id,
            this.qty,
            this.hargaTotal});
            this.dataGridViewAddBarang.Location = new System.Drawing.Point(18, 307);
            this.dataGridViewAddBarang.Name = "dataGridViewAddBarang";
            this.dataGridViewAddBarang.Size = new System.Drawing.Size(770, 199);
            this.dataGridViewAddBarang.TabIndex = 14;
            this.dataGridViewAddBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // no
            // 
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            // 
            // nota_pembelian
            // 
            this.nota_pembelian.HeaderText = "Nota";
            this.nota_pembelian.Name = "nota_pembelian";
            // 
            // id_supplier
            // 
            this.id_supplier.HeaderText = "SUPPLIER ID";
            this.id_supplier.Name = "id_supplier";
            // 
            // barang_id
            // 
            this.barang_id.HeaderText = "BARANG ID";
            this.barang_id.Name = "barang_id";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // hargaTotal
            // 
            this.hargaTotal.HeaderText = "Harga";
            this.hargaTotal.Name = "hargaTotal";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(110, 114);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(192, 21);
            this.cbSupplier.TabIndex = 13;
            // 
            // dataGridViewDisplayPembelian
            // 
            this.dataGridViewDisplayPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisplayPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayPembelian.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDisplayPembelian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDisplayPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nota,
            this.nama_supplier,
            this.prove});
            this.dataGridViewDisplayPembelian.Location = new System.Drawing.Point(339, 61);
            this.dataGridViewDisplayPembelian.Name = "dataGridViewDisplayPembelian";
            this.dataGridViewDisplayPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisplayPembelian.Size = new System.Drawing.Size(450, 175);
            this.dataGridViewDisplayPembelian.TabIndex = 11;
            this.dataGridViewDisplayPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplayPembelian_CellClick);
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota_pembelian";
            this.nota.HeaderText = "Nota Pembelian";
            this.nota.Name = "nota";
            // 
            // nama_supplier
            // 
            this.nama_supplier.DataPropertyName = "nama_supplier";
            this.nama_supplier.HeaderText = "Nama Supplier";
            this.nama_supplier.Name = "nama_supplier";
            // 
            // prove
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.prove.DefaultCellStyle = dataGridViewCellStyle17;
            this.prove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prove.HeaderText = "";
            this.prove.Name = "prove";
            this.prove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prove.Text = "Detail";
            this.prove.UseColumnTextForButtonValue = true;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTambah.Location = new System.Drawing.Point(18, 256);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(284, 30);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qty";
            // 
            // upQty
            // 
            this.upQty.Location = new System.Drawing.Point(110, 210);
            this.upQty.Name = "upQty";
            this.upQty.Size = new System.Drawing.Size(192, 20);
            this.upQty.TabIndex = 8;
            // 
            // cbBarang
            // 
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(110, 163);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(192, 21);
            this.cbBarang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(110, 71);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(192, 20);
            this.txtNota.TabIndex = 1;
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.Brown;
            this.panel_atas.Controls.Add(this.lbl_stok);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.ForeColor = System.Drawing.Color.White;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(800, 50);
            this.panel_atas.TabIndex = 27;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(12, 10);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(273, 31);
            this.lbl_stok.TabIndex = 0;
            this.lbl_stok.Text = "Halaman Pembelian";
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel_atas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayPembelian)).EndInit();
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown upQty;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dataGridViewDisplayPembelian;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.DataGridView dataGridViewAddBarang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn barang_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_supplier;
        private System.Windows.Forms.DataGridViewButtonColumn prove;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}