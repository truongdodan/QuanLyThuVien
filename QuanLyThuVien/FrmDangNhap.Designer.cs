namespace QuanLyThuVien
{
    partial class FrmDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dangnhapbttn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.taikhoantxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matkhautxtbx = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.peakpx;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dangnhapbttn
            // 
            this.dangnhapbttn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dangnhapbttn.Location = new System.Drawing.Point(250, 225);
            this.dangnhapbttn.Name = "dangnhapbttn";
            this.dangnhapbttn.Size = new System.Drawing.Size(90, 27);
            this.dangnhapbttn.TabIndex = 3;
            this.dangnhapbttn.Text = "Đăng nhập";
            this.dangnhapbttn.UseVisualStyleBackColor = false;
            this.dangnhapbttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "Đăng nhập";
            // 
            // taikhoantxtbx
            // 
            this.taikhoantxtbx.Location = new System.Drawing.Point(250, 129);
            this.taikhoantxtbx.Name = "taikhoantxtbx";
            this.taikhoantxtbx.Size = new System.Drawing.Size(153, 22);
            this.taikhoantxtbx.TabIndex = 1;
            this.taikhoantxtbx.Click += new System.EventHandler(this.taikhoantxtbx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tài Khoản:";
            // 
            // matkhautxtbx
            // 
            this.matkhautxtbx.Location = new System.Drawing.Point(250, 164);
            this.matkhautxtbx.Name = "matkhautxtbx";
            this.matkhautxtbx.PasswordChar = '*';
            this.matkhautxtbx.Size = new System.Drawing.Size(153, 22);
            this.matkhautxtbx.TabIndex = 2;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this.matkhautxtbx);
            this.Controls.Add(this.dangnhapbttn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.taikhoantxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dangnhapbttn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taikhoantxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox matkhautxtbx;
    }
}