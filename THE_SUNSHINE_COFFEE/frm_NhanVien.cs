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
using System.Data.SqlClient;

namespace THE_SUNSHINE_COFFEE
{
    public partial class frm_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        XLNHANVIEN tblNhanVien;
        BindingManagerBase DSNV;
        bool capnhat = false;
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DSNV = this.BindingContext[tblNhanVien];
            loadNhanVien();
        }

        private void loadNhanVien()
        {
            dgvDSNV.AutoGenerateColumns = false;
            dgvDSNV.DataSource = tblNhanVien;
            txtMaNV.DataBindings.Add("text", tblNhanVien, "MaNV", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "TenNV", true);
            dateNgaySinh.DataBindings.Add("value", tblNhanVien, "NgaySinh", true);
            radNam.DataBindings.Add("checked", tblNhanVien, "GioiTinh", true);
            txtSDT.DataBindings.Add("text", tblNhanVien, "SoDT", true);
            txtDiaChi.DataBindings.Add("text", tblNhanVien, "DiaChi", true);
            DSNV = this.BindingContext[tblNhanVien];
            enableButton();
        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            gThongTin.Enabled = capnhat;
            gTimKiem.Enabled = !capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DSNV.AddNew();
            capnhat = true;
            enableButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblNhanVien.Select("MaNV='" + txtTimKiem.Text + "'")[0];
                DSNV.Position = tblNhanVien.Rows.IndexOf(r);
                capnhat = true;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Result");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                DSNV.RemoveAt(DSNV.Position);
                capnhat = false;
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();
                capnhat = false;
                enableButton();
                MessageBox.Show("Cập nhật thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                tblNhanVien.AcceptChanges();
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

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            radNu.Checked = !radNam.Checked;
        }

        private void dgvDSNV_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSNV.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}