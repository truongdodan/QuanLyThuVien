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
    public partial class FrmPhieuMuon : Form
    {
        Func func = new Func();

        public FrmPhieuMuon()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getPhieuMuon()
        {
            phieumuondgv.DataSource = func.getTable("v_PhieuMuon");
        }

        private void blankSearchSection()
        {
            theomatxtbx.Text = "";
            theotentxtbx.Text = "";
            theongaymuontudtp.Value = DateTime.Today;
            theongaymuondendtp.Value = DateTime.Today;
        }

        private void searchPhieuMuon()
        {
            string query = @"select iMaPM as [Mã PM], PhieuMuon.iMaTheTV as [Mã thẻ TV], sTenDocGia as [Độc giả], PhieuMuon.iMaNV as [Mã NV], sHoTen as [Nhân viên] ,dNgayMuon as [Ngày mượn], 
                            dNgayhenTra as [Ngày hẹn trả], fTienCoc as [Tiền cọc], bTinhTrang as [Tình trạng]
                            from PhieuMuon, TheTV, NhanVien
                            where PhieuMuon.iMaTheTV=TheTV.iMaTheTV and PhieuMuon.iMaNV = NhanVien.iMaNV AND 1 = 1 ";

            if(theomathetvckbx.Checked && theomatxtbx.Text != "")
            {
                query += "AND PhieuMuon.iMaTheTV = " + int.Parse(theomatxtbx.Text) + " ";
            }
            if(theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sTenDocGia LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if(theongaymuonckbx.Checked)
            {
                query += "AND (dNgayMuon BETWEEN '" + theongaymuontudtp.Value.ToString("yyyy/MM/dd") + "' AND '" + theongaymuondendtp.Value.ToString("yyyy/MM/dd") + "') ";
            }

            func.getRecord(query, phieumuondgv);
        }

        //EVENT METHODS

        private void FrmPhieuMuon_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            func.connectDB();
            getPhieuMuon();
            func.updateDGVNumber(soluonglb, phieumuondgv);
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchPhieuMuon();
        }
    }
}
