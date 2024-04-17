namespace QuanLyThuVien
{
    partial class FrmSach2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.namxbtxtbx = new System.Windows.Forms.TextBox();
            this.tacgiatxtbx = new System.Windows.Forms.TextBox();
            this.theloaicbbx = new System.Windows.Forms.ComboBox();
            this.nhaxuatbancbbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.giasachtxtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.huycnbttn = new System.Windows.Forms.Button();
            this.xoabttn = new System.Windows.Forms.Button();
            this.capnhatbttn = new System.Windows.Forms.Button();
            this.thembttn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soluongtxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tensachtxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masachtxtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.soluonglb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.theonxbcbbx = new System.Windows.Forms.ComboBox();
            this.theoNXBckbx = new System.Windows.Forms.CheckBox();
            this.theotheloaicbbx = new System.Windows.Forms.ComboBox();
            this.theotlckbx = new System.Windows.Forms.CheckBox();
            this.theonamXBckbx = new System.Windows.Forms.CheckBox();
            this.theonamxuatbantxtbx = new System.Windows.Forms.TextBox();
            this.theotentxtbx = new System.Windows.Forms.TextBox();
            this.theotenckbx = new System.Windows.Forms.CheckBox();
            this.huytkbttn = new System.Windows.Forms.Button();
            this.timbttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(38, 561);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(799, 310);
            this.dgvSach.TabIndex = 3;
            this.dgvSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSach_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.namxbtxtbx);
            this.groupBox2.Controls.Add(this.tacgiatxtbx);
            this.groupBox2.Controls.Add(this.theloaicbbx);
            this.groupBox2.Controls.Add(this.nhaxuatbancbbx);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.giasachtxtbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.huycnbttn);
            this.groupBox2.Controls.Add(this.xoabttn);
            this.groupBox2.Controls.Add(this.capnhatbttn);
            this.groupBox2.Controls.Add(this.thembttn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.soluongtxtbx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tensachtxtbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.masachtxtbx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 243);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật";
            // 
            // namxbtxtbx
            // 
            this.namxbtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namxbtxtbx.Location = new System.Drawing.Point(574, 106);
            this.namxbtxtbx.Name = "namxbtxtbx";
            this.namxbtxtbx.Size = new System.Drawing.Size(173, 24);
            this.namxbtxtbx.TabIndex = 35;
            this.namxbtxtbx.Click += new System.EventHandler(this.namxbtxtbx_Click);
            this.namxbtxtbx.Validating += new System.ComponentModel.CancelEventHandler(this.namxbtxtbx_Validating);
            // 
            // tacgiatxtbx
            // 
            this.tacgiatxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacgiatxtbx.Location = new System.Drawing.Point(155, 106);
            this.tacgiatxtbx.Name = "tacgiatxtbx";
            this.tacgiatxtbx.Size = new System.Drawing.Size(173, 24);
            this.tacgiatxtbx.TabIndex = 34;
            // 
            // theloaicbbx
            // 
            this.theloaicbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theloaicbbx.FormattingEnabled = true;
            this.theloaicbbx.Location = new System.Drawing.Point(155, 141);
            this.theloaicbbx.Name = "theloaicbbx";
            this.theloaicbbx.Size = new System.Drawing.Size(173, 26);
            this.theloaicbbx.TabIndex = 33;
            // 
            // nhaxuatbancbbx
            // 
            this.nhaxuatbancbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaxuatbancbbx.FormattingEnabled = true;
            this.nhaxuatbancbbx.Location = new System.Drawing.Point(574, 141);
            this.nhaxuatbancbbx.Name = "nhaxuatbancbbx";
            this.nhaxuatbancbbx.Size = new System.Drawing.Size(173, 26);
            this.nhaxuatbancbbx.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Thể loại:";
            // 
            // giasachtxtbx
            // 
            this.giasachtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giasachtxtbx.Location = new System.Drawing.Point(574, 71);
            this.giasachtxtbx.Name = "giasachtxtbx";
            this.giasachtxtbx.Size = new System.Drawing.Size(173, 24);
            this.giasachtxtbx.TabIndex = 29;
            this.giasachtxtbx.Text = "0";
            this.giasachtxtbx.Click += new System.EventHandler(this.giasachtxtbx_Click);
            this.giasachtxtbx.Validating += new System.ComponentModel.CancelEventHandler(this.giasachtxtbx_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Giá sách:";
            // 
            // huycnbttn
            // 
            this.huycnbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huycnbttn.Location = new System.Drawing.Point(292, 190);
            this.huycnbttn.Name = "huycnbttn";
            this.huycnbttn.Size = new System.Drawing.Size(79, 26);
            this.huycnbttn.TabIndex = 25;
            this.huycnbttn.Text = "Hủy";
            this.huycnbttn.UseVisualStyleBackColor = true;
            this.huycnbttn.Click += new System.EventHandler(this.huycnbttn_Click);
            // 
            // xoabttn
            // 
            this.xoabttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabttn.Location = new System.Drawing.Point(207, 190);
            this.xoabttn.Name = "xoabttn";
            this.xoabttn.Size = new System.Drawing.Size(79, 26);
            this.xoabttn.TabIndex = 24;
            this.xoabttn.Text = "Xóa";
            this.xoabttn.UseVisualStyleBackColor = true;
            this.xoabttn.Click += new System.EventHandler(this.xoabttn_Click);
            // 
            // capnhatbttn
            // 
            this.capnhatbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhatbttn.Location = new System.Drawing.Point(122, 190);
            this.capnhatbttn.Name = "capnhatbttn";
            this.capnhatbttn.Size = new System.Drawing.Size(79, 26);
            this.capnhatbttn.TabIndex = 23;
            this.capnhatbttn.Text = "Cập nhật";
            this.capnhatbttn.UseVisualStyleBackColor = true;
            this.capnhatbttn.Click += new System.EventHandler(this.capnhatbttn_Click);
            // 
            // thembttn
            // 
            this.thembttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thembttn.Location = new System.Drawing.Point(40, 190);
            this.thembttn.Name = "thembttn";
            this.thembttn.Size = new System.Drawing.Size(76, 26);
            this.thembttn.TabIndex = 22;
            this.thembttn.Text = "Thêm ";
            this.thembttn.UseVisualStyleBackColor = true;
            this.thembttn.Click += new System.EventHandler(this.thembttn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhà xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm xuất bản:";
            // 
            // soluongtxtbx
            // 
            this.soluongtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongtxtbx.Location = new System.Drawing.Point(574, 36);
            this.soluongtxtbx.Name = "soluongtxtbx";
            this.soluongtxtbx.Size = new System.Drawing.Size(173, 24);
            this.soluongtxtbx.TabIndex = 8;
            this.soluongtxtbx.Text = "0";
            this.soluongtxtbx.Click += new System.EventHandler(this.soluongtxtbx_Click);
            this.soluongtxtbx.Validating += new System.ComponentModel.CancelEventHandler(this.soluongtxtbx_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tác giả:";
            // 
            // tensachtxtbx
            // 
            this.tensachtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensachtxtbx.Location = new System.Drawing.Point(155, 71);
            this.tensachtxtbx.Name = "tensachtxtbx";
            this.tensachtxtbx.Size = new System.Drawing.Size(173, 24);
            this.tensachtxtbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách:";
            // 
            // masachtxtbx
            // 
            this.masachtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masachtxtbx.Location = new System.Drawing.Point(155, 36);
            this.masachtxtbx.Name = "masachtxtbx";
            this.masachtxtbx.Size = new System.Drawing.Size(173, 24);
            this.masachtxtbx.TabIndex = 2;
            this.masachtxtbx.Validating += new System.ComponentModel.CancelEventHandler(this.masachtxtbx_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã sách:";
            // 
            // soluonglb
            // 
            this.soluonglb.AutoSize = true;
            this.soluonglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonglb.Location = new System.Drawing.Point(116, 537);
            this.soluonglb.Name = "soluonglb";
            this.soluonglb.Size = new System.Drawing.Size(16, 18);
            this.soluonglb.TabIndex = 27;
            this.soluonglb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số lượng: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.theonxbcbbx);
            this.groupBox1.Controls.Add(this.theoNXBckbx);
            this.groupBox1.Controls.Add(this.theotheloaicbbx);
            this.groupBox1.Controls.Add(this.theotlckbx);
            this.groupBox1.Controls.Add(this.theonamXBckbx);
            this.groupBox1.Controls.Add(this.theonamxuatbantxtbx);
            this.groupBox1.Controls.Add(this.theotentxtbx);
            this.groupBox1.Controls.Add(this.theotenckbx);
            this.groupBox1.Controls.Add(this.huytkbttn);
            this.groupBox1.Controls.Add(this.timbttn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 168);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // theonxbcbbx
            // 
            this.theonxbcbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theonxbcbbx.FormattingEnabled = true;
            this.theonxbcbbx.Location = new System.Drawing.Point(589, 71);
            this.theonxbcbbx.Name = "theonxbcbbx";
            this.theonxbcbbx.Size = new System.Drawing.Size(162, 26);
            this.theonxbcbbx.TabIndex = 39;
            // 
            // theoNXBckbx
            // 
            this.theoNXBckbx.AutoSize = true;
            this.theoNXBckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theoNXBckbx.Location = new System.Drawing.Point(401, 74);
            this.theoNXBckbx.Name = "theoNXBckbx";
            this.theoNXBckbx.Size = new System.Drawing.Size(99, 22);
            this.theoNXBckbx.TabIndex = 38;
            this.theoNXBckbx.Text = "Theo NXB";
            this.theoNXBckbx.UseVisualStyleBackColor = true;
            // 
            // theotheloaicbbx
            // 
            this.theotheloaicbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theotheloaicbbx.FormattingEnabled = true;
            this.theotheloaicbbx.Location = new System.Drawing.Point(161, 71);
            this.theotheloaicbbx.Name = "theotheloaicbbx";
            this.theotheloaicbbx.Size = new System.Drawing.Size(162, 26);
            this.theotheloaicbbx.TabIndex = 37;
            // 
            // theotlckbx
            // 
            this.theotlckbx.AutoSize = true;
            this.theotlckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theotlckbx.Location = new System.Drawing.Point(32, 74);
            this.theotlckbx.Name = "theotlckbx";
            this.theotlckbx.Size = new System.Drawing.Size(115, 22);
            this.theotlckbx.TabIndex = 36;
            this.theotlckbx.Text = "Theo thể loại";
            this.theotlckbx.UseVisualStyleBackColor = true;
            // 
            // theonamXBckbx
            // 
            this.theonamXBckbx.AutoSize = true;
            this.theonamXBckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theonamXBckbx.Location = new System.Drawing.Point(400, 38);
            this.theonamXBckbx.Name = "theonamXBckbx";
            this.theonamXBckbx.Size = new System.Drawing.Size(156, 22);
            this.theonamXBckbx.TabIndex = 35;
            this.theonamXBckbx.Text = "Theo năm xuất bản";
            this.theonamXBckbx.UseVisualStyleBackColor = true;
            // 
            // theonamxuatbantxtbx
            // 
            this.theonamxuatbantxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theonamxuatbantxtbx.Location = new System.Drawing.Point(589, 36);
            this.theonamxuatbantxtbx.Name = "theonamxuatbantxtbx";
            this.theonamxuatbantxtbx.Size = new System.Drawing.Size(162, 24);
            this.theonamxuatbantxtbx.TabIndex = 34;
            // 
            // theotentxtbx
            // 
            this.theotentxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theotentxtbx.Location = new System.Drawing.Point(161, 36);
            this.theotentxtbx.Name = "theotentxtbx";
            this.theotentxtbx.Size = new System.Drawing.Size(162, 24);
            this.theotentxtbx.TabIndex = 18;
            // 
            // theotenckbx
            // 
            this.theotenckbx.AutoSize = true;
            this.theotenckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theotenckbx.Location = new System.Drawing.Point(32, 38);
            this.theotenckbx.Name = "theotenckbx";
            this.theotenckbx.Size = new System.Drawing.Size(92, 22);
            this.theotenckbx.TabIndex = 16;
            this.theotenckbx.Text = "Theo tên:";
            this.theotenckbx.UseVisualStyleBackColor = true;
            // 
            // huytkbttn
            // 
            this.huytkbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huytkbttn.Location = new System.Drawing.Point(667, 121);
            this.huytkbttn.Name = "huytkbttn";
            this.huytkbttn.Size = new System.Drawing.Size(84, 26);
            this.huytkbttn.TabIndex = 15;
            this.huytkbttn.Text = "Hủy";
            this.huytkbttn.UseVisualStyleBackColor = true;
            this.huytkbttn.Click += new System.EventHandler(this.huytkbttn_Click);
            // 
            // timbttn
            // 
            this.timbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timbttn.Location = new System.Drawing.Point(577, 121);
            this.timbttn.Name = "timbttn";
            this.timbttn.Size = new System.Drawing.Size(84, 26);
            this.timbttn.TabIndex = 14;
            this.timbttn.Text = "Tìm";
            this.timbttn.UseVisualStyleBackColor = true;
            this.timbttn.Click += new System.EventHandler(this.timbttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sách";
            // 
            // FrmSach2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 909);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.soluonglb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSach2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSach2";
            this.Load += new System.EventHandler(this.FrmSach2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox giasachtxtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button huycnbttn;
        private System.Windows.Forms.Button xoabttn;
        private System.Windows.Forms.Button capnhatbttn;
        private System.Windows.Forms.Button thembttn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soluongtxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tensachtxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox masachtxtbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label soluonglb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox theotentxtbx;
        private System.Windows.Forms.CheckBox theotenckbx;
        private System.Windows.Forms.Button huytkbttn;
        private System.Windows.Forms.Button timbttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox theonamxuatbantxtbx;
        private System.Windows.Forms.CheckBox theotlckbx;
        private System.Windows.Forms.CheckBox theonamXBckbx;
        private System.Windows.Forms.ComboBox theonxbcbbx;
        private System.Windows.Forms.CheckBox theoNXBckbx;
        private System.Windows.Forms.ComboBox theotheloaicbbx;
        private System.Windows.Forms.TextBox namxbtxtbx;
        private System.Windows.Forms.TextBox tacgiatxtbx;
        private System.Windows.Forms.ComboBox theloaicbbx;
        private System.Windows.Forms.ComboBox nhaxuatbancbbx;
        private System.Windows.Forms.Label label10;
    }
}