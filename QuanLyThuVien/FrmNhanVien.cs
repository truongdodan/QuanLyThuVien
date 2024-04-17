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
    public partial class FrmNhanVien : Form
    {
        Func func = new Func();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getNhanVien()
        {
            nhanviendgv.DataSource = func.getTable("v_NhanVien");
        }

        private void blankSearchSection()
        {
            theotentxtbx.Text = "";
            theongaysinhdtp.CustomFormat = " ";
        }

        private void searchNhanVien()
        {
            string query = @"SELECT iMaNV as [Mã NV], sHoTen as [Họ Tên], sGioiTinh as [Giới tính], dNgaySinh as [Ngày sinh], sSDT as [SĐT], sDiaChi as [Địa chỉ]
                            FROM NhanVien WHERE 1 = 1 ";
            if(theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sHoTen LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if (theongaysinhckbx.Checked)
            {
                query += "AND dNgaySinh = '" + theongaysinhdtp.Value.ToString("MM/dd/yyyy") + "' ";
            }

            func.getRecord(query, nhanviendgv);
            func.updateDGVNumber(soluonglb, nhanviendgv);
        }

        private void firstSetUp()
        {
            nurabttn.Checked = true;
            ngaysinhdtp.CustomFormat = " ";
            theongaysinhdtp.CustomFormat = " ";
        }

        private void blankUpdateSection()
        {
            manhanvientxtbx.Text = "";
            hotentxtbx.Text = "";
            nurabttn.Checked = true;
            sdttxtbx.Text = "";
            ngaysinhdtp.CustomFormat = " ";
            diachitxtbx.Text = "";
            func.er.Clear();
            thembttn.Enabled = true;
            manhanvientxtbx.Enabled = true;
        }

        private void addRecord()
        {
            if(manhanvientxtbx.Text == "" || hotentxtbx.Text == "" || sdttxtbx.Text == "" || diachitxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(func.isRecordExist(int.Parse(manhanvientxtbx.Text), "NhanVien", "iMaNV"))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string gioitinh = "Nữ";
                    if (namrabttn.Checked) { gioitinh = "Nam"; }
                    else if (nurabttn.Checked) { gioitinh = "Nữ"; }

                    string query = $"INSERT INTO NhanVien VALUES({int.Parse(manhanvientxtbx.Text)}, N'{hotentxtbx.Text}', N'{gioitinh}', '{ngaysinhdtp.Value}', '{sdttxtbx.Text}', N'{diachitxtbx.Text}')";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(nhanviendgv, "v_NhanVien");
                        func.updateDGVNumber(soluonglb, nhanviendgv);

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
            if (manhanvientxtbx.Text == "" || hotentxtbx.Text == "" || sdttxtbx.Text == "" || diachitxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string gioitinh = "Nữ";
                if (namrabttn.Checked) { gioitinh = "Nam"; }
                else if (nurabttn.Checked) { gioitinh = "Nữ"; }

                string query = $"UPDATE NhanVien SET sHoTen = N'{hotentxtbx.Text}', sGioiTinh = N'{gioitinh}', dNgaySinh = '{ngaysinhdtp.Value}', sSDT = '{sdttxtbx.Text}', sDiaChi = N'{diachitxtbx.Text}' WHERE iMaNV = {int.Parse(manhanvientxtbx.Text)}";

                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchNhanVien();
                    //func.updateDGV(nhanviendgv, "v_NhanVien");
                    func.updateDGVNumber(soluonglb, nhanviendgv);

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRecord()
        {
            if (manhanvientxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(!func.isRecordExist(int.Parse(manhanvientxtbx.Text), "NhanVien", "iMaNV"))
                {
                    MessageBox.Show("Nhân viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(func.isRecordExist(int.Parse(manhanvientxtbx.Text), "PhieuMuon", "iMaNV") || func.isRecordExist(int.Parse(manhanvientxtbx.Text), "TaiKhoan", "iMaNV"))
                    {
                        MessageBox.Show("Không thể xóa do nhân viên còn liên quan đến thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = $"DELETE FROM NhanVien WHERE iMaNV = {int.Parse(manhanvientxtbx.Text)}";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            func.updateDGV(nhanviendgv, "v_NhanVien");
                            func.updateDGVNumber(soluonglb, nhanviendgv);

                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }




        //EVENT METHODS
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            func.connectDB();
            getNhanVien();
            func.updateDGVNumber(soluonglb, nhanviendgv);
            firstSetUp();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchNhanVien();
        }

        private void manhanvientxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(manhanvientxtbx) || !func.isNumber(manhanvientxtbx))
            {
                thembttn.Enabled = false;
            }
            else
            {
                thembttn.Enabled=true; 
            }
        }

        private void huycnbttn_Click(object sender, EventArgs e)
        {
            blankUpdateSection();
        }

        private void theongaysinhdtp_ValueChanged(object sender, EventArgs e)
        {
            theongaysinhdtp.CustomFormat = "MM/dd/yyyy";
        }

        private void ngaysinhdtp_ValueChanged(object sender, EventArgs e)
        {
            ngaysinhdtp.CustomFormat = "MM/dd/yyyy";
        }

        private void thembttn_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void nhanviendgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            manhanvientxtbx.Enabled = false;
            manhanvientxtbx.Text = nhanviendgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            hotentxtbx.Text = nhanviendgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(nhanviendgv.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam") { namrabttn.Checked = true; }
            else { nurabttn.Checked = true; }
            ngaysinhdtp.Text = nhanviendgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            sdttxtbx.Text = nhanviendgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            diachitxtbx.Text = nhanviendgv.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removeRecord();
        }
    }
}
