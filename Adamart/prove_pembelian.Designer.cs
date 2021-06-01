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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_approve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 169);
            this.dataGridView1.TabIndex = 29;
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
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(291, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "TUTUP";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // prove_pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_atas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prove_pembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prove_pembelian";
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button button2;
    }
}