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
using THE_SUNSHINE_COFFEE.Modules;
namespace THE_SUNSHINE_COFFEE
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        frm_Main fMain = null;
        XLNHANVIEN tblNhanVien;
        public frm_DangNhap(frm_Main pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DataRow[] r = tblNhanVien.Select("TaiKhoan='" + txtUsername.Text + "' and MatKhau='" + txtPassword.Text + "'");
            if (r.Count() > 0)
            {
                fMain.Text = "Quản Lý Nhà Sách - Chào " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.PhanQuyen((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
                MessageBox.Show("Sai tên tài khoản và mật khẩu !!!");
        }
    }
}