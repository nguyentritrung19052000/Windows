﻿namespace THE_SUNSHINE_COFFEE
{
    partial class frm_DMBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DMBan));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.dgvqlban = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnThongtin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlban)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÀN";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(234, 236);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 58);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(125, 236);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 58);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbloai
            // 
            this.cbloai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(125, 105);
            this.cbloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(136, 31);
            this.cbloai.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(13, 236);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 58);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtten
            // 
            this.txtten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(125, 64);
            this.txtten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(201, 32);
            this.txtten.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(234, 171);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 58);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(125, 20);
            this.txtma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(201, 32);
            this.txtma.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(125, 171);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 58);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvqlban
            // 
            this.dgvqlban.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvqlban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Maban,
            this.TenBan,
            this.KhuVuc});
            this.dgvqlban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvqlban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.dgvqlban.Location = new System.Drawing.Point(358, 59);
            this.dgvqlban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvqlban.Name = "dgvqlban";
            this.dgvqlban.RowHeadersWidth = 51;
            this.dgvqlban.Size = new System.Drawing.Size(622, 266);
            this.dgvqlban.TabIndex = 23;
            this.dgvqlban.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvqlban_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 75;
            // 
            // Maban
            // 
            this.Maban.DataPropertyName = "MaBan";
            this.Maban.HeaderText = "Mã Bàn";
            this.Maban.MinimumWidth = 6;
            this.Maban.Name = "Maban";
            this.Maban.Width = 125;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.MinimumWidth = 6;
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 125;
            // 
            // KhuVuc
            // 
            this.KhuVuc.DataPropertyName = "KhuVuc";
            this.KhuVuc.HeaderText = "Khu Vực";
            this.KhuVuc.MinimumWidth = 6;
            this.KhuVuc.Name = "KhuVuc";
            this.KhuVuc.Width = 150;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(15, 171);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 58);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khu Vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bàn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 59);
            this.panel1.TabIndex = 21;
            // 
            // pnThongtin
            // 
            this.pnThongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnThongtin.Controls.Add(this.btnThoat);
            this.pnThongtin.Controls.Add(this.btnHuy);
            this.pnThongtin.Controls.Add(this.cbloai);
            this.pnThongtin.Controls.Add(this.btnLuu);
            this.pnThongtin.Controls.Add(this.txtten);
            this.pnThongtin.Controls.Add(this.btnXoa);
            this.pnThongtin.Controls.Add(this.txtma);
            this.pnThongtin.Controls.Add(this.btnSua);
            this.pnThongtin.Controls.Add(this.btnThem);
            this.pnThongtin.Controls.Add(this.label5);
            this.pnThongtin.Controls.Add(this.label3);
            this.pnThongtin.Controls.Add(this.label2);
            this.pnThongtin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnThongtin.Location = new System.Drawing.Point(0, 0);
            this.pnThongtin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(358, 325);
            this.pnThongtin.TabIndex = 22;
            // 
            // frm_DMBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 325);
            this.Controls.Add(this.dgvqlban);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnThongtin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DMBan";
            this.Text = "frm_DMBan";
            this.Load += new System.EventHandler(this.frm_DMBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlban)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnThongtin.ResumeLayout(false);
            this.pnThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ComboBox cbloai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtten;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox txtma;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.DataGridView dgvqlban;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnThongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maban;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
    }
}