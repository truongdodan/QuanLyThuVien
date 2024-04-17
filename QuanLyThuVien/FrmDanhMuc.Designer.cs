namespace QuanLyThuVien
{
    partial class FrmDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.huybttn = new System.Windows.Forms.Button();
            this.xoabttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.capnhatbttn = new System.Windows.Forms.Button();
            this.danhmucdgv = new System.Windows.Forms.DataGridView();
            this.thembttn = new System.Windows.Forms.Button();
            this.vitritxtbx = new System.Windows.Forms.TextBox();
            this.tendmtxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.madmtxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soluonglb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // huybttn
            // 
            this.huybttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huybttn.Location = new System.Drawing.Point(361, 122);
            this.huybttn.Name = "huybttn";
            this.huybttn.Size = new System.Drawing.Size(75, 23);
            this.huybttn.TabIndex = 27;
            this.huybttn.Text = "Hủy";
            this.huybttn.UseVisualStyleBackColor = true;
            this.huybttn.Click += new System.EventHandler(this.huybttn_Click);
            // 
            // xoabttn
            // 
            this.xoabttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabttn.Location = new System.Drawing.Point(361, 93);
            this.xoabttn.Name = "xoabttn";
            this.xoabttn.Size = new System.Drawing.Size(75, 23);
            this.xoabttn.TabIndex = 26;
            this.xoabttn.Text = "Xóa";
            this.xoabttn.UseVisualStyleBackColor = true;
            this.xoabttn.Click += new System.EventHandler(this.xoabttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Danh mục";
            // 
            // capnhatbttn
            // 
            this.capnhatbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhatbttn.Location = new System.Drawing.Point(361, 64);
            this.capnhatbttn.Name = "capnhatbttn";
            this.capnhatbttn.Size = new System.Drawing.Size(75, 23);
            this.capnhatbttn.TabIndex = 25;
            this.capnhatbttn.Text = "Cập nhật";
            this.capnhatbttn.UseVisualStyleBackColor = true;
            this.capnhatbttn.Click += new System.EventHandler(this.capnhatbttn_Click);
            // 
            // danhmucdgv
            // 
            this.danhmucdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhmucdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.danhmucdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhmucdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.danhmucdgv.Location = new System.Drawing.Point(51, 263);
            this.danhmucdgv.Name = "danhmucdgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhmucdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.danhmucdgv.RowHeadersWidth = 51;
            this.danhmucdgv.RowTemplate.Height = 24;
            this.danhmucdgv.Size = new System.Drawing.Size(463, 175);
            this.danhmucdgv.TabIndex = 28;
            this.danhmucdgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.danhmucdgv_CellMouseClick);
            // 
            // thembttn
            // 
            this.thembttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thembttn.Location = new System.Drawing.Point(361, 35);
            this.thembttn.Name = "thembttn";
            this.thembttn.Size = new System.Drawing.Size(75, 23);
            this.thembttn.TabIndex = 24;
            this.thembttn.Text = "Thêm ";
            this.thembttn.UseVisualStyleBackColor = true;
            this.thembttn.Click += new System.EventHandler(this.thembttn_Click);
            // 
            // vitritxtbx
            // 
            this.vitritxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitritxtbx.Location = new System.Drawing.Point(167, 97);
            this.vitritxtbx.Name = "vitritxtbx";
            this.vitritxtbx.Size = new System.Drawing.Size(166, 24);
            this.vitritxtbx.TabIndex = 23;
            // 
            // tendmtxtbx
            // 
            this.tendmtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendmtxtbx.Location = new System.Drawing.Point(167, 66);
            this.tendmtxtbx.Name = "tendmtxtbx";
            this.tendmtxtbx.Size = new System.Drawing.Size(166, 24);
            this.tendmtxtbx.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vị trí:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã danh muc:";
            // 
            // madmtxtbx
            // 
            this.madmtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madmtxtbx.Location = new System.Drawing.Point(167, 35);
            this.madmtxtbx.Name = "madmtxtbx";
            this.madmtxtbx.Size = new System.Drawing.Size(166, 24);
            this.madmtxtbx.TabIndex = 19;
            this.madmtxtbx.Validating += new System.ComponentModel.CancelEventHandler(this.madmtxtbx_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên danh mục:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.huybttn);
            this.groupBox1.Controls.Add(this.xoabttn);
            this.groupBox1.Controls.Add(this.capnhatbttn);
            this.groupBox1.Controls.Add(this.thembttn);
            this.groupBox1.Controls.Add(this.vitritxtbx);
            this.groupBox1.Controls.Add(this.tendmtxtbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.madmtxtbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 169);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật";
            // 
            // soluonglb
            // 
            this.soluonglb.AutoSize = true;
            this.soluonglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonglb.Location = new System.Drawing.Point(129, 242);
            this.soluonglb.Name = "soluonglb";
            this.soluonglb.Size = new System.Drawing.Size(16, 18);
            this.soluonglb.TabIndex = 32;
            this.soluonglb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Số lượng: ";
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 465);
            this.Controls.Add(this.soluonglb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.danhmucdgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDanhMuc";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhmucdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button huybttn;
        private System.Windows.Forms.Button xoabttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button capnhatbttn;
        private System.Windows.Forms.DataGridView danhmucdgv;
        private System.Windows.Forms.Button thembttn;
        private System.Windows.Forms.TextBox vitritxtbx;
        private System.Windows.Forms.TextBox tendmtxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox madmtxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label soluonglb;
        private System.Windows.Forms.Label label9;
    }
}

