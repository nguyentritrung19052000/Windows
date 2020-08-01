using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using THE_SUNSHINE_COFFEE.Modules;

namespace THE_SUNSHINE_COFFEE
{
    public partial class frm_InHoaDon : Form
    {
        public frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
            string query = "select MaHD, MaNV, MaSP, SoLuong, DonGia, SoLuong*DonGia as ThanhTien from HoaDonBan";
            
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblThanhToan = new DataTable();
                da.Fill(tblThanhToan);
                rptTinhTien rpt = new rptTinhTien();
                rpt.SetDataSource(tblThanhToan);
                rptvThanhToan.ReportSource = rpt;

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
