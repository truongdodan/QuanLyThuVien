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
    public partial class FrmSach2 : Form
    {
        private Func func = new Func();

        public FrmSach2()
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
            string query = @"SELECT iMaSach as [Mã sách], sTenSach as [Tên sách], sTacGia as [Tác giả], iSL as [SL], fGiaSach as [Giá], iNamXB as [Năm XB], sTenNXB as [Tên NXB], sTenTL as [Tên TL]
                             from Sach, NhaXuatBan, TheLoai
                             where Sach.iMaNXB=NhaXuatBan.iMaNXB and Sach.iMaTL=TheLoai.iMaTL AND 1 = 1 ";

            if (theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sTenSach LIKE " + "N'%" + theotentxtbx.Text + "%' ";
            }
            if (theonamXBckbx.Checked && theonamxuatbantxtbx.Text != "")
            {
                query += "AND iNamXB = " + theonamxuatbantxtbx.Text + " ";
            }
            if (theotlckbx.Checked)
            {
                query += "AND Sach.iMaTL = " + (int)theotheloaicbbx.SelectedValue;
            }
            if (theoNXBckbx.Checked)
            {
                query += "AND Sach.iMaNXB = " + (int)theonxbcbbx.SelectedValue;
            }

            func.getRecord(query, dgvSach);

        }

        private void fillComboBox()
        {
            //the loai combobox
            DataTable theloai = func.getTable("TheLoai");

            theotheloaicbbx.DataSource = theloai;
            theotheloaicbbx.DisplayMember = "sTenTL";
            theotheloaicbbx.ValueMember = "iMaTL";
            theotheloaicbbx.SelectedIndex = -1;

            DataTable theloai2 = func.getTable("TheLoai");

            theloaicbbx.DataSource = theloai2;
            theloaicbbx.DisplayMember = "sTenTL";
            theloaicbbx.ValueMember = "iMaTL";
            theloaicbbx.SelectedIndex = -1;

            //theo nxb combobox
            DataTable nxb = func.getTable("NhaXuatBan");

            theonxbcbbx.DataSource = nxb;
            theonxbcbbx.DisplayMember = "sTenNXB";
            theonxbcbbx.ValueMember = "iMaNXB";
            theonxbcbbx.SelectedIndex = -1;

            DataTable nxb2 = func.getTable("NhaXuatBan");

            nhaxuatbancbbx.DataSource = nxb2;
            nhaxuatbancbbx.DisplayMember = "sTenNXB";
            nhaxuatbancbbx.ValueMember = "iMaNXB";
            nhaxuatbancbbx.SelectedIndex = -1;

        }

        private void blankSearch()
        {
            theotentxtbx.Text = "";
            theonamxuatbantxtbx.Text = "";
        }

        private void addRecord()
        {
            if (masachtxtbx.Text == "" || tensachtxtbx.Text == "" || tacgiatxtbx.Text == "" || soluongtxtbx.Text == "" || giasachtxtbx.Text == "" || namxbtxtbx.Text == "" || theloaicbbx.SelectedIndex == -1 || nhaxuatbancbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đủ vào các ô trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(masachtxtbx.Text), "Sach", "iMaSach"))
                {
                    MessageBox.Show("Đã tồn tại bản ghi trùng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tensachtxtbx.Text == "" || tacgiatxtbx.Text == "" || soluongtxtbx.Text == "" || giasachtxtbx.Text == "" || namxbtxtbx.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đủ các ô thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //string query = $"INSERT INTO Sach VALUES ({int.Parse(masachtxtbx.Text)}, '{tensachtxtbx.Text}', '{tacgiatxtbx.Text}', {int.Parse(soluonglb.Text)}, {float.Parse(giasachtxtbx.Text)}, {namxbcbbx.SelectedValue}, {nhaxuatbancbbx.SelectedValue}, {theloaicbbx.SelectedValue})";
                        string query = $"INSERT INTO Sach VALUES ({int.Parse(masachtxtbx.Text)}, N'{tensachtxtbx.Text}', N'{tacgiatxtbx.Text}', {int.Parse(soluongtxtbx.Text)}, {float.Parse(giasachtxtbx.Text)}, {int.Parse(namxbtxtbx.Text)}, '{nhaxuatbancbbx.SelectedValue}', '{theloaicbbx.SelectedValue}')";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            searchSach();
                            //func.updateDGV(dgvSach, "v_Sach");
                            func.updateDGVNumber(soluonglb, dgvSach);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void updatRecord()
        {
            if (masachtxtbx.Text == "" || tensachtxtbx.Text == "" || tacgiatxtbx.Text == "" || soluongtxtbx.Text == "" || giasachtxtbx.Text == "" || namxbtxtbx.Text == "" || theloaicbbx.SelectedIndex == -1 || nhaxuatbancbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đủ vào các ô trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"UPDATE Sach SET sTenSach = N'{tensachtxtbx.Text}', " +
                                $"sTacGia = N'{tacgiatxtbx.Text}', " +
                                $"iSL = {int.Parse(soluongtxtbx.Text)}, " +
                                $"fGiaSach = {float.Parse(giasachtxtbx.Text)}, " +
                                $"iNamXB = {int.Parse(namxbtxtbx.Text)}, " +
                                $"iMaNXB = '{nhaxuatbancbbx.SelectedValue}', " +
                                $"iMaTL = '{theloaicbbx.SelectedValue}' WHERE iMaSach = {masachtxtbx.Text}";
                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchSach();
                    //func.updateDGV(dgvSach, "v_Sach");
                    func.updateDGVNumber(soluonglb, dgvSach);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRecord()
        {
            if (masachtxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã sách", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(masachtxtbx.Text), "CTPhieuMuon", "iMaSach"))
                {
                    MessageBox.Show("Không thể xóa do sách có liên kết tới những thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!func.isRecordExist(int.Parse(masachtxtbx.Text), "Sach", "iMaSach"))
                {
                    MessageBox.Show("Mã sách không tồn tại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string query = $"DELETE FROM Sach WHERE iMaSach = {int.Parse(masachtxtbx.Text)}";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(dgvSach, "v_Sach");
                        func.updateDGVNumber(soluonglb, dgvSach);
                        masachtxtbx.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void blankUpdateField()
        {
            masachtxtbx.Text = "";
            tensachtxtbx.Text = "";
            tacgiatxtbx.Text = "";
            soluongtxtbx.Text = "";
            giasachtxtbx.Text = "";
            namxbtxtbx.Text = "";
            thembttn.Enabled = true;
            capnhatbttn.Enabled = true;
            theloaicbbx.SelectedIndex = -1;
            nhaxuatbancbbx.SelectedIndex = -1;
        }

        private void firstSetup()
        {
            nhaxuatbancbbx.SelectedIndex = -1;
            theloaicbbx.SelectedIndex = -1;
            namxbtxtbx.Text = DateTime.Today.Year.ToString();

        }

        //EVENT METHODS
        private void FrmSach2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            func.connectDB();
            getSach();
            fillComboBox();
            func.updateDGVNumber(soluonglb, dgvSach);
            firstSetup();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchSach();
            func.updateDGVNumber(soluonglb, dgvSach);
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearch();
        }

        private void huycnbttn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            masachtxtbx.Enabled = true;
            blankUpdateField();
        }

        private void thembttn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            addRecord();
        }

        private void masachtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (func.isNull(masachtxtbx) || !func.isNumber(masachtxtbx))
            {
                thembttn.Enabled = false;
            }
            else if (!func.isNull(masachtxtbx) || !func.isNumber(masachtxtbx))
            {
                thembttn.Enabled = true;
            }
        }

        private void namxbtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (!func.isNumber(namxbtxtbx))
            {
                if (masachtxtbx.Enabled == true) thembttn.Enabled = false;
                else capnhatbttn.Enabled = false;
            }
            else
            {
                if (int.Parse(namxbtxtbx.Text) > int.Parse(DateTime.Now.Year.ToString()))
                {
                    if (masachtxtbx.Enabled == true) thembttn.Enabled = false;
                    else capnhatbttn.Enabled = false;
                    func.er.SetError(namxbtxtbx, "Năm xuất bản không được lớn hơn" + DateTime.Now.Year.ToString());
                }
                else
                {
                    func.er.Clear();
                    if (masachtxtbx.Enabled == true) thembttn.Enabled = true;
                    else capnhatbttn.Enabled = true;
                }

            }
        }

        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                masachtxtbx.Enabled = false;
                masachtxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                tensachtxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                tacgiatxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                soluongtxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                giasachtxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                namxbtxtbx.Text = dgvSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                nhaxuatbancbbx.SelectedIndex = nhaxuatbancbbx.FindString(dgvSach.Rows[e.RowIndex].Cells[6].Value.ToString());
                theloaicbbx.SelectedIndex = theloaicbbx.FindString(dgvSach.Rows[e.RowIndex].Cells[7].Value.ToString());
            } catch { }
        }

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            updatRecord();
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            removeRecord();
        }

        private void soluongtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (func.isNumber(soluongtxtbx))
            {
                if (masachtxtbx.Enabled == false) { capnhatbttn.Enabled = true; }
                else { thembttn.Enabled = true; }
            }
            else
            {
                if (masachtxtbx.Enabled == false) { capnhatbttn.Enabled = false; }
                else { thembttn.Enabled = false; }
            }
        }

        private void giasachtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (func.isNumber(giasachtxtbx))
            {
                if (masachtxtbx.Enabled == false) { capnhatbttn.Enabled = true; }
                else { thembttn.Enabled = true; }
            }
            else
            {
                if (masachtxtbx.Enabled == false) { capnhatbttn.Enabled = false; }
                else { thembttn.Enabled = false; }
            }
        }

        private void soluongtxtbx_Click(object sender, EventArgs e)
        {
            soluongtxtbx.SelectAll();
        }

        private void giasachtxtbx_Click(object sender, EventArgs e)
        {
            giasachtxtbx.SelectAll();
        }

        private void namxbtxtbx_Click(object sender, EventArgs e)
        {
            namxbtxtbx.SelectAll();
        }
    }
}
