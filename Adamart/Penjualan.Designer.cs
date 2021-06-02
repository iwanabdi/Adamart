
namespace Adamart
{
    partial class Penjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbayar = new System.Windows.Forms.NumericUpDown();
            this.numqty = new System.Windows.Forms.NumericUpDown();
            this.txtkembali = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnettotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnamamember = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidmember = new System.Windows.Forms.TextBox();
            this.btncarimember = new System.Windows.Forms.Button();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtmerk = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtbarang = new System.Windows.Forms.TextBox();
            this.Cari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.dataGridViewpenjualan = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbayar);
            this.panel1.Controls.Add(this.numqty);
            this.panel1.Controls.Add(this.txtkembali);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtnettotal);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtnamamember);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtidmember);
            this.panel1.Controls.Add(this.btncarimember);
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.txtmerk);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtbarang);
            this.panel1.Controls.Add(this.Cari);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.dataGridViewpenjualan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // txtbayar
            // 
            this.txtbayar.Location = new System.Drawing.Point(523, 163);
            this.txtbayar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(172, 20);
            this.txtbayar.TabIndex = 39;
            this.txtbayar.ValueChanged += new System.EventHandler(this.txtbayar_TextChanged);
            // 
            // numqty
            // 
            this.numqty.Location = new System.Drawing.Point(104, 175);
            this.numqty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numqty.Name = "numqty";
            this.numqty.Size = new System.Drawing.Size(192, 20);
            this.numqty.TabIndex = 38;
            // 
            // txtkembali
            // 
            this.txtkembali.Location = new System.Drawing.Point(523, 191);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.ReadOnly = true;
            this.txtkembali.Size = new System.Drawing.Size(172, 20);
            this.txtkembali.TabIndex = 37;
            this.txtkembali.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(428, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Kembali";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(701, 121);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 75);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Bayar";
            // 
            // txtnettotal
            // 
            this.txtnettotal.Location = new System.Drawing.Point(523, 139);
            this.txtnettotal.Name = "txtnettotal";
            this.txtnettotal.ReadOnly = true;
            this.txtnettotal.Size = new System.Drawing.Size(172, 20);
            this.txtnettotal.TabIndex = 32;
            this.txtnettotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(418, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Net Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(523, 113);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(172, 20);
            this.txtdiscount.TabIndex = 32;
            this.txtdiscount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Discount";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(523, 87);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(172, 20);
            this.txttotal.TabIndex = 30;
            this.txttotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(457, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total";
            // 
            // txtnamamember
            // 
            this.txtnamamember.Location = new System.Drawing.Point(556, 39);
            this.txtnamamember.Name = "txtnamamember";
            this.txtnamamember.ReadOnly = true;
            this.txtnamamember.Size = new System.Drawing.Size(151, 20);
            this.txtnamamember.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nama Member";
            // 
            // txtidmember
            // 
            this.txtidmember.Location = new System.Drawing.Point(556, 14);
            this.txtidmember.Name = "txtidmember";
            this.txtidmember.Size = new System.Drawing.Size(151, 20);
            this.txtidmember.TabIndex = 26;
            // 
            // btncarimember
            // 
            this.btncarimember.Location = new System.Drawing.Point(713, 12);
            this.btncarimember.Name = "btncarimember";
            this.btncarimember.Size = new System.Drawing.Size(75, 23);
            this.btncarimember.TabIndex = 25;
            this.btncarimember.Text = "Cari Member";
            this.btncarimember.UseVisualStyleBackColor = true;
            this.btncarimember.Click += new System.EventHandler(this.btncarimember_Click);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(104, 150);
            this.txtharga.Name = "txtharga";
            this.txtharga.ReadOnly = true;
            this.txtharga.Size = new System.Drawing.Size(192, 20);
            this.txtharga.TabIndex = 24;
            // 
            // txtmerk
            // 
            this.txtmerk.Location = new System.Drawing.Point(104, 124);
            this.txtmerk.Name = "txtmerk";
            this.txtmerk.ReadOnly = true;
            this.txtmerk.Size = new System.Drawing.Size(192, 20);
            this.txtmerk.TabIndex = 24;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(105, 72);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(192, 20);
            this.txtid.TabIndex = 24;
            // 
            // txtbarang
            // 
            this.txtbarang.Location = new System.Drawing.Point(104, 98);
            this.txtbarang.Name = "txtbarang";
            this.txtbarang.ReadOnly = true;
            this.txtbarang.Size = new System.Drawing.Size(192, 20);
            this.txtbarang.TabIndex = 24;
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(303, 70);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(75, 23);
            this.Cari.TabIndex = 23;
            this.Cari.Text = "Cari";
            this.Cari.UseVisualStyleBackColor = true;
            this.Cari.Click += new System.EventHandler(this.Cari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(302, 169);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(97, 30);
            this.btnTambah.TabIndex = 21;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Merk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(104, 46);
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.Size = new System.Drawing.Size(192, 20);
            this.txtNota.TabIndex = 14;
            // 
            // dataGridViewpenjualan
            // 
            this.dataGridViewpenjualan.AllowUserToAddRows = false;
            this.dataGridViewpenjualan.AllowUserToDeleteRows = false;
            this.dataGridViewpenjualan.AllowUserToResizeColumns = false;
            this.dataGridViewpenjualan.AllowUserToResizeRows = false;
            this.dataGridViewpenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewpenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewpenjualan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewpenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewpenjualan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpenjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Id,
            this.nama_barang,
            this.Merk,
            this.harga_barang,
            this.Jumlah,
            this.Subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewpenjualan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewpenjualan.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewpenjualan.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewpenjualan.MultiSelect = false;
            this.dataGridViewpenjualan.Name = "dataGridViewpenjualan";
            this.dataGridViewpenjualan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpenjualan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewpenjualan.RowHeadersVisible = false;
            this.dataGridViewpenjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewpenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewpenjualan.ShowEditingIcon = false;
            this.dataGridViewpenjualan.Size = new System.Drawing.Size(776, 212);
            this.dataGridViewpenjualan.TabIndex = 2;
            // 
            // no
            // 
            this.no.HeaderText = "#";
            this.no.Name = "no";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID Barang";
            this.Id.Name = "Id";
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // Merk
            // 
            this.Merk.HeaderText = "Merk";
            this.Merk.Name = "Merk";
            // 
            // harga_barang
            // 
            this.harga_barang.HeaderText = "Harga Barang";
            this.harga_barang.Name = "harga_barang";
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.Name = "Jumlah";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "SubTotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Penjualan";
            // 
            // Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Penjualan";
            this.Text = "Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpenjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewpenjualan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtbarang;
        private System.Windows.Forms.Button Cari;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtmerk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnamamember;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidmember;
        private System.Windows.Forms.Button btncarimember;
        private System.Windows.Forms.TextBox txtkembali;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merk;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.NumericUpDown numqty;
        private System.Windows.Forms.TextBox txtnettotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtbayar;
    }
}