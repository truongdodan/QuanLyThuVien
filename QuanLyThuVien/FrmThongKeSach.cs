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
    public partial class FrmThongKeSach : Form
    {
        Func func = new Func();

        public FrmThongKeSach()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getSach()
        {
            dgvSach.DataSource = func.getTable("v_Sach");
        }

        private void searchSach()
        {
            string query = @"SELECT Sach.iMaSach as [Mã sách], sTenSach as [Tên sách], sTacGia as [Tác giả], iSL as [SL], fGiaSach as [Giá], iNamXB as [Năm XB], sTenNXB as [Tên NXB], sTenTL as [Tên TL]
                            from Sach 
                            LEFT JOIN NhaXuatBan ON Sach.iMaNXB = NhaXuatBan.iMaNXB
                            LEFT JOIN TheLoai ON Sach.iMaTL = TheLoai.iMaTL
                            LEFT JOIN CTPhieuMuon ON Sach.iMaSach = CTPhieuMuon.iMaSach
                            LEFT JOIN PhieuMuon ON CTPhieuMuon.iMaPM = PhieuMuon.iMaPM
                            where Sach.iMaNXB=NhaXuatBan.iMaNXB and Sach.iMaTL=TheLoai.iMaTL AND 1 = 1 ";

            if (tinhtrangckbx.Checked)
            {
                if(tinhtrangcbbx.SelectedIndex == 0) { query += "AND CTPhieuMuon.iMaPM IS NOT NULL "; }
                else if(tinhtrangcbbx.SelectedIndex == 1) { query += "AND CTPhieuMuon.iMaPM IS NOT NULL AND PhieuMuon.dNgayHenTra < GETDATE() "; }
            }

            func.getRecord(query, dgvSach);
            func.updateDGVNumber(soluonglb, dgvSach);

        }

        private void blankSearch()
        {
            tinhtrangcbbx.SelectedIndex = 0;
            tinhtrangckbx.Checked = false;
        }

        private void firstSetUp()
        {
            tinhtrangcbbx.Items.Add("Sách đang mượn");
            tinhtrangcbbx.Items.Add("Sách trả muộn");
            tinhtrangcbbx.SelectedIndex = 0;
        }


        //EVENT METHODS
        private void FrmThongKeSach_Load(object sender, EventArgs e)
        {
            func.connectDB();
            getSach();
            func.updateDGVNumber(soluonglb, dgvSach);
            firstSetUp();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearch();
        }

        private void thongkebttn_Click(object sender, EventArgs e)
        {
            searchSach();
        }
    }
}
