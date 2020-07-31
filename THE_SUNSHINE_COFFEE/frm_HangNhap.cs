﻿using System;
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
    public partial class frm_HangNhap : DevExpress.XtraEditors.XtraForm
    {
        XLHANGNHAP tblHangNhap;
        SqlDataAdapter daHangNhap;
        BindingManagerBase DSHN;
        bool capnhat = false;
        public frm_HangNhap()
        {
            InitializeComponent();
        }

        private void frm_HangNhap_Load(object sender, EventArgs e)
        {
            tblHangNhap = new XLHANGNHAP();
            DSHN = this.BindingContext[tblHangNhap];
            loadHangNhap();
        }

        private void loadHangNhap()
        {
            dgvDSHN.AutoGenerateColumns = false;
            dgvDSHN.DataSource = tblHangNhap;
            txtTenHang.DataBindings.Add("text", tblHangNhap, "TenHN", true);
            txtDVT.DataBindings.Add("text", tblHangNhap, "DonViTinh", true);
            txtSoLuong.DataBindings.Add("text", tblHangNhap, "SoLuong", true);
            txtDonGia.DataBindings.Add("text", tblHangNhap, "DonGia", true);
            txtTongTien.DataBindings.Add("text", tblHangNhap, "TongTien", true);
            DSHN = this.BindingContext[tblHangNhap];
            enableButton();
        }
        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnLuu.Enabled = !capnhat;
            btnHuy.Enabled = !capnhat;
            btnThoat.Enabled = !capnhat;
            gThongTin.Enabled = capnhat;
            gTimKiem.Enabled = capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSHN.AddNew();
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
                DSHN.RemoveAt(DSHN.Position);
                daHangNhap.Update(tblHangNhap);
                tblHangNhap.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblHangNhap.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSHN.EndCurrentEdit();
                daHangNhap.Update(tblHangNhap);
                tblHangNhap.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSHN.CancelCurrentEdit();
            tblHangNhap.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}