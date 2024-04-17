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
    public partial class FrmTheTV : Form
    {
        Func func = new Func();

        public FrmTheTV()
        {
            InitializeComponent();
        }

        //////////////////////FUNCTION METHODS
        private void getTheTV()
        {
            thetvdgv.DataSource = func.getTable("v_TheTV");
        }
        private void blankSearchSection()
        {
            theotentxtbx.Text = "";
            theongaycaptudtp.Value = DateTime.Today;
            theongaycapdendtp.Value = DateTime.Today;
            theongayhethantudtp.Value = DateTime.Today;
            theongayhethandendtp.Value = DateTime.Today;
        }

        private void searchTheTV()
        {
            string query = @"select iMaTheTV as [Mã thẻ], sTenDocGia as [Tên độc giả], dNgaySinh as [Ngày sinh], sDonVi as [Đơn vị], sSDT as[SĐT], dNgayCap as [Ngày cấp], dNgayHetHan as [Ngày hết hạn]
                            from TheTV WHERE 1 = 1 ";

            if(theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sTenDocGia LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if(theongaycapckbx.Checked)
            {
                query += "AND (dNgayCap BETWEEN '" + theongaycaptudtp.Value.ToString("yyyy/MM/dd") + "' AND '" + theongaycapdendtp.Value.ToString("yyyy/MM/dd") + "') ";
            }
            if(theongayhethanckbx.Checked)
            {
                query += "AND (dNgayHetHan BETWEEN '" + theongayhethantudtp.Value.ToString("yyyy/MM/dd") + "' AND '" + theongayhethandendtp.Value.ToString("yyyy/MM/dd") + "') ";
            }

            func.getRecord(query, thetvdgv);
            func.updateDGVNumber(soluonglb, thetvdgv);
        }

        private void firstSetUp()
        {
            ngayhethandtp.Value = ngaycapdtp.Value.AddMonths(1);
            ngaysinhdtp.CustomFormat = " ";
        }

        private void blankUpdateSection()
        {
            mathetxtbx.Text = "";
            tendocgiatxtbx.Text = "";
            ngaysinhdtp.CustomFormat = " ";
            donvitxtbx.Text = "";
            sdttxtbx.Text = "";
            ngaycapdtp.Value = DateTime.Today;
            ngayhethandtp.Value = ngaycapdtp.Value.AddMonths(1);
            mathetxtbx.Enabled = true;
            func.er.Clear();
            thembttn.Enabled = true;
            capnhatbttn.Enabled = true;
        }

        private void addRecord()
        {
            if(mathetxtbx.Text == "" || tendocgiatxtbx.Text == "" || donvitxtbx.Text == "" || sdttxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(mathetxtbx.Text), "TheTV", "iMaTheTV"))
                {
                    MessageBox.Show("Đã tồn tại thành viên có mã này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = $"INSERT INTO TheTV VALUES({int.Parse(mathetxtbx.Text)}, N'{tendocgiatxtbx.Text}', '{ngaysinhdtp.Value}', N'{donvitxtbx.Text}', '{sdttxtbx.Text}', '{ngaycapdtp.Value}', '{ngayhethandtp.Value}')";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(thetvdgv, "v_TheTV");
                        func.updateDGVNumber(soluonglb, thetvdgv);

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void updateRecord()
        {
            if (mathetxtbx.Text == "" || tendocgiatxtbx.Text == "" || donvitxtbx.Text == "" || sdttxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"UPDATE TheTV SET sTenDocGia = N'{tendocgiatxtbx.Text}', dNgaySinh = '{ngaysinhdtp.Value}', sDonVi = N'{donvitxtbx.Text}', sSDT = '{sdttxtbx.Text}', dNgayCap = '{ngaycapdtp.Value}', dNgayHetHan = '{ngayhethandtp.Value}' WHERE iMaTheTV = {int.Parse(mathetxtbx.Text)}";

                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchTheTV();
                    //func.updateDGV(thetvdgv, "v_TheTV");
                    func.updateDGVNumber(soluonglb, thetvdgv);

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRecord()
        {
            if(mathetxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã thẻ", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if(!func.isRecordExist(int.Parse(mathetxtbx.Text), "TheTV", "iMaTheTV")) 
                {
                    MessageBox.Show("Thẻ không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(func.isRecordExist(int.Parse(mathetxtbx.Text), "PhieuMuon", "iMaTheTV"))
                    {
                        MessageBox.Show("Không thể xóa do thẻ liên kết với những thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = $"DELETE FROM TheTV WHERE iMaTheTV = {int.Parse(mathetxtbx.Text)}";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            func.updateDGV(thetvdgv, "v_TheTV");
                            func.updateDGVNumber(soluonglb, thetvdgv);

                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



        ///////////////////EVENT METHODS
        private void FrmTheTV_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            func.connectDB();
            getTheTV();
            func.updateDGVNumber(soluonglb, thetvdgv);
            firstSetUp();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchTheTV();
        }

        private void ngaysinhdtp_ValueChanged(object sender, EventArgs e)
        {
            ngaysinhdtp.CustomFormat = "MM/dd/yyyy";
        }

        private void ngaycapdtp_ValueChanged(object sender, EventArgs e)
        {
            ngayhethandtp.Value = ngaycapdtp.Value.AddMonths(1);
        }

        private void huycnbttn_Click(object sender, EventArgs e)
        {
            blankUpdateSection();
        }

        private void thembttn_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void mathetxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(mathetxtbx) || !func.isNumber(mathetxtbx))
            {
                if (mathetxtbx.Enabled == true)
                {
                    thembttn.Enabled = false;
                }
                else { capnhatbttn .Enabled = false; }
            }
            else
            {
                if (mathetxtbx.Enabled == true)
                {
                    thembttn.Enabled = true;
                }
                else { capnhatbttn.Enabled = true; }
            }

            
        }

        private void thetvdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                mathetxtbx.Enabled = false;
                mathetxtbx.Text = thetvdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tendocgiatxtbx.Text = thetvdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                ngaysinhdtp.Text = thetvdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                donvitxtbx.Text = thetvdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                sdttxtbx.Text = thetvdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                ngaycapdtp.Text = thetvdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                ngayhethandtp.Text = thetvdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            } catch { }
        }

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removeRecord();
        }

        private void giahanbttn_Click(object sender, EventArgs e)
        {
            ngayhethandtp.Value = ngayhethandtp.Value.AddMonths(1);
        }
    }
}
