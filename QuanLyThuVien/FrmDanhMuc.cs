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
    public partial class FrmDanhMuc : Form
    {
        Func func = new Func();
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        //FUNCTION METHOD
        private void getDanhMuc()
        {
            danhmucdgv.DataSource = func.getTable("v_DanhMuc");
        }
        private void blankAllField()
        {
            madmtxtbx.Text = "";
            tendmtxtbx.Text = "";
            vitritxtbx.Text = "";
        }

        private void addRecord()
        {
            if (madmtxtbx.Text == "" || tendmtxtbx.Text == "" || vitritxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ vào các ô trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(madmtxtbx.Text), "DanhMuc", "iMaDM"))
                {
                    MessageBox.Show("Danh mục này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tendmtxtbx.Text == "" || vitritxtbx.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đủ các ô thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = $"INSERT INTO DanhMuc VALUES({int.Parse(madmtxtbx.Text)}, N'{tendmtxtbx.Text}', N'{vitritxtbx.Text}')";
                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else { MessageBox.Show("Lỗi thêm danh mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                }
            }
        }

        private void updateRecord()
        {
            if (madmtxtbx.Text == "" || tendmtxtbx.Text == "" || vitritxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ vào các ô trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"UPDATE DanhMuc SET sTenDM = N'{tendmtxtbx.Text}', sViTri = N'{vitritxtbx.Text}' WHERE iMaDM = {int.Parse(madmtxtbx.Text)}";
                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Lỗi cập nhật danh mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void removeRecord()
        {
            if (madmtxtbx.Text == "" || tendmtxtbx.Text == "" || vitritxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ các ô thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (func.isRecordExist(int.Parse(madmtxtbx.Text), "TheLoai", "iMaDM"))
                {
                    MessageBox.Show("Không thể xóa do danh mục có liên kết với các thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (madmtxtbx.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền mã danh mục", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string query = $"DELETE FROM DanhMuc WHERE iMaDM = {int.Parse(madmtxtbx.Text)}";
                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else { MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                }
            }
        }

        //EVENT METHOD
        private void huybttn_Click(object sender, EventArgs e)
        {
            madmtxtbx.Enabled = true;
            blankAllField();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            func.connectDB();
            getDanhMuc();
            func.updateDGVNumber(soluonglb, danhmucdgv);
        }

        private void madmtxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(madmtxtbx) || !func.isNumber(madmtxtbx))
            {
                thembttn.Enabled = false;
            }
            else { thembttn.Enabled = true;}
        }

        private void thembttn_Click(object sender, EventArgs e)
        {
            addRecord();
            func.updateDGV(danhmucdgv, "DanhMuc");
            func.updateDGVNumber(soluonglb, danhmucdgv);
        }

        private void danhmucdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                madmtxtbx.Enabled = false;
                madmtxtbx.Text = danhmucdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tendmtxtbx.Text = danhmucdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                vitritxtbx.Text = danhmucdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }catch { }

        }

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            updateRecord();
            func.updateDGV(danhmucdgv, "DanhMuc");
            func.updateDGVNumber(soluonglb, danhmucdgv);
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removeRecord();
            func.updateDGV(danhmucdgv, "DanhMuc");
            func.updateDGVNumber(soluonglb, danhmucdgv);
        }
    }
}
