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
    public partial class frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");
            //check Password New
            if (txtPassNew.Text.Length < 8 || !txtPassNew.Text.Any(char.IsDigit)
                || !txtPassNew.Text.Any(char.IsLower) || !txtPassNew.Text.Any(char.IsUpper)) ;
            {
                errorProvider1.SetError(txtPassNew, "Mật khẩu mới tối thiểu 8 kí tự, gồm chữ số, " + "in hoa, in thường.");
                return;
            }
            //check Password Confirm

            if (txtPassNew.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "Mật khẩu nhập lại không trùng !!!");
                return;
            }

            frm_Main f = (frm_Main)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password= '" + txtPassNew.Text + "' where MaNV = '" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Mật khẩu không hợp lệ !!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}