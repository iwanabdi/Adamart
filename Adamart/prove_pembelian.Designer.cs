namespace Adamart
{
    partial class prove_pembelian
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
            this.panel_atas = new System.Windows.Forms.Panel();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.dataGridDetail = new System.Windows.Forms.DataGridView();
            this.btn_approve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.Brown;
            this.panel_atas.Controls.Add(this.lbl_stok);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.ForeColor = System.Drawing.Color.White;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(552, 50);
            this.panel_atas.TabIndex = 28;
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
            // dataGridDetail
            // 
            this.dataGridDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.nama_barang,
            this.Qty,
            this.total});
            this.dataGridDetail.Location = new System.Drawing.Point(12, 69);
            this.dataGridDetail.Name = "dataGridDetail";
            this.dataGridDetail.Size = new System.Drawing.Size(528, 169);
            this.dataGridDetail.TabIndex = 29;
            // 
            // btn_approve
            // 
            this.btn_approve.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_approve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_approve.Location = new System.Drawing.Point(12, 255);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(273, 30);
            this.btn_approve.TabIndex = 30;
            this.btn_approve.Text = "APPROVE";
            this.btn_approve.UseVisualStyleBackColor = false;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(291, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "TUTUP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.Name = "id_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "qty";
            this.Qty.HeaderText = "qty";
            this.Qty.Name = "Qty";
            // 
            // total
            // 
            this.total.DataPropertyName = "sub_total";
            this.total.HeaderText = "Total Pembelian";
            this.total.Name = "total";
            // 
            // prove_pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.dataGridDetail);
            this.Controls.Add(this.panel_atas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prove_pembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prove_pembelian";
            this.Load += new System.EventHandler(this.prove_pembelian_Load);
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.DataGridView dataGridDetail;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}