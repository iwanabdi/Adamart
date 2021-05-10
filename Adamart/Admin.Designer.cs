
namespace Adamart
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_atas = new System.Windows.Forms.Panel();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.data_admin = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_atas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.Brown;
            this.panel_atas.Controls.Add(this.lbl_admin);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.ForeColor = System.Drawing.Color.White;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(800, 50);
            this.panel_atas.TabIndex = 24;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(12, 10);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(218, 31);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "Halaman Admin";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtcari);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.data_admin);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 25;
            // 
            // txtcari
            // 
            this.txtcari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(518, 30);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(237, 25);
            this.txtcari.TabIndex = 2;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // data_admin
            // 
            this.data_admin.AllowUserToAddRows = false;
            this.data_admin.AllowUserToDeleteRows = false;
            this.data_admin.AllowUserToResizeColumns = false;
            this.data_admin.AllowUserToResizeRows = false;
            this.data_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_admin.BackgroundColor = System.Drawing.Color.White;
            this.data_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_admin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_admin.ColumnHeadersHeight = 35;
            this.data_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nomor_pegawai,
            this.nama_pegawai,
            this.Email,
            this.tgl_lahir,
            this.jabatan,
            this.edit,
            this.hapus,
            this.password});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_admin.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_admin.GridColor = System.Drawing.Color.RosyBrown;
            this.data_admin.Location = new System.Drawing.Point(14, 81);
            this.data_admin.MultiSelect = false;
            this.data_admin.Name = "data_admin";
            this.data_admin.ReadOnly = true;
            this.data_admin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_admin.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_admin.RowHeadersVisible = false;
            this.data_admin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_admin.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.data_admin.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_admin.ShowEditingIcon = false;
            this.data_admin.Size = new System.Drawing.Size(770, 307);
            this.data_admin.TabIndex = 0;
            this.data_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_admin_CellClick);
            this.data_admin.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_admin_RowPostPaint_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(14, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 38);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Tambah Data";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Adamart.Properties.Resources.search_icon_png_9985_Windows;
            this.pictureBox1.Location = new System.Drawing.Point(754, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.FillWeight = 10F;
            this.no.HeaderText = "#";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // nomor_pegawai
            // 
            this.nomor_pegawai.DataPropertyName = "nomor_pegawai";
            this.nomor_pegawai.FillWeight = 57.53121F;
            this.nomor_pegawai.HeaderText = "Nomor Pegawai";
            this.nomor_pegawai.Name = "nomor_pegawai";
            this.nomor_pegawai.ReadOnly = true;
            // 
            // nama_pegawai
            // 
            this.nama_pegawai.DataPropertyName = "nama_pegawai";
            this.nama_pegawai.FillWeight = 57.53121F;
            this.nama_pegawai.HeaderText = "Nama Pegawai";
            this.nama_pegawai.Name = "nama_pegawai";
            this.nama_pegawai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 57.53121F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.DataPropertyName = "tgl_lahir";
            this.tgl_lahir.FillWeight = 57.53121F;
            this.tgl_lahir.HeaderText = "Tanggal Lahir";
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.ReadOnly = true;
            // 
            // jabatan
            // 
            this.jabatan.DataPropertyName = "jabatan";
            this.jabatan.FillWeight = 57.53121F;
            this.jabatan.HeaderText = "Jabatan";
            this.jabatan.Name = "jabatan";
            this.jabatan.ReadOnly = true;
            // 
            // edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.edit.FillWeight = 20F;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // hapus
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.hapus.DefaultCellStyle = dataGridViewCellStyle3;
            this.hapus.FillWeight = 20F;
            this.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus.HeaderText = "";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Pass";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_atas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Shown += new System.EventHandler(this.Admin_Shown);
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.DataGridView data_admin;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatan;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}