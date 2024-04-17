using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmQuanLyMuonTra : Form
    {
        Func func = new Func();
        private int manv;
        public FrmQuanLyMuonTra()
        {
            InitializeComponent();
        }

        public void setManv(int manv) { this.manv = manv; }

        public int getManv(int manv) { return this.manv; }

        /////////////////////////////////////FUNCTION METHODS
        
        //CT Phieu Muon FUNCTIONS
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
            func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
        }

        private void blankCTPMUpdateSection()
        {
            ctpmmaphieumuontxtbx.Text = "";
            ctpmtensachcbbx.SelectedIndex = -1;
            tenthanhviencbbx.SelectedIndex = -1;
            nguyenvenrabttn.Checked = true;
            ctpmngaytradtp.CustomFormat = " ";
            ctpmchuatrarabttn.Checked = true;
            ctpmtienphattxtbx.Text = "";
            chitietknvbandautxtbx.Text = "Chi tiết không nguyên vẹn...";
            chitietknvtttxtbx.Text = "Chi tiết không nguyên vẹn...";
            func.er.Clear();
            ctpmthembttn.Enabled = true;
            ctpmcapnhatbttn.Enabled = true;
            ctpmmaphieumuontxtbx.Enabled = true;
            ctpmtensachcbbx.Enabled = true;
            ctpmngayrongckbx.Checked = true;
        }

        private void fillComboboxCTPM()
        {
            //Ten sach combobox
            DataTable sach = func.getTable("Sach");
            ctpmtensachcbbx.DataSource = sach;
            ctpmtensachcbbx.DisplayMember = "sTenSach";
            ctpmtensachcbbx.ValueMember = "iMaSach";
            ctpmtensachcbbx.SelectedIndex = -1;
        }

        private void removeCTPhieuMuon()
        {
            if (ctpmmaphieumuontxtbx.Text == "" || ctpmtensachcbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền mã phiếu mượn và tên sách", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!func.isRecordExist(int.Parse(ctpmmaphieumuontxtbx.Text), "PhieuMuon", "iMaPM") || !func.isItExistInThisRecord((int) ctpmtensachcbbx.SelectedValue, "iMaSach", "CTPhieuMuon", "iMaPM", int.Parse(ctpmmaphieumuontxtbx.Text)))
                {
                    MessageBox.Show("Phiếu mượn không tồn tại hoặc trong phiếu mượn không có sách đã chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string query = @"DELETE FROM CTPhieuMuon WHERE iMaPM = " + int.Parse(ctpmmaphieumuontxtbx.Text) + " AND " + "iMaSach = " + (int)ctpmtensachcbbx.SelectedValue;
                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(ctphieumuondgv, "v_CTPhieuMuon");
                        func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
                    }
                    else { MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void addCTPhieuMuon()
        {
            if (ctpmmaphieumuontxtbx.Text == "" || ctpmtensachcbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các ô thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(!func.isRecordExist(int.Parse(ctpmmaphieumuontxtbx.Text), "PhieuMuon", "iMaPM") || func.isItExistInThisRecord((int)ctpmtensachcbbx.SelectedValue, "iMaSach", "CTPhieuMuon", "iMaPM", int.Parse(ctpmmaphieumuontxtbx.Text)) )
                {
                    MessageBox.Show("Không thể thêm do phiếu mượn không tồn tại hoặc sách này đã được thêm trong phiếu mượn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int tinhtrangbandau = 1;
                    int tinhtrang = 0;
                    string ngaytra = "";
                    string ctknvbandau = "";
                    string ctknvtt = "";
                    float tienphat = 0;

                    if(khongnguyenvenrabttn.Checked) { tinhtrangbandau = 0; }

                    if(ctpmchuatrarabttn.Checked) { tinhtrang = 0; }
                    else if(matsachrabttn.Checked) { tinhtrang = 3; }
                    else if(datranvrabttn.Checked) { tinhtrang = 1; }
                    else if(datraknvrabttn.Checked) { tinhtrang = 2; }    

                    if(khongnguyenvenrabttn.Checked) { ctknvbandau = chitietknvbandautxtbx.Text; }

                    if(datraknvrabttn.Checked) { ctknvtt = chitietknvtttxtbx.Text; }

                    if(ctpmtienphattxtbx.Text != "")
                    {
                        tienphat += float.Parse(ctpmtienphattxtbx.Text);
                    }

                    string query = "";


                    if (ctpmngaytradtp.CustomFormat != " ")
                    {
                        ngaytra = ctpmngaytradtp.Value.ToString("MM/dd/yyyy");
                        query += $"INSERT INTO CTPhieuMuon VALUES ({int.Parse(ctpmmaphieumuontxtbx.Text)}, {ctpmtensachcbbx.SelectedValue}, {tinhtrangbandau}, N'{ctknvbandau}', '{ngaytra}', {tinhtrang}, N'{ctknvtt}', {tienphat})";
                    }
                    else
                    {
                        ngaytra = "NULL";
                        query += $"INSERT INTO CTPhieuMuon VALUES ({int.Parse(ctpmmaphieumuontxtbx.Text)}, {ctpmtensachcbbx.SelectedValue}, {tinhtrangbandau}, N'{ctknvbandau}', {ngaytra}, {tinhtrang}, N'{ctknvtt}', {tienphat})";

                    }

                    //string query = "INSERT INTO CTPhieuMuon VALUES (" + int.Parse(ctpmmaphieumuontxtbx.Text) + ", " + ctpmtensachcbbx.SelectedValue + ", " + tinhtrangbandau + ", N'" + ctknvbandau + "', '" + ngaytra + "', " + tinhtrang + ", N'" + ctknvtt + "', " + float.Parse(ctpmtienphattxtbx.Text) + ")";
                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchCTPhieuMuon();
                        //func.updateDGV(ctphieumuondgv, "v_CTPhieuMuon");
                        func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void updateCTPhieuMuon()
        {
            if (ctpmmaphieumuontxtbx.Text == "" || ctpmtensachcbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các ô thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tinhtrangbandau = 1;
                int tinhtrang = 0;
                string ngaytra = "";
                string ctknvbandau = "";
                string ctknvtt = "";
                float tienphat = 0;

                ///ctpmngaytradtp.CustomFormat = " ";
                if (khongnguyenvenrabttn.Checked) { tinhtrangbandau = 0; }

                if (ctpmchuatrarabttn.Checked) { tinhtrang = 0; }
                else if (matsachrabttn.Checked) { tinhtrang = 3; }
                else if (datranvrabttn.Checked) { tinhtrang = 1; }
                else if (datraknvrabttn.Checked) { tinhtrang = 2; }

                if (khongnguyenvenrabttn.Checked) { ctknvbandau = chitietknvbandautxtbx.Text; }

                if (datraknvrabttn.Checked) { ctknvtt = chitietknvtttxtbx.Text; }

                if (ctpmtienphattxtbx.Text != "")
                {
                    tienphat += float.Parse(ctpmtienphattxtbx.Text);
                }

                string query = "";


                if (ctpmngaytradtp.CustomFormat != " ")
                {
                    ngaytra = ctpmngaytradtp.Value.ToString("MM/dd/yyyy");
                    query += $"UPDATE CTPhieuMuon SET iTinhTrangSachBanDau = {tinhtrangbandau}, sChiTietTinhTrangBanDau = N'{ctknvbandau}', dNgayTra = '{ngaytra}', iTinhTrang = {tinhtrang}, sChiTietTinhTrangSau = N'{ctknvtt}', fTienPhat = {tienphat} WHERE iMaPM = {int.Parse(ctpmmaphieumuontxtbx.Text)} AND iMaSach = {ctpmtensachcbbx.SelectedValue}";
                }
                else
                {
                    ngaytra = "NULL";
                    query += $"UPDATE CTPhieuMuon SET iTinhTrangSachBanDau = {tinhtrangbandau}, sChiTietTinhTrangBanDau = N'{ctknvbandau}', dNgayTra = {ngaytra}, iTinhTrang = {tinhtrang}, sChiTietTinhTrangSau = N'{ctknvtt}', fTienPhat = {tienphat} WHERE iMaPM = {int.Parse(ctpmmaphieumuontxtbx.Text)} AND iMaSach = {ctpmtensachcbbx.SelectedValue}";
                }

                //string query = "INSERT INTO CTPhieuMuon VALUES (" + int.Parse(ctpmmaphieumuontxtbx.Text) + ", " + ctpmtensachcbbx.SelectedValue + ", " + tinhtrangbandau + ", N'" + ctknvbandau + "', '" + ngaytra + "', " + tinhtrang + ", N'" + ctknvtt + "', " + float.Parse(ctpmtienphattxtbx.Text) + ")";
                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchCTPhieuMuon();
                    //func.updateDGV(ctphieumuondgv, "v_CTPhieuMuon");
                    func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //FUNCTION Phieu Muon
        private void getPhieuMuon()
        {
            phieumuondgv.DataSource = func.getTable("v_PhieuMuon");
        }

        private void blankSearchSection()
        {
            theomatxtbx.Text = "";
            theotentxtbx.Text = "";
            theongaymuontudtp.CustomFormat = " ";
            theongaymuondendtp.CustomFormat = " ";
            timbttn.Enabled = true;
            func.er.Clear();
        }

        private void searchPhieuMuon()
        {
            string query = @"select iMaPM as [Mã PM], sTenDocGia as [Độc giả], sHoTen as [Nhân viên tạo] ,dNgayMuon as [Ngày mượn], 
                            dNgayhenTra as [Ngày hẹn trả], fTienCoc as [Tiền cọc], bTinhTrang as [Tình trạng]
                            from PhieuMuon, TheTV, NhanVien
                            where PhieuMuon.iMaTheTV=TheTV.iMaTheTV and PhieuMuon.iMaNV = NhanVien.iMaNV AND 1 = 1 ";

            if (theomathetvckbx.Checked && theomatxtbx.Text != "")
            {
                query += "AND PhieuMuon.iMaTheTV = " + int.Parse(theomatxtbx.Text) + " ";
            }
            if (theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sTenDocGia LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if (theongaymuonckbx.Checked)
            {
                query += "AND (dNgayMuon BETWEEN '" + theongaymuontudtp.Value.ToString("yyyy/MM/dd") + "' AND '" + theongaymuondendtp.Value.ToString("yyyy/MM/dd") + "') ";
            }

            func.getRecord(query, phieumuondgv);
        }

        private void fillPhieuMuonCombobox()
        {
            //fill nguoi lap combobox;
            DataTable nguoilap = func.getTable("NhanVien");
            nguoilapcbbx.DataSource = nguoilap;
            nguoilapcbbx.DisplayMember = "iMaNV";
            nguoilapcbbx.ValueMember = "sHoTen";
            nguoilapcbbx.SelectedValue = this.manv;

            //fill ma the tv
            DataTable mathetv = func.getTable("TheTV");
            mathetvcbbx.DataSource = mathetv;
            mathetvcbbx.DisplayMember = "iMaTheTV";
            mathetvcbbx.ValueMember = "iMaTheTV";
            mathetvcbbx.SelectedIndex = -1;

            //fill ten thanh vien
            tenthanhviencbbx.DataSource = mathetv;
            tenthanhviencbbx.DisplayMember = "sTenDocGia";
            tenthanhviencbbx.ValueMember = "sTenDocGia";
            tenthanhviencbbx.SelectedIndex = -1;
        }

        private void firstSetUp()
        {
            theongaymuontudtp.CustomFormat = " ";
            theongaymuondendtp.CustomFormat = " ";
            ngayhentradtp.Value = DateTime.Today.AddDays(7);
            nguoilaptxtbx.Text = func.getTenNV(manv);            
        }

        private void blankUpDateField()
        {
            maphieumuontxtbx.Text = "";
            mathetvcbbx.SelectedIndex = -1;
            tenthanhviencbbx.SelectedIndex = -1;
            ngaymuondtp.Value = DateTime.Today;
            ngayhentradtp.Value = DateTime.Today.AddDays(7);
            tiencoctxtbx.Text = "";
            chuatrarabttn.Checked = true;
            func.er.Clear();
            thembttn.Enabled = true;
            capnhatbttn.Enabled = true;
            nguoilaptxtbx.Text = func.getTenNV(manv);
            maphieumuontxtbx.Enabled = true;
            datrarabttn.Enabled = false;
            chuatrarabttn.Enabled = false;
            inbttn.Enabled = true;
        }

        private void addPhieuMuon()
        {
            if(mathetvcbbx.SelectedIndex == -1 || tenthanhviencbbx.SelectedIndex == -1 || maphieumuontxtbx.Text == "" || tiencoctxtbx.Text == "") 
            {
                MessageBox.Show("Vui lòng điền đầy đủ các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
               if(func.isRecordExist(int.Parse(maphieumuontxtbx.Text), "PhieuMuon", "iMaPM"))
                {
                    MessageBox.Show("Phiếu mượn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               else
                {
                    int tinhtrang = 0;

                    if(datrarabttn.Checked) { tinhtrang = 1;}
                    else { tinhtrang = 0;}

                    string query = $"INSERT INTO PhieuMuon VALUES({int.Parse(maphieumuontxtbx.Text)}, {mathetvcbbx.SelectedValue}, {manv}, '{ngaymuondtp.Value}', '{ngayhentradtp.Value}', {float.Parse(tiencoctxtbx.Text)}, {tinhtrang})";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(phieumuondgv, "v_PhieuMuon");
                        //func.updateDGVNumber(soluonglb, phieumuondgv);
                        int num = phieumuondgv.Rows.Count;
                        soluonglb.Text = num.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void removePhieuMuon()
        {
            if(func.isNull(maphieumuontxtbx) || !func.isNumber(maphieumuontxtbx))
            {
                MessageBox.Show("Vui lòng điền mã phiếu mượn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(maphieumuontxtbx.Text), "PhieuMuon", "iMaPM"))
                {
                    if(func.isRecordExist(int.Parse(maphieumuontxtbx.Text), "CTPhieuMuon", "iMaPM"))
                    {
                        MessageBox.Show("Không thể xóa do phiếu mượn có liên kết đến những thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string query = $"DELETE FROM PhieuMuon WHERE iMaPM = {int.Parse(maphieumuontxtbx.Text)}";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            func.updateDGV(phieumuondgv, "v_PhieuMuon");
                            int num = phieumuondgv.Rows.Count;
                            soluonglb.Text = num.ToString();
                            //func.updateDGVNumber(soluonglb, phieumuondgv);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu mượn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void updatePhieuMuon()
        {
            if (mathetvcbbx.SelectedIndex == -1 || tiencoctxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tinhtrang = 0;

                if (datrarabttn.Checked) { tinhtrang = 1; }
                else { tinhtrang = 0; }

                string query = $"UPDATE PhieuMuon SET iMaTheTV = {mathetvcbbx.SelectedValue}, dNgayMuon = '{ngaymuondtp.Value}', dNgayHenTra = '{ngayhentradtp.Value}', fTienCoc = {float.Parse(tiencoctxtbx.Text)}, bTinhTrang = {tinhtrang} WHERE iMaPM = {int.Parse(maphieumuontxtbx.Text)}";

                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchPhieuMuon();
                    //func.updateDGV(phieumuondgv, "v_PhieuMuon");
                    func.updateDGVNumber(soluonglb, phieumuondgv);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void giahanthemPhieuMuon()
        {
            if(maphieumuontxtbx.Text != "")
            {
                if (ngaymuondtp.Value.AddDays(21) <= ngayhentradtp.Value)
                {
                    MessageBox.Show("Chỉ được phép gian thêm tối đa 2 lần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    ngayhentradtp.Value = ngayhentradtp.Value.AddDays(7);
                }
            }
        }




        ///////////////////////////////////EVENT METHODS
        private void FrmQuanLyMuonTra_Load(object sender, EventArgs e)
        {
            func.connectDB();

            //Chi tiet phieu muon load event
            this.ActiveControl = label1;
            getCTPhieuMuon();
            func.updateDGVNumber(ctpmsoluonglb, ctphieumuondgv);
            fillComboboxCTPM();

            //Phieu muon load event
            getPhieuMuon();
            //func.updateDGVNumber(soluonglb, phieumuondgv);
            int num = phieumuondgv.Rows.Count;
            soluonglb.Text = num.ToString();
            fillPhieuMuonCombobox();
            firstSetUp();
        }


        //CTPM METHODS
        private void ctpmhuytkbttn_Click(object sender, EventArgs e)
        {
            blankCTPMSearchSection();
        }

        private void ctpmhuycnbttn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            blankCTPMUpdateSection();
        }

        private void ctpmtimbttn_Click(object sender, EventArgs e)
        {
            searchCTPhieuMuon();
        }

        private void ctpmxoabttn_Click(object sender, EventArgs e)
        {
            removeCTPhieuMuon();
        }

        private void ctpmthembttn_Click(object sender, EventArgs e)
        {
            addCTPhieuMuon();
        }

        private void ctpmngaytradtp_Enter(object sender, EventArgs e)
        {
            ctpmngaytradtp.CustomFormat = "MM/dd/yyyy";
        }

        private void ctpmmaphieumuontxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(ctpmmaphieumuontxtbx) || !func.isNumber(ctpmmaphieumuontxtbx))
            {
                ctpmthembttn.Enabled = false;
            }
            else
            {
                ctpmthembttn.Enabled = true;
            }
        }

        private void nguyenvenrabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvbandautxtbx.Enabled = false;
            chitietknvbandautxtbx.Text = "Chi tiết không nguyên vẹn...";
        }

        private void khongnguyenvenrabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvbandautxtbx.Enabled = true;
            chitietknvbandautxtbx.Text = "";
        }

        private void datraknvrabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvtttxtbx.Enabled = true;
            chitietknvtttxtbx.Text = "";
        }

        private void ctpmchuatrarabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvtttxtbx.Enabled = false;
            chitietknvtttxtbx.Text = "Chi tiết không nguyên vẹn...";
        }

        private void matsachrabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvtttxtbx.Enabled = false;
            chitietknvtttxtbx.Text = "Chi tiết không nguyên vẹn...";
        }

        private void datranvrabttn_CheckedChanged(object sender, EventArgs e)
        {
            chitietknvtttxtbx.Enabled = false;
            chitietknvtttxtbx.Text = "Chi tiết không nguyên vẹn...";
        }

        private void ctphieumuondgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ctpmmaphieumuontxtbx.Enabled = false;
                ctpmtensachcbbx.Enabled = false;

                ctpmmaphieumuontxtbx.Text = ctphieumuondgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                ctpmtensachcbbx.SelectedIndex = ctpmtensachcbbx.FindString(ctphieumuondgv.Rows[e.RowIndex].Cells[1].Value.ToString());

                if (ctphieumuondgv.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nguyên vẹn") { nguyenvenrabttn.Checked = true; }
                else { khongnguyenvenrabttn.Checked = true; }

                if (khongnguyenvenrabttn.Checked == true) { chitietknvbandautxtbx.Text = ctphieumuondgv.Rows[e.RowIndex].Cells[3].Value.ToString(); }

                /*if(ctphieumuondgv.Rows[e.RowIndex].Cells[4].Value.ToString() != "NULL") { ctpmngaytradtp.Value = DateTime.Parse(ctphieumuondgv.Rows[e.RowIndex].Cells[4].Value.ToString()); }
                else
                {
                    ctpmngaytradtp.Value = DateTime.Parse("1/1/2024");
                    ctpmngaytradtp.CustomFormat = " ";
                }*/
                if(ctphieumuondgv.Rows[e.RowIndex].Cells[4].Value is DateTime) 
                {
                    ctpmngaytradtp.CustomFormat = "MM/dd/yyyy";
                    ctpmngaytradtp.Text = ctphieumuondgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    ctpmngaytradtp.CustomFormat = " ";
                }

                //MessageBox.Show(ctphieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString());
                if (String.Equals(ctphieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString(), "Chưa trả")) { ctpmchuatrarabttn.Checked = true; }
                else if (String.Equals(ctphieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString(), "Mất sách")) { matsachrabttn.Checked = true; }
                else if (String.Equals(ctphieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString(), "Đã trả/Nguyên vẹn")) { datranvrabttn.Checked = true; }
                else if (String.Equals(ctphieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString(), "Đã trả/Không nguyên vẹn")) { datraknvrabttn.Checked = true; }

                if (datraknvrabttn.Checked == true) { chitietknvtttxtbx.Text = ctphieumuondgv.Rows[e.RowIndex].Cells[6].Value.ToString(); }

                ctpmtienphattxtbx.Text = ctphieumuondgv.Rows[e.RowIndex].Cells[7].Value.ToString();
            } catch
            {

            }

        }

        private void ctpmtienphattxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(!func.isNumber(ctpmtienphattxtbx) && ctpmmaphieumuontxtbx.Enabled == true)
            {
                ctpmthembttn.Enabled = false;
            }
            else if(!func.isNumber(ctpmtienphattxtbx) && ctpmmaphieumuontxtbx.Enabled == false)
            {
                ctpmcapnhatbttn.Enabled = false;
            }
            else if(func.isNumber(ctpmtienphattxtbx))
            {
                ctpmthembttn.Enabled = true;
                ctpmcapnhatbttn.Enabled = true;
            }
        }

        private void ctpmcapnhatbttn_Click(object sender, EventArgs e)
        {
            updateCTPhieuMuon();
        }

        private void ctpmngayrongckbx_CheckedChanged(object sender, EventArgs e)
        {
            if(ctpmngayrongckbx.Checked == true)
            {
                ctpmngaytradtp.CustomFormat = " ";
            }
            else
            {
                ctpmngaytradtp.CustomFormat = "MM/dd/yyyy";
            }
        }


        //EVENT Phieu Muon
        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchPhieuMuon();
            int num = phieumuondgv.Rows.Count;
            soluonglb.Text = num.ToString();
        }

        private void theongaymuontudtp_ValueChanged(object sender, EventArgs e)
        {
            theongaymuontudtp.CustomFormat = "MM/dd/yyyy";
        }

        private void theongaymuondendtp_ValueChanged(object sender, EventArgs e)
        {
            theongaymuondendtp.CustomFormat = "MM/dd/yyyy";
        }

        private void huycnbttn_Click(object sender, EventArgs e)
        {
            blankUpDateField();
        }

        private void nguoilapcbbx_SelectedValueChanged(object sender, EventArgs e)
        {
            //fill nguoi lap combobox;
            DataTable nguoilap = func.getTable("NhanVien");
            nguoilapcbbx.DataSource = nguoilap;
            nguoilapcbbx.DisplayMember = "sHoTen";
            nguoilapcbbx.ValueMember = "iMaNV";
            nguoilapcbbx.SelectedValue = this.manv;
            nguoilapcbbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void maphieumuontxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(maphieumuontxtbx) || !func.isNumber(maphieumuontxtbx) )
            {
                func.er.SetError(maphieumuontxtbx, "Không được để trống và phải là một số");
                thembttn.Enabled = false;
                inbttn.Enabled = false; 
            }
            else
            {
                func.er.Clear();
                thembttn.Enabled = true;
                inbttn.Enabled = true;
            }
        }

        private void tiencoctxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (func.isNull(tiencoctxtbx) || !func.isNumber(tiencoctxtbx))
            {
                if(maphieumuontxtbx.Enabled == true) { thembttn.Enabled = false; }
                else if(maphieumuontxtbx.Enabled == false) { capnhatbttn.Enabled = false; }
            }
            else
            {
                if (maphieumuontxtbx.Enabled == true) 
                { 
                    thembttn.Enabled = true;
                    func.er.Clear();
                }
                else if (maphieumuontxtbx.Enabled == false) 
                { 
                    capnhatbttn.Enabled = true;
                    func.er.Clear();
                }
                
            }
        }

        private void thembttn_Click(object sender, EventArgs e)
        {
            addPhieuMuon();
        }

        private void phieumuondgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                datrarabttn.Enabled = true;
                chuatrarabttn.Enabled = true;
                maphieumuontxtbx.Enabled = false;
                maphieumuontxtbx.Text = phieumuondgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tenthanhviencbbx.SelectedIndex = tenthanhviencbbx.FindString(phieumuondgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                ngaymuondtp.Text = phieumuondgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                ngayhentradtp.Text = phieumuondgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                tiencoctxtbx.Text = phieumuondgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                if ((bool)phieumuondgv.Rows[e.RowIndex].Cells[6].Value == false) { chuatrarabttn.Checked = true; }
                else { datrarabttn.Checked = true; }
                //MessageBox.Show("'" + phieumuondgv.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                nguoilaptxtbx.Text = phieumuondgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }

        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removePhieuMuon();
        }

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            updatePhieuMuon();
        }

        private void gianhanbttn_Click(object sender, EventArgs e)
        {
            giahanthemPhieuMuon();
        }

        private void theomatxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNumber(theomatxtbx) || func.isNull(theomatxtbx)) {  
                timbttn.Enabled = true;
                func.er.Clear();
            }
            else if(!func.isNumber(theomatxtbx))
            {
                timbttn.Enabled = false;
            }
        }

        private void ngaymuondtp_ValueChanged(object sender, EventArgs e)
        {
            ngayhentradtp.Value = ngaymuondtp.Value.AddDays(7);
        }

        private void inbttn_Click(object sender, EventArgs e)
        {
            ReportDocument phieumuon = new ReportDocument();
            phieumuon.Load(@"D:\HOCTAP\EDP\btl\QuanLyThuVien\QuanLyThuVien\rptPhieuMuon.rpt");

            if(func.isNull(maphieumuontxtbx) || !func.isNumber(maphieumuontxtbx))
            {
                inbttn.Enabled = false ;
            }
            else
            {
                inbttn.Enabled = true;
                phieumuon.SetParameterValue("Mã Phiếu Mượn", maphieumuontxtbx.Text);
                FrmInPhieuMuon inphieumuon = new FrmInPhieuMuon();
                inphieumuon.crystalReportViewer1.ReportSource = phieumuon;
                inphieumuon.crystalReportViewer1.Refresh();
                inphieumuon.ShowDialog();
            }

        }
    }
}
