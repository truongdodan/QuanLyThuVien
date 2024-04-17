using System;
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
    public partial class FrmDangNhap : Form
    {
        private int manv = -1;
        private int quyen = -1;
        Func func = new Func(); 
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func.connectDB();
            using (SqlCommand cmd = func.sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT COUNT(iMaNV) FROM TaiKhoan WHERE sUsername = '{taikhoantxtbx.Text}' AND sPassword = '{matkhautxtbx.Text}'";

                int i = (int) cmd.ExecuteScalar();

                if(i != 0)
                {
                    cmd.CommandText = $"SELECT * FROM TaiKhoan WHERE sUsername = '{taikhoantxtbx.Text}' AND sPassword = '{matkhautxtbx.Text}'";

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while(r.Read())
                        {
                            manv = (int) r.GetValue(0);
                            quyen = (int) r.GetValue(3);
                        }
                    }

                    this.Hide();
                    FrmHome frmHome = new FrmHome();
                    frmHome.setManv(manv);
                    frmHome.setQuyen(quyen);
                    frmHome.ShowDialog();
                    this.Close();

                }
                else
                {
                    func.er.SetError(taikhoantxtbx, "Tài khoản hoặc mật khẩu không đúng");
                    func.er.SetError(matkhautxtbx, "Tài khoản hoặc mật khẩu không đúng");
                }
            }


        }

        private void taikhoantxtbx_Click(object sender, EventArgs e)
        {
            func.er.Clear();
        }

        private void matkhautxtbx_Click(object sender, EventArgs e)
        {
            func.er.Clear();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}
