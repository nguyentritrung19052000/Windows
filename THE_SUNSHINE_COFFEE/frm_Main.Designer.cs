﻿namespace THE_SUNSHINE_COFFEE
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangXuat,
            this.btnThoat,
            this.btnNhanVien,
            this.btnHoaDon,
            this.btnDoiMatKhau,
            this.btnSanPham,
            this.btnBan,
            this.btnHangNhap,
            this.barButtonItem1,
            this.btnThongKe});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(840, 141);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 3;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Caption = "Hóa Đơn Bán";
            this.btnHoaDon.Id = 4;
            this.btnHoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoaDon.ImageOptions.SvgImage")));
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDon_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 6;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Caption = "Sản Phẩm";
            this.btnSanPham.Id = 7;
            this.btnSanPham.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSanPham.ImageOptions.SvgImage")));
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSanPham_ItemClick);
            // 
            // btnBan
            // 
            this.btnBan.Caption = "Danh Mục Bàn";
            this.btnBan.Id = 8;
            this.btnBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBan.ImageOptions.SvgImage")));
            this.btnBan.Name = "btnBan";
            this.btnBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBan_ItemClick);
            // 
            // btnHangNhap
            // 
            this.btnHangNhap.Caption = "Hàng Nhập";
            this.btnHangNhap.Id = 9;
            this.btnHangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHangNhap.ImageOptions.SvgImage")));
            this.btnHangNhap.Name = "btnHangNhap";
            this.btnHangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHangNhap_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Caption = "Thống Kê";
            this.btnThongKe.Id = 12;
            this.btnThongKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKe.ImageOptions.SvgImage")));
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rbQuanLy,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.ItemLinks.Add(this.btnNhanVien);
            this.rbQuanLy.ItemLinks.Add(this.btnSanPham);
            this.rbQuanLy.ItemLinks.Add(this.btnBan);
            this.rbQuanLy.ItemLinks.Add(this.btnHangNhap);
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Text = "Quản Lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHoaDon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnThongKe);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 141);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(840, 260);
            this.tabControlMain.TabIndex = 2;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 401);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frm_Main";
            this.Text = "THE_SUNSHINE_COFFEE";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnHoaDon;
      
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private System.Windows.Forms.TabControl tabControlMain;
        private DevExpress.XtraBars.BarButtonItem btnSanPham;
        private DevExpress.XtraBars.BarButtonItem btnBan;
        private DevExpress.XtraBars.BarButtonItem btnHangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnThongKe;
    }
}