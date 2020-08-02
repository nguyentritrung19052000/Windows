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
    public partial class frm_HoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        XLHOADON tblHoaDon;
        XLNHANVIEN tblNhanVien;
        BindingManagerBase DSHD;
        bool capnhat = false;
        public frm_HoaDonBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSHD.AddNew();
            capnhat = true;
            enableButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.RemoveAt(DSHD.Position);
                capnhat = false;
                tblHoaDon.ghi();
                tblHoaDon.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblHoaDon.RejectChanges();
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.EndCurrentEdit();
                tblHoaDon.ghi();
                tblHoaDon.AcceptChanges();
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
                DSHD.EndCurrentEdit();
                tblHoaDon.AcceptChanges();
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

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoaDon1.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.hoaDon1.SanPham);
            // TODO: This line of code loads data into the 'hoaDon1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hoaDon1.NhanVien);
            tblHoaDon = new XLHOADON();
            DSHD = this.BindingContext[tblHoaDon];
            loadNhanVien();


        }

        private void loadNhanVien()
        {
            dgvDSHDB.AutoGenerateColumns = false;
            dgvDSHDB.DataSource = tblHoaDon;
            txtMaHD.DataBindings.Add("text", tblHoaDon, "MaHD", true);
            cbMaNV.DataBindings.Add("SelectedValue", tblHoaDon, "MaNV", true);
            dateNgayHD.DataBindings.Add("text", tblHoaDon, "NgayHD", true);
            txtSoLuong.DataBindings.Add("text", tblHoaDon, "SoLuong", true);
            txtDonGia.DataBindings.Add("text", tblHoaDon, "DonGia", true);
            txtThanhTien.DataBindings.Add("text", tblHoaDon, "ThanhTien", true);
            DSHD = this.BindingContext[tblHoaDon];
            enableButton();
        }

        private void loadCBONhanVien()
        {
            cbMaNV.DataSource = tblNhanVien;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "TenNV";
        }
        
        private void LoadDGVHoaDon()
        {
            dgvDSHDB.AllowUserToOrderColumns = false;
            dgvDSHDB.DataSource = tblHoaDon;
        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = !capnhat;
            txtThanhTien.Enabled = capnhat;
        }

        private void dgvDSHDB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSHDB.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frm_InHoaDon f = new frm_InHoaDon();
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int dongia;
            int soluong;
            dongia = Convert.ToInt16(txtDonGia.Text);
            soluong = Convert.ToInt16(txtSoLuong.Text);
            int tien;
            tien = dongia * soluong;
            txtThanhTien.Text = tien.ToString();
        }
    }
}   

////