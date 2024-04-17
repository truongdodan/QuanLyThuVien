namespace QuanLyThuVien
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theloaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaxuatbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thethanhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlymuontrasachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkephieumuonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkesachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.quanlymuontrasachToolStripMenuItem,
            this.thongkeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangxuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.dangxuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhmucToolStripMenuItem,
            this.theloaiToolStripMenuItem,
            this.nhaxuatbanToolStripMenuItem,
            this.sachToolStripMenuItem,
            this.thethanhvienToolStripMenuItem,
            this.nhanvienToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // danhmucToolStripMenuItem
            // 
            this.danhmucToolStripMenuItem.Name = "danhmucToolStripMenuItem";
            this.danhmucToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.danhmucToolStripMenuItem.Text = "Danh mục";
            this.danhmucToolStripMenuItem.Click += new System.EventHandler(this.danhmucToolStripMenuItem_Click);
            // 
            // theloaiToolStripMenuItem
            // 
            this.theloaiToolStripMenuItem.Name = "theloaiToolStripMenuItem";
            this.theloaiToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.theloaiToolStripMenuItem.Text = "Thể loại";
            this.theloaiToolStripMenuItem.Click += new System.EventHandler(this.theloaiToolStripMenuItem_Click);
            // 
            // nhaxuatbanToolStripMenuItem
            // 
            this.nhaxuatbanToolStripMenuItem.Name = "nhaxuatbanToolStripMenuItem";
            this.nhaxuatbanToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.nhaxuatbanToolStripMenuItem.Text = "Nhà xuất bản";
            this.nhaxuatbanToolStripMenuItem.Click += new System.EventHandler(this.nhaxuatbanToolStripMenuItem_Click);
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.sachToolStripMenuItem.Text = "Sách";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sachToolStripMenuItem_Click);
            // 
            // thethanhvienToolStripMenuItem
            // 
            this.thethanhvienToolStripMenuItem.Name = "thethanhvienToolStripMenuItem";
            this.thethanhvienToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.thethanhvienToolStripMenuItem.Text = "Thẻ thành viên";
            this.thethanhvienToolStripMenuItem.Click += new System.EventHandler(this.thethanhvienToolStripMenuItem_Click);
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.nhanvienToolStripMenuItem.Text = "Nhân viên";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // quanlymuontrasachToolStripMenuItem
            // 
            this.quanlymuontrasachToolStripMenuItem.Name = "quanlymuontrasachToolStripMenuItem";
            this.quanlymuontrasachToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.quanlymuontrasachToolStripMenuItem.Text = "Quản lý mượn trả sách";
            this.quanlymuontrasachToolStripMenuItem.Click += new System.EventHandler(this.quanlymuontrasachToolStripMenuItem_Click);
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongkephieumuonToolStripMenuItem,
            this.thongkesachToolStripMenuItem,
            this.thanhvienToolStripMenuItem});
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thongkeToolStripMenuItem.Text = "Thống kê";
            // 
            // thongkephieumuonToolStripMenuItem
            // 
            this.thongkephieumuonToolStripMenuItem.Name = "thongkephieumuonToolStripMenuItem";
            this.thongkephieumuonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thongkephieumuonToolStripMenuItem.Text = "Phiếu mượn";
            this.thongkephieumuonToolStripMenuItem.Click += new System.EventHandler(this.thongkephieumuonToolStripMenuItem_Click);
            // 
            // thongkesachToolStripMenuItem
            // 
            this.thongkesachToolStripMenuItem.Name = "thongkesachToolStripMenuItem";
            this.thongkesachToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thongkesachToolStripMenuItem.Text = "Sách ";
            this.thongkesachToolStripMenuItem.Click += new System.EventHandler(this.thongkesachToolStripMenuItem_Click);
            // 
            // thanhvienToolStripMenuItem
            // 
            this.thanhvienToolStripMenuItem.Name = "thanhvienToolStripMenuItem";
            this.thanhvienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thanhvienToolStripMenuItem.Text = "Thành viên";
            this.thanhvienToolStripMenuItem.Click += new System.EventHandler(this.thanhvienToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(345, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ thống quản lý thư viện";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.peakpx__6_;
            this.ClientSize = new System.Drawing.Size(1033, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhmucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theloaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaxuatbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thethanhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlymuontrasachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thongkephieumuonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkesachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhvienToolStripMenuItem;
    }
}