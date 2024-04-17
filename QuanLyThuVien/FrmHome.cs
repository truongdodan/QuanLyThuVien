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
    public partial class FrmHome : Form
    {
        private int manv;
        private int quyen;
        FrmDanhMuc frmDanhMuc = null;
        FrmTheLoai frmTheLoai = null;
        FrmNhaXuatBan frmNhaXuatBan = null;
        FrmTheTV frmTheTV = null;
        FrmQuanLyMuonTra frmQuanLyMuonTra = null;
        FrmNhanVien frmNhanVien = null;
        FrmSach2 frmSach2 = null;
        FrmThongKePhieuMuon_CTPhieuMuon frmThongKePhieuMuon_CTPhieuMuon = null;
        FrmThongKeSach frmThongKeSach = null;
        FrmThongKeTheTV frmThongKeTheTV = null;

        public FrmHome()
        {
            InitializeComponent();
        }

        public void setManv(int manv)
        {
            this.manv = manv;
        }

        public int getManv()
        {
            return this.manv;
        }
        public void setQuyen(int quyen)
        {
            this.quyen = quyen;
        }

        public int getQuyen()
        {
            return this.quyen;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanlymuontrasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmQuanLyMuonTra"] as FrmQuanLyMuonTra != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmQuanLyMuonTra = new FrmQuanLyMuonTra();
                frmQuanLyMuonTra.setManv(this.manv);
                frmQuanLyMuonTra.Show();
            }
            
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            if(quyen != 1) { nhanvienToolStripMenuItem.Enabled = false; } 
            else { nhanvienToolStripMenuItem.Enabled=true; }
            
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quyen != 1)
            {
                MessageBox.Show("Bạn không đủ thẩm quyền để truy cập vào bảng này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(Application.OpenForms["FrmNhanVien"] as FrmNhanVien != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    frmNhanVien = new FrmNhanVien();
                    frmNhanVien.Show();
                }
            }
        }

        private void danhmucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmDanhMuc"] as FrmDanhMuc != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmDanhMuc = new FrmDanhMuc();
                frmDanhMuc.Show();
            }
        }

        private void theloaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTheLoai"] as FrmTheLoai != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmTheLoai = new FrmTheLoai();
                frmTheLoai.Show();
            }
            
        }

        private void nhaxuatbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmNhaXuatBan"] as FrmNhaXuatBan != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmNhaXuatBan = new FrmNhaXuatBan();
                frmNhaXuatBan.Show();
            }
            
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSach2"] as FrmSach2 != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmSach2 = new FrmSach2();
                frmSach2.Show();
            }
            
        }

        private void thethanhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTheTV"] as FrmTheTV != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmTheTV = new FrmTheTV();
                frmTheTV.Show();
            }
            
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();

            if (Application.OpenForms["FrmDanhMuc"] as FrmDanhMuc != null) { this.frmDanhMuc.Close(); }
            if (Application.OpenForms["FrmTheLoai"] as FrmTheLoai != null) { this.frmTheLoai.Close(); }
            if (Application.OpenForms["FrmNhaXuatBan"] as FrmNhaXuatBan != null) { this.frmNhaXuatBan.Close(); }
            if (Application.OpenForms["FrmSach2"] as FrmSach2 != null) { this.frmSach2.Close(); }
            if (Application.OpenForms["FrmTheTV"] as FrmTheTV != null) { this.frmTheTV.Close(); }
            if (Application.OpenForms["FrmQuanLyMuonTra"] as FrmQuanLyMuonTra != null) { this.frmQuanLyMuonTra.Close(); }
            if (Application.OpenForms["FrmNhanVien"] as FrmNhanVien != null) { this.frmNhanVien.Close(); }
            if (Application.OpenForms["FrmThongKePhieuMuon_CTPhieuMuon"] as FrmThongKePhieuMuon_CTPhieuMuon != null) { this.frmThongKePhieuMuon_CTPhieuMuon.Close(); }
            if (Application.OpenForms["FrmThongKeSach"] as FrmThongKeSach != null) { this.frmThongKeSach.Close(); }
            if (Application.OpenForms["FrmThongKeTheTV"] as FrmThongKeTheTV != null) { this.frmThongKeTheTV.Close(); }

            this.Close();
            frmDangNhap.ShowDialog();
        }

        private void thongkephieumuonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmThongKePhieuMuon_CTPhieuMuon"] as FrmThongKePhieuMuon_CTPhieuMuon != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmThongKePhieuMuon_CTPhieuMuon = new FrmThongKePhieuMuon_CTPhieuMuon();
                frmThongKePhieuMuon_CTPhieuMuon.Show();
            }
        }

        private void thongkesachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmThongKeSach"] as FrmThongKeSach != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmThongKeSach = new FrmThongKeSach();
                frmThongKeSach.Show();
            }
        }

        private void thanhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmThongKeTheTV"] as FrmThongKeTheTV != null) { MessageBox.Show("Form đã mở", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                frmThongKeTheTV = new FrmThongKeTheTV();
                frmThongKeTheTV.Show();
            }
        }
    }
}
