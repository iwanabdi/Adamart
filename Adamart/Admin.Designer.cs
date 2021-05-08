
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_tengah = new System.Windows.Forms.Panel();
            this.data_admin = new System.Windows.Forms.DataGridView();
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_kiri = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cbjabatan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.panel_atas = new System.Windows.Forms.Panel();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel_tengah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).BeginInit();
            this.panel_bawah.SuspendLayout();
            this.panel_kiri.SuspendLayout();
            this.panel_atas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_tengah);
            this.panel1.Controls.Add(this.panel_bawah);
            this.panel1.Controls.Add(this.panel_kiri);
            this.panel1.Controls.Add(this.panel_atas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_tengah
            // 
            this.panel_tengah.Controls.Add(this.data_admin);
            this.panel_tengah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tengah.Location = new System.Drawing.Point(273, 60);
            this.panel_tengah.Name = "panel_tengah";
            this.panel_tengah.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel_tengah.Size = new System.Drawing.Size(527, 361);
            this.panel_tengah.TabIndex = 27;
            // 
            // data_admin
            // 
            this.data_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.nomor_pegawai,
            this.nama_pegawai,
            this.jabatan,
            this.email,
            this.tgl_lahir});
            this.data_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_admin.Location = new System.Drawing.Point(0, 0);
            this.data_admin.Name = "data_admin";
            this.data_admin.Size = new System.Drawing.Size(517, 361);
            this.data_admin.TabIndex = 0;
            this.data_admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.data_admin.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_admin_RowPostPaint);
            // 
            // panel_bawah
            // 
            this.panel_bawah.Controls.Add(this.button2);
            this.panel_bawah.Controls.Add(this.button3);
            this.panel_bawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bawah.Location = new System.Drawing.Point(273, 421);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(527, 29);
            this.panel_bawah.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_kiri
            // 
            this.panel_kiri.Controls.Add(this.label2);
            this.panel_kiri.Controls.Add(this.txtnomor);
            this.panel_kiri.Controls.Add(this.label1);
            this.panel_kiri.Controls.Add(this.txtnama);
            this.panel_kiri.Controls.Add(this.label3);
            this.panel_kiri.Controls.Add(this.btn_save);
            this.panel_kiri.Controls.Add(this.label4);
            this.panel_kiri.Controls.Add(this.dateTimePicker1);
            this.panel_kiri.Controls.Add(this.txtemail);
            this.panel_kiri.Controls.Add(this.cbjabatan);
            this.panel_kiri.Controls.Add(this.label5);
            this.panel_kiri.Controls.Add(this.label6);
            this.panel_kiri.Controls.Add(this.txtpassword);
            this.panel_kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_kiri.Location = new System.Drawing.Point(0, 60);
            this.panel_kiri.Name = "panel_kiri";
            this.panel_kiri.Size = new System.Drawing.Size(273, 390);
            this.panel_kiri.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor Pegawai";
            // 
            // txtnomor
            // 
            this.txtnomor.Location = new System.Drawing.Point(13, 20);
            this.txtnomor.Name = "txtnomor";
            this.txtnomor.Size = new System.Drawing.Size(254, 20);
            this.txtnomor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama Pegawai";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(13, 60);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(254, 20);
            this.txtnama.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jabatan";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 253);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(254, 23);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Simpan";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(13, 138);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 20);
            this.txtemail.TabIndex = 13;
            // 
            // cbjabatan
            // 
            this.cbjabatan.FormattingEnabled = true;
            this.cbjabatan.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.cbjabatan.Location = new System.Drawing.Point(13, 98);
            this.cbjabatan.Name = "cbjabatan";
            this.cbjabatan.Size = new System.Drawing.Size(254, 21);
            this.cbjabatan.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tanggal Lahir";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(13, 177);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(254, 20);
            this.txtpassword.TabIndex = 15;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // panel_atas
            // 
            this.panel_atas.Controls.Add(this.lbl_admin);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(800, 60);
            this.panel_atas.TabIndex = 24;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(12, 10);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(95, 31);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "Admin";
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // nomor_pegawai
            // 
            this.nomor_pegawai.DataPropertyName = "nomor_pegawai";
            this.nomor_pegawai.HeaderText = "Nomor Pegawai";
            this.nomor_pegawai.Name = "nomor_pegawai";
            // 
            // nama_pegawai
            // 
            this.nama_pegawai.DataPropertyName = "nama_pegawai";
            this.nama_pegawai.HeaderText = "Nama Pegawai";
            this.nama_pegawai.Name = "nama_pegawai";
            // 
            // jabatan
            // 
            this.jabatan.DataPropertyName = "jabatan";
            this.jabatan.HeaderText = "Jabatan";
            this.jabatan.Name = "jabatan";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.DataPropertyName = "tgl_lahir";
            this.tgl_lahir.HeaderText = "Tanggal Lahir";
            this.tgl_lahir.Name = "tgl_lahir";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel_tengah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).EndInit();
            this.panel_bawah.ResumeLayout(false);
            this.panel_kiri.ResumeLayout(false);
            this.panel_kiri.PerformLayout();
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbjabatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel_bawah;
        private System.Windows.Forms.Panel panel_kiri;
        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Panel panel_tengah;
        private System.Windows.Forms.DataGridView data_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir;
    }
}