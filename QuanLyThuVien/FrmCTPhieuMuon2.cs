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
    public partial class FrmCTPhieuMuon2 : Form
    {
        Func func = new Func();

        public FrmCTPhieuMuon2()
        {
            InitializeComponent();
        }
        //FUNCTION METHODS
        private void getCTPhieuMuon()
        {
            ctphieumuondgv.DataSource = func.getTable("v_CTPhieuMuon");
        }

        private void blankSearchSection()
        {
            theomathetvtxtbx.Text = "";
            theotensachtxtbx.Text = "";
            theomaphieumuontxtbx.Text = "";
        }

        private void searchCTPhieuMuon()
        {
            string query = @"select CTPhieuMuon.iMaPM as [Mã PM], 
		                            Sach.sTenSach as [Tên sách], 
		                            CASE WHEN iTinhTrangSachBanDau = 0 THEN N'Không nguyên vẹn'
			                             WHEN iTinhTrangSachBanDau = 1 THEN N'Nguyên vẹn'
			                             ELSE 'Unknown'
		                            END AS [TT sách ban đầu], 
		                            sChiTietTinhTrangBanDau as [CTTT sách ban đầu],
		                            dNgayTra as [Ngày trả],
		                            CASE WHEN iTinhTrang = 0 THEN N'Chưa trả'
			                             WHEN iTinhTrang = 1 THEN N'Làm mất'
			                             WHEN iTinhTrang = 2 THEN N'Đã trả/Nguyên vẹn'
			                             WHEN iTinhTrang = 3 THEN N'Đã trả/Không nguyên vẹn'
			                             ELSE 'Unknown'
		                            END AS [Tình trạng], 
		                            sChiTietTinhTrangSau as [CTTT sau], 
		                            fTienPhat as [Tiền phạt]
                            from CTPhieuMuon, Sach, PhieuMuon
                            where CTPhieuMuon.iMaSach = Sach.iMaSach AND
                                  CTPhieuMuon.iMaPM = PhieuMuon.iMaPM AND 1 = 1 ";

            if (theomathetvckbx.Checked && theomathetvtxtbx.Text != "")
            {
                query += "AND PhieuMuon.iMaTheTV = " + int.Parse(theomathetvtxtbx.Text) + " ";
            }
            if (theotensachckbx.Checked && theotensachtxtbx.Text != "")
            {
                query += "AND Sach.sTenSach LIKE N'%" + theotensachtxtbx.Text + "%' ";
            }
            if (theomaphieumuonckbx.Checked && theotensachtxtbx.Text != "")
            {
                query += "AND CTPhieuMuon.iMaPM = " + int.Parse(theomaphieumuontxtbx.Text) + " ";
            }

            func.getRecord(query, ctphieumuondgv);
        }

        //EVENT METHODS
        private void FrmCTPhieuMuon2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            func.connectDB();
            getCTPhieuMuon();
            func.updateDGVNumber(soluonglb, ctphieumuondgv);
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchCTPhieuMuon();
        }
        
    }
}
