namespace QuanLyThuVien
{
    partial class FrmThongKeSach
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
            this.tinhtrangckbx = new System.Windows.Forms.CheckBox();
            this.huytkbttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soluonglb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.thongkebttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tinhtrangcbbx = new System.Windows.Forms.ComboBox();
            this.inbttn = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tinhtrangckbx
            // 
            this.tinhtrangckbx.AutoSize = true;
            this.tinhtrangckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrangckbx.Location = new System.Drawing.Point(32, 38);
            this.tinhtrangckbx.Name = "tinhtrangckbx";
            this.tinhtrangckbx.Size = new System.Drawing.Size(95, 22);
            this.tinhtrangckbx.TabIndex = 16;
            this.tinhtrangckbx.Text = "Tình trạng";
            this.tinhtrangckbx.UseVisualStyleBackColor = true;
            // 
            // huytkbttn
            // 
            this.huytkbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huytkbttn.Location = new System.Drawing.Point(305, 87);
            this.huytkbttn.Name = "huytkbttn";
            this.huytkbttn.Size = new System.Drawing.Size(84, 26);
            this.huytkbttn.TabIndex = 15;
            this.huytkbttn.Text = "Hủy";
            this.huytkbttn.UseVisualStyleBackColor = true;
            this.huytkbttn.Click += new System.EventHandler(this.huytkbttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thống kê Sách";
            // 
            // soluonglb
            // 
            this.soluonglb.AutoSize = true;
            this.soluonglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonglb.Location = new System.Drawing.Point(116, 216);
            this.soluonglb.Name = "soluonglb";
            this.soluonglb.Size = new System.Drawing.Size(16, 18);
            this.soluonglb.TabIndex = 38;
            this.soluonglb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Số lượng: ";
            // 
            // thongkebttn
            // 
            this.thongkebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongkebttn.Location = new System.Drawing.Point(215, 87);
            this.thongkebttn.Name = "thongkebttn";
            this.thongkebttn.Size = new System.Drawing.Size(84, 26);
            this.thongkebttn.TabIndex = 14;
            this.thongkebttn.Text = "Thống kê";
            this.thongkebttn.UseVisualStyleBackColor = true;
            this.thongkebttn.Click += new System.EventHandler(this.thongkebttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tinhtrangcbbx);
            this.groupBox1.Controls.Add(this.inbttn);
            this.groupBox1.Controls.Add(this.tinhtrangckbx);
            this.groupBox1.Controls.Add(this.huytkbttn);
            this.groupBox1.Controls.Add(this.thongkebttn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 123);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // tinhtrangcbbx
            // 
            this.tinhtrangcbbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrangcbbx.FormattingEnabled = true;
            this.tinhtrangcbbx.Location = new System.Drawing.Point(155, 35);
            this.tinhtrangcbbx.Name = "tinhtrangcbbx";
            this.tinhtrangcbbx.Size = new System.Drawing.Size(163, 26);
            this.tinhtrangcbbx.TabIndex = 38;
            // 
            // inbttn
            // 
            this.inbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbttn.Location = new System.Drawing.Point(459, 87);
            this.inbttn.Name = "inbttn";
            this.inbttn.Size = new System.Drawing.Size(84, 26);
            this.inbttn.TabIndex = 37;
            this.inbttn.Text = "In";
            this.inbttn.UseVisualStyleBackColor = true;
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(38, 240);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(876, 333);
            this.dgvSach.TabIndex = 35;
            // 
            // FrmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soluonglb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSach);
            this.Name = "FrmThongKeSach";
            this.Text = "FrmThongKeSach";
            this.Load += new System.EventHandler(this.FrmThongKeSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox tinhtrangckbx;
        private System.Windows.Forms.Button huytkbttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soluonglb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button thongkebttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button inbttn;
        private System.Windows.Forms.ComboBox tinhtrangcbbx;
    }
}