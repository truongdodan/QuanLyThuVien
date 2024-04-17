namespace QuanLyThuVien
{
    partial class FrmThongKeTheTV
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
            this.thetvdgv = new System.Windows.Forms.DataGridView();
            this.tinhtrangckbx = new System.Windows.Forms.CheckBox();
            this.huytkbttn = new System.Windows.Forms.Button();
            this.thongkebttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inbttn = new System.Windows.Forms.Button();
            this.tinhtrangcbbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.soluonglb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thetvdgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // thetvdgv
            // 
            this.thetvdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.thetvdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thetvdgv.Location = new System.Drawing.Point(48, 246);
            this.thetvdgv.Name = "thetvdgv";
            this.thetvdgv.RowHeadersWidth = 51;
            this.thetvdgv.RowTemplate.Height = 24;
            this.thetvdgv.Size = new System.Drawing.Size(934, 280);
            this.thetvdgv.TabIndex = 28;
            // 
            // tinhtrangckbx
            // 
            this.tinhtrangckbx.AutoSize = true;
            this.tinhtrangckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrangckbx.Location = new System.Drawing.Point(35, 38);
            this.tinhtrangckbx.Name = "tinhtrangckbx";
            this.tinhtrangckbx.Size = new System.Drawing.Size(95, 22);
            this.tinhtrangckbx.TabIndex = 16;
            this.tinhtrangckbx.Text = "Tình trạng";
            this.tinhtrangckbx.UseVisualStyleBackColor = true;
            // 
            // huytkbttn
            // 
            this.huytkbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huytkbttn.Location = new System.Drawing.Point(276, 85);
            this.huytkbttn.Name = "huytkbttn";
            this.huytkbttn.Size = new System.Drawing.Size(84, 26);
            this.huytkbttn.TabIndex = 15;
            this.huytkbttn.Text = "Hủy";
            this.huytkbttn.UseVisualStyleBackColor = true;
            this.huytkbttn.Click += new System.EventHandler(this.huytkbttn_Click);
            // 
            // thongkebttn
            // 
            this.thongkebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongkebttn.Location = new System.Drawing.Point(190, 85);
            this.thongkebttn.Name = "thongkebttn";
            this.thongkebttn.Size = new System.Drawing.Size(84, 26);
            this.thongkebttn.TabIndex = 14;
            this.thongkebttn.Text = "Thống kê";
            this.thongkebttn.UseVisualStyleBackColor = true;
            this.thongkebttn.Click += new System.EventHandler(this.thongkebttn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số lượng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inbttn);
            this.groupBox2.Controls.Add(this.tinhtrangcbbx);
            this.groupBox2.Controls.Add(this.tinhtrangckbx);
            this.groupBox2.Controls.Add(this.huytkbttn);
            this.groupBox2.Controls.Add(this.thongkebttn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 121);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // inbttn
            // 
            this.inbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbttn.Location = new System.Drawing.Point(454, 85);
            this.inbttn.Name = "inbttn";
            this.inbttn.Size = new System.Drawing.Size(84, 26);
            this.inbttn.TabIndex = 39;
            this.inbttn.Text = "In";
            this.inbttn.UseVisualStyleBackColor = true;
            // 
            // tinhtrangcbbx
            // 
            this.tinhtrangcbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrangcbbx.FormattingEnabled = true;
            this.tinhtrangcbbx.Location = new System.Drawing.Point(179, 35);
            this.tinhtrangcbbx.Name = "tinhtrangcbbx";
            this.tinhtrangcbbx.Size = new System.Drawing.Size(181, 26);
            this.tinhtrangcbbx.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Thống kê Thành viên";
            // 
            // soluonglb
            // 
            this.soluonglb.AutoSize = true;
            this.soluonglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonglb.Location = new System.Drawing.Point(126, 222);
            this.soluonglb.Name = "soluonglb";
            this.soluonglb.Size = new System.Drawing.Size(16, 18);
            this.soluonglb.TabIndex = 30;
            this.soluonglb.Text = "0";
            // 
            // FrmThongKeTheTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 556);
            this.Controls.Add(this.thetvdgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.soluonglb);
            this.Name = "FrmThongKeTheTV";
            this.Text = "FrmThongKeTheTV";
            this.Load += new System.EventHandler(this.FrmThongKeTheTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thetvdgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView thetvdgv;
        private System.Windows.Forms.CheckBox tinhtrangckbx;
        private System.Windows.Forms.Button huytkbttn;
        private System.Windows.Forms.Button thongkebttn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inbttn;
        private System.Windows.Forms.ComboBox tinhtrangcbbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label soluonglb;
    }
}