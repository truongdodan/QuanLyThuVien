using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmThongKeTheTV : Form
    {
        Func func = new Func();

        public FrmThongKeTheTV()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getTheTV()
        {
            thetvdgv.DataSource = func.getTable("v_TheTV");
        }
        private void blankSearchSection()
        {
            tinhtrangcbbx.SelectedIndex = 0;
            tinhtrangckbx.Checked = false;
        }

        private void searchTheTV()
        {
            string query = @"select DISTINCT TheTV.iMaTheTV as [Mã thẻ], sTenDocGia as [Tên độc giả], dNgaySinh as [Ngày sinh], sDonVi as [Đơn vị], sSDT as[SĐT], dNgayCap as [Ngày cấp], dNgayHetHan as [Ngày hết hạn]
                            from TheTV 
                            LEFT JOIN PhieuMuon ON TheTV.iMaTheTV = PhieuMuon.iMaTheTV 
                            LEFT JOIN CTPhieuMuon ON PhieuMuon.iMaPM = CTPhieuMuon.iMaPM 
                            WHERE 1 = 1 ";

            if (tinhtrangckbx.Checked == true)
            {
                if(tinhtrangcbbx.SelectedIndex == 0) { query += "AND dNgayHetHan < GETDATE() "; }
                else if(tinhtrangcbbx.SelectedIndex == 1) { query += "AND PhieuMuon.dNgayHenTra < GETDATE() "; }
            }

            func.getRecord(query, thetvdgv);
            func.updateDGVNumber(soluonglb, thetvdgv);
        }

        private void firstSetUp()
        {
            tinhtrangcbbx.Items.Add("Hết hạn");
            tinhtrangcbbx.Items.Add("Trả muộn sách");
            tinhtrangcbbx.SelectedIndex = 0;
        }


        //EVENT METHODS
        private void FrmThongKeTheTV_Load(object sender, EventArgs e)
        {
            func.connectDB();
            getTheTV();
            func.updateDGVNumber(soluonglb, thetvdgv);
            firstSetUp();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void thongkebttn_Click(object sender, EventArgs e)
        {
            searchTheTV();
        }
    }
}
