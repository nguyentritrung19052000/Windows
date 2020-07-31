using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace THE_SUNSHINE_COFFEE
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public string maNV;
        public frm_Main()
        {
            InitializeComponent();
        }

        public void PhanQuyen(int maLTK)
        {
            switch (maLTK)
            {
                case 1:
                    btnDangXuat.Enabled = true;
                    btnThoat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnHoaDon.Enabled = true;
                    btnThongke.Enabled = true;
                    break;
                case 2:
                    btnDangXuat.Enabled = true;
                    btnThoat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnHoaDon.Enabled = true;
                    btnThongke.Enabled = false;
                    break;
                default:
                    btnDangXuat.Enabled = false;
                    btnThoat.Enabled = false;
                    btnDoiMatKhau.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnHoaDon.Enabled = false;
                    btnThongke.Enabled = false;
                    break;
            }

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            PhanQuyen(-1);
            frm_DangNhap f = new frm_DangNhap(this);
            f.StartPosition = FormStartPosition.CenterParent;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDoiMatKhau");
            if (index >= 1)
            {
                tabControlMain.SelectedIndex = index;
            }
            else
            {
                frm_DoiMatKhau f = new frm_DoiMatKhau();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            frm_Main_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageNhanVien");
            if (index >= 1)
            {
                tabControlMain.SelectedIndex = index;
            }
            else
            {
                frm_NhanVien f = new frm_NhanVien();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageNhanVien";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageSanPham");
            if (index >= 1)
            {
                tabControlMain.SelectedIndex = index;
            }
            else
            {
                frm_SanPham f = new frm_SanPham();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageSanPham";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }

        private void btnBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDMBan");
            if (index >= 1)
            {
                tabControlMain.SelectedIndex = index;
            }
            else
            {
                frm_DMBan f = new frm_DMBan();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDMBan";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }

        private void btnHangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int index = tabControlMain.TabPages.IndexOfKey("tabPageHangNhap");
            if (index >= 1)
            {
                tabControlMain.SelectedIndex = index;
            }
            else
            {
                frm_HangNhap f = new frm_HangNhap();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageHangNhap";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab = p;
                f.Show();
            }
        }
    }
}