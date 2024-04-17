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
    public partial class FrmThongKePhieuMuon_CTPhieuMuon : Form
    {
        Func func = new Func();

        public FrmThongKePhieuMuon_CTPhieuMuon()
        {
            InitializeComponent();
        }

        //////////////FUNCTION METHODS

        //PHIEU MUON FUNCTIONS
        private void getPhieuMuon()
        {
            phieumuondgv.DataSource = func.getTable("v_PhieuMuon");
        }

        private void blankSearchSection()
        {
            //theongaymuontudtp.CustomFormat = " ";
            //theongaymuondendtp.CustomFormat = " ";
            theongaymuontudtp.Value = DateTime.Today;
            theongaymuondendtp.Value = DateTime.Today;
            tinhtrangcbbx.SelectedIndex = 0;
            tinhtrangckbx.Checked = false;
            theongaymuonckbx.Checked = false;
        }

        private void searchPhieuMuon()
        {
            string query = @"select iMaPM as [Mã PM], sTenDocGia as [Độc giả], sHoTen as [Nhân viên tạo] ,dNgayMuon as [Ngày mượn], 
                            dNgayhenTra as [Ngày hẹn trả], fTienCoc as [Tiền cọc], bTinhTrang as [Tình trạng]
                            from PhieuMuon, TheTV, NhanVien
                            where PhieuMuon.iMaTheTV=TheTV.iMaTheTV and PhieuMuon.iMaNV = NhanVien.iMaNV AND 1 = 1 ";

            if (tinhtrangckbx.Checked == true)
            {
                if (tinhtrangcbbx.SelectedIndex == 0) { query += "AND PhieuMuon.bTinhTrang = " + 0 + " "; }
                else if(tinhtrangcbbx.SelectedIndex == 1) { query += "AND PhieuMuon.bTinhTrang = " + 1 + " "; }
                else if(tinhtrangcbbx.SelectedIndex == 2) { query += "AND PhieuMuon.bTinhTrang = " + 0 + " AND PhieuMuon.dNgayHenTra < GETDATE() "; }
                MessageBox.Show(query);
            }
            if (theongaymuonckbx.Checked)
            {
                query += "AND (dNgayMuon BETWEEN '" + theongaymuontudtp.Value.ToString("yyyy/MM/dd") + "' AND '" + theongaymuondendtp.Value.ToString("yyyy/MM/dd") + "') ";
            }

            func.getRecord(query, phieumuondgv);
        }

        private void firstSetUp()
        {
            //Phieu Muon
            tinhtrangcbbx.Items.Add("Chưa trả");
            tinhtrangcbbx.Items.Add("Đã trả");
            tinhtrangcbbx.Items.Add("Trả muộn");
            tinhtrangcbbx.SelectedIndex = 0;
            //this.Controls.Add(tinhtrangcbbx);
            soluonglb.Text = phieumuondgv.RowCount.ToString();

            //CT Phieu Muon
            ctpmtinhtrangcbbx.Items.Add("Sách nguyên vẹn");
            ctpmtinhtrangcbbx.Items.Add("Làm hỏng sách");
            ctpmtinhtrangcbbx.SelectedIndex = 0;
            ctpmsoluonglb.Text = ctphieumuondgv.RowCount.ToString();

        }


        //CT Phieu Muon FUNCTIONS
        private void getCTPhieuMuon()
        {
            ctphieumuondgv.DataSource = func.getTable("v_CTPhieuMuon");
        }

        private void blankCTPMSearchSection()
        {
            ctpmtinhtrangcbbx.SelectedIndex = 0;
            ctpmtinhtrangckbx.Checked = false;
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
			                             WHEN iTinhTrang = 3 THEN N'Làm mất'
			                             WHEN iTinhTrang = 1 THEN N'Đã trả/Nguyên vẹn'
			                             WHEN iTinhTrang = 2 THEN N'Đã trả/Không nguyên vẹn'
			                             ELSE 'Unknown'
		                            END AS [Tình trạng], 
		                            sChiTietTinhTrangSau as [CTTT sau], 
		                            fTienPhat as [Tiền phạt]
                            from CTPhieuMuon, Sach, PhieuMuon
                            where CTPhieuMuon.iMaSach = Sach.iMaSach AND
                                  CTPhieuMuon.iMaPM = PhieuMuon.iMaPM AND 1 = 1 ";

            if (ctpmtinhtrangckbx.Checked)
            {
                if(ctpmtinhtrangcbbx.SelectedIndex == 0) { query += "AND CTPhieuMuon.iTinhTrang = " + 1 + " "; }
                else if(ctpmtinhtrangcbbx.SelectedIndex == 1) { query += "AND CTPhieuMuon.iTinhTrang = " + 2 + " "; }
            }

            func.getRecord(query, ctphieumuondgv);
            func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
        }




        /*        //CT PHIEU MUON FUNCTION
                private void getCTPhieuMuon()
                {
                    ctphieumuondgv.DataSource = func.getTable("v_CTPhieuMuon");
                }

                private void blankCTPMSearchSection()
                {
                    ctpmtheomathetvtxtbx.Text = "";
                    ctpmtheotensachtxtbx.Text = "";
                    ctpmtheomaphieumuontxtbx.Text = "";
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
                                                 WHEN iTinhTrang = 3 THEN N'Làm mất'
                                                 WHEN iTinhTrang = 1 THEN N'Đã trả/Nguyên vẹn'
                                                 WHEN iTinhTrang = 2 THEN N'Đã trả/Không nguyên vẹn'
                                                 ELSE 'Unknown'
                                            END AS [Tình trạng], 
                                            sChiTietTinhTrangSau as [CTTT sau], 
                                            fTienPhat as [Tiền phạt]
                                    from CTPhieuMuon, Sach, PhieuMuon
                                    where CTPhieuMuon.iMaSach = Sach.iMaSach AND
                                          CTPhieuMuon.iMaPM = PhieuMuon.iMaPM AND 1 = 1 ";

                    if (ctpmtheomathetvckbx.Checked && ctpmtheomathetvtxtbx.Text != "")
                    {
                        query += "AND PhieuMuon.iMaTheTV = " + int.Parse(ctpmtheomathetvtxtbx.Text) + " ";
                    }
                    if (ctpmtheotensachckbx.Checked && ctpmtheotensachtxtbx.Text != "")
                    {
                        query += "AND Sach.sTenSach LIKE N'%" + ctpmtheotensachtxtbx.Text + "%' ";
                    }
                    if (ctpmtheomaphieumuonckbx.Checked && ctpmtheomaphieumuontxtbx.Text != "")
                    {
                        query += "AND CTPhieuMuon.iMaPM = " + int.Parse(ctpmtheomaphieumuontxtbx.Text) + " ";
                    }

                    func.getRecord(query, ctphieumuondgv);
                }



        */
        //////////////////EVENT METHODS


        private void FrmThongKePhieuMuon_CTPhieuMuon_Load(object sender, EventArgs e)
        {
            func.connectDB();
            firstSetUp();

            //load Phieu Muon
            getPhieuMuon();
            //func.updateDGVNumber(soluonglb, phieumuondgv);



            //load CT Phieu Muon
            getCTPhieuMuon();
        }

        //Phieu Muon EVENTS
        private void thongkebttn_Click(object sender, EventArgs e)
        {
            searchPhieuMuon();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        //CT Phieu Muon EVENTS
        private void ctpmhuytkbttn_Click(object sender, EventArgs e)
        {
            blankCTPMSearchSection();
        }

        private void ctpmthongkebttn_Click(object sender, EventArgs e)
        {
            searchCTPhieuMuon();
        }
    }
}
