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
    public partial class FrmNhaXuatBan : Form
    {
        Func func = new Func();

        public FrmNhaXuatBan()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getNXB()
        {
            nxbdgv.DataSource = func.getTable("v_NXB");
        }

        private void blankSearchSection()
        {
            theotentxtbx.Text = "";
            theodiachitxtbx.Text = "";
        }

        private void searchNXB()
        {
            string query = @"select iMaNXB as [Mã NXB], sTenNXB as [Tên NXB], sSDT as [SĐT], sDiaChi as [Địa chỉ] FROM NhaXuatBan WHERE 1 = 1 ";

            if(theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += "AND sTenNXB LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if (theodiachickbx.Checked && theodiachitxtbx.Text != "")
            {
                query += "AND sDiaChi LIKE N'%" + theodiachitxtbx.Text + "%'";
            }

            func.getRecord(query, nxbdgv);
            func.updateDGVNumber(soluonglb, nxbdgv);
        }

        private void blankUpdateSection()
        {
            manxbtxtbx.Text = "";
            tennxbtxtbx.Text = "";
            sdttxtbx.Text = "";
            diachitxtbx.Text = "";
            manxbtxtbx.Enabled = true;
            thembttn.Enabled = true;
            func.er.Clear();
        }

        private void addRecord()
        {
            if(manxbtxtbx.Text == "" || tennxbtxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền tối thiểu mã và tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(func.isRecordExist(int.Parse(manxbtxtbx.Text), "NhaXuatBan", "iMaNXB"))
                {
                    MessageBox.Show("Đã tồn tại nhà xuất bản trùng mã", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = $"INSERT INTO NhaXuatBan VALUES({int.Parse(manxbtxtbx.Text)}, N'{tennxbtxtbx.Text}', '{sdttxtbx.Text}', N'{diachitxtbx.Text}')";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(nxbdgv, "v_NXB");
                        func.updateDGVNumber(soluonglb, nxbdgv);

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
            if (manxbtxtbx.Text == "" || tennxbtxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền tối thiểu mã và tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"UPDATE NhaXuatBan SET sTenNXB = N'{tennxbtxtbx.Text}', sSDT = '{sdttxtbx.Text}', sDiaChi = N'{diachitxtbx.Text}' WHERE iMaNXB = {int.Parse(manxbtxtbx.Text)}";

                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchNXB();
                    //func.updateDGV(nxbdgv, "v_NXB");
                    func.updateDGVNumber(soluonglb, nxbdgv);

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRecord()
        {
            if (manxbtxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(!func.isRecordExist(int.Parse(manxbtxtbx.Text), "NhaXuatBan", "iMaNXB"))
                {
                    MessageBox.Show("Nhà xuất bản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if(func.isRecordExist(int.Parse(manxbtxtbx.Text), "Sach", "iMaNXB"))
                    {
                        MessageBox.Show("Không thể xóa do nhà xuất bản có liên kết với các thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string query = $"DELETE FROM NhaXuatBan WHERE iMaNXB = {int.Parse(manxbtxtbx.Text)}";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            func.updateDGV(nxbdgv, "v_NXB");
                            func.updateDGVNumber(soluonglb, nxbdgv);

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
        private void FrmNhaXuatBan_Load(object sender, EventArgs e)
        {
            func.connectDB();
            getNXB();
            func.updateDGVNumber(soluonglb, nxbdgv);
            this.ActiveControl = label1;
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchNXB();
        }

        private void manxbtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (func.isNull(manxbtxtbx) || !func.isNumber(manxbtxtbx))
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

        private void thembttn_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void nxbdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                manxbtxtbx.Text = nxbdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tennxbtxtbx.Text = nxbdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                sdttxtbx.Text = nxbdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                diachitxtbx.Text = nxbdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            } catch { }
        }

        private void capnhatbbtn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removeRecord();
        }
    }
}
