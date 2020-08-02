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
    public partial class frm_ThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThongKe()
        {      
              InitializeComponent();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            string query = "select count(MaHD) as 'Tong so hoa don', sum(ThanhTien) as 'Tong Tien', sum(SoLuong) as 'Tong So Luong'" +
                " from HoaDonBan";
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblThongKe = new DataTable();
                da.Fill(tblThongKe);
                dgvThongKe.DataSource = tblThongKe;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}