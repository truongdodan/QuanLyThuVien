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
    public partial class FrmTheLoai : Form
    {
        Func func = new Func();
        public FrmTheLoai()
        {
            InitializeComponent();
        }

        //FUNCTION METHODS
        private void getTheLoai()
        {
            theloaidgv.DataSource = func.getTable("v_TheLoai");
        }

        private void fillCombobox()
        {
            //Theo danh muc comboxbox
            DataTable theodm = func.getTable("DanhMuc");
            theodanhmuccbbx.DataSource = theodm;
            theodanhmuccbbx.DisplayMember = "sTenDM";
            theodanhmuccbbx.ValueMember = "iMaDM";

            //Danh muc combobox
            DataTable theodm2 = func.getTable("DanhMuc");
            danhmuccbbx.DataSource = theodm2;
            danhmuccbbx.DisplayMember = "sTenDM";
            danhmuccbbx.ValueMember = "iMaDM";
        }

        private void blankSearchSection()
        {
            theotentxtbx.Text = "";
            theodanhmuccbbx.SelectedIndex = -1;
        }

        private void searchTheLoai()
        {
            string query = @"select iMaTL as [Mã TL], sTenTL as [Tên TL], sTenDM as [Tên danh mục]
                            from TheLoai, DanhMuc where TheLoai.iMaDM = DanhMuc.iMaDM AND 1 = 1 ";

            if(theotenckbx.Checked && theotentxtbx.Text != "")
            {
                query += $"AND sTenTL LIKE N'%" + theotentxtbx.Text + "%' ";
            }
            if(theodanhmucckbx.Checked)
            {
                query += $"AND TheLoai.iMaDM = {int.Parse(theodanhmuccbbx.SelectedValue.ToString())}";
            }

            func.getRecord(query, theloaidgv);
        }

        private void firstSetUp()
        {
            theodanhmuccbbx.SelectedIndex = -1;
            danhmuccbbx.SelectedIndex = -1;
        }

        private void blankUpdateSection()
        {
            matheloaitxtbx.Text = "";
            tentheloaitxtbx.Text = "";
            danhmuccbbx.SelectedIndex = -1;
            matheloaitxtbx.Enabled = true;
            thembttn.Enabled = true;
            func.er.Clear();
        }

        private void addRecord()
        {
            if(matheloaitxtbx.Text == "" || tentheloaitxtbx.Text == "" || danhmuccbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if(func.isRecordExist(int.Parse(matheloaitxtbx.Text), "TheLoai", "iMaTL"))
                {
                    MessageBox.Show("Thể loại đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string query = $"INSERT INTO TheLoai VALUES({int.Parse(matheloaitxtbx.Text)}, N'{tentheloaitxtbx.Text}', {danhmuccbbx.SelectedValue})";

                    if (func.queryExecuter(query))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        func.updateDGV(theloaidgv, "v_TheLoai");
                        func.updateDGVNumber(soluonglb, theloaidgv);

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
            if (matheloaitxtbx.Text == "" || tentheloaitxtbx.Text == "" || danhmuccbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào các ô thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string query = $"UPDATE TheLoai SET sTenTL = N'{tentheloaitxtbx.Text}', iMaDM = {danhmuccbbx.SelectedValue} WHERE iMaTL = {int.Parse(matheloaitxtbx.Text)}";

                if (func.queryExecuter(query))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchTheLoai();
                    //func.updateDGV(theloaidgv, "v_TheLoai");
                    func.updateDGVNumber(soluonglb, theloaidgv);

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRecord()
        {
            if(matheloaitxtbx.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã thể loại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (!func.isRecordExist(int.Parse(matheloaitxtbx.Text), "TheLoai", "iMaTL"))
                {
                    MessageBox.Show("Không tồn tại thể loại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (func.isRecordExist(int.Parse(matheloaitxtbx.Text), "Sach", "iMaTL"))
                    {
                        MessageBox.Show("Không thể xóa do thể loại này liên kết tới thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = $"DELETE FROM TheLoai WHERE iMaTL = {int.Parse(matheloaitxtbx.Text)}";

                        if (func.queryExecuter(query))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            func.updateDGV(theloaidgv, "v_TheLoai");
                            func.updateDGVNumber(soluonglb, theloaidgv);

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

        private void FrmTheLoai_Load(object sender, EventArgs e)
        {
            func.connectDB();
            getTheLoai();
            fillCombobox();
            func.updateDGVNumber(soluonglb, theloaidgv);
            firstSetUp();
        }

        private void huytkbttn_Click(object sender, EventArgs e)
        {
            blankSearchSection();
        }

        private void timbttn_Click(object sender, EventArgs e)
        {
            searchTheLoai();
            func.updateDGVNumber(soluonglb, theloaidgv);
        }

        private void matheloaitxtbx_Validating(object sender, CancelEventArgs e)
        {
            if(func.isNull(matheloaitxtbx) || !func.isNumber(matheloaitxtbx) )
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

        private void capnhatbttn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void theloaidgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                matheloaitxtbx.Enabled = false;
                matheloaitxtbx.Text = theloaidgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tentheloaitxtbx.Text = theloaidgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                danhmuccbbx.SelectedIndex = danhmuccbbx.FindString(theloaidgv.Rows[e.RowIndex].Cells[2].Value.ToString());
            } catch { }
        }

        private void xoabttn_Click(object sender, EventArgs e)
        {
            removeRecord();
        }
    }
}
