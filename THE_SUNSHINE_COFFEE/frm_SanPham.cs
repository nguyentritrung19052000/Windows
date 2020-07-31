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
using System.Data.SqlClient;
using THE_SUNSHINE_COFFEE.Modules;

namespace THE_SUNSHINE_COFFEE
{
    public partial class frm_SanPham : DevExpress.XtraEditors.XtraForm
    {
        SqlDataAdapter daSanPham;
        XLSANPHAM tblSanPham;
        BindingManagerBase DSQLSP;
        bool capnhat = false;
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            tblSanPham = new XLSANPHAM();
            LoadSanPham();
            DSQLSP = this.BindingContext[tblSanPham];

            txtMaSP.DataBindings.Add("text", tblSanPham, "MaSP", true);
            txtTenSP.DataBindings.Add("text", tblSanPham, "TenSP", true);
            txtDonGia.DataBindings.Add("text", tblSanPham, "DonGia", true);

            dgvDSSP.DataSource = tblSanPham;
            enableButton();
        }

        private void LoadSanPham()
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = tblSanPham;
        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            btnThoat.Enabled = capnhat;
            gTimKiem.Enabled = !capnhat;
            gThongTin.Enabled = capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             DSQLSP.AddNew();
             capnhat = true;
             enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSQLSP.RemoveAt(DSQLSP.Position);
                tblSanPham.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (SqlException ex)
            {
                tblSanPham.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSQLSP.CancelCurrentEdit();
            tblSanPham.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow r = tblSanPham.Select("MaSP='" + txtTimKiem.Text + "'")[0];
            DSQLSP.Position = tblSanPham.Rows.IndexOf(r);
            capnhat = true;
            enableButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSQLSP.EndCurrentEdit();
                tblSanPham.ghi();
                tblSanPham.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!!!");
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}