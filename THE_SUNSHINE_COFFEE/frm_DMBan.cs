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
    public partial class frm_DMBan : DevExpress.XtraEditors.XtraForm
    {
        SqlDataAdapter daBan;
        XLBAN tblBan;
        BindingManagerBase DSQLBAN;
        bool capnhat = false;

        public frm_DMBan()
        {
            InitializeComponent();
        }

        private void frm_DMBan_Load(object sender, EventArgs e)
        {
            tblBan = new XLBAN();
            LoadBan();
            DSQLBAN = this.BindingContext[tblBan];

            txtma.DataBindings.Add("text", tblBan, "MaBan", true);
            txtten.DataBindings.Add("text", tblBan, "TenBan", true);
            cbloai.DataBindings.Add("text", tblBan, "KhuVuc", true);

            DSQLBAN = this.BindingContext[tblBan];
            dgvqlban.DataSource = tblBan;
            enableButton();
        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            btnThoat.Enabled = capnhat;
        }

        private void LoadBan()
        {
            dgvqlban.AutoGenerateColumns = false;
            dgvqlban.DataSource = tblBan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSQLBAN.AddNew();
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
                DSQLBAN.RemoveAt(DSQLBAN.Position);
                daBan.Update(tblBan);
                tblBan.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblBan.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSQLBAN.EndCurrentEdit();
                tblBan.ghi();
                tblBan.AcceptChanges();
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
            DSQLBAN.CancelCurrentEdit();
            tblBan.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvqlban_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvqlban.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}