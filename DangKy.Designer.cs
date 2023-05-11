namespace WindowsFormsApp2
{
    partial class DangKy
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
            this.lbtentaikhoan = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbrematkhau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_NLMK = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtentaikhoan
            // 
            this.lbtentaikhoan.AutoSize = true;
            this.lbtentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtentaikhoan.Location = new System.Drawing.Point(12, 180);
            this.lbtentaikhoan.Name = "lbtentaikhoan";
            this.lbtentaikhoan.Size = new System.Drawing.Size(112, 16);
            this.lbtentaikhoan.TabIndex = 1;
            this.lbtentaikhoan.Text = "Tên Tài Khoản:";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(12, 228);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(74, 16);
            this.lbmatkhau.TabIndex = 2;
            this.lbmatkhau.Text = "Mật Khẩu:";
            this.lbmatkhau.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbrematkhau
            // 
            this.lbrematkhau.AutoSize = true;
            this.lbrematkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrematkhau.Location = new System.Drawing.Point(12, 273);
            this.lbrematkhau.Name = "lbrematkhau";
            this.lbrematkhau.Size = new System.Drawing.Size(140, 16);
            this.lbrematkhau.TabIndex = 3;
            this.lbrematkhau.Text = "Nhập Lại Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.SystemColors.Desktop;
            this.btndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangky.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndangky.Location = new System.Drawing.Point(200, 369);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(85, 26);
            this.btndangky.TabIndex = 5;
            this.btndangky.Text = "Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(161, 177);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(225, 22);
            this.textBox_TenTaiKhoan.TabIndex = 6;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MatKhau.Location = new System.Drawing.Point(161, 222);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(225, 22);
            this.textBox_MatKhau.TabIndex = 7;
            // 
            // textBox_NLMK
            // 
            this.textBox_NLMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NLMK.Location = new System.Drawing.Point(162, 267);
            this.textBox_NLMK.Name = "textBox_NLMK";
            this.textBox_NLMK.Size = new System.Drawing.Size(225, 22);
            this.textBox_NLMK.TabIndex = 8;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Location = new System.Drawing.Point(162, 316);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(224, 22);
            this.textBox_Email.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._334088754_2286991164806648_1712865740281399557_n;
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 423);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_NLMK);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbrematkhau);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbtentaikhoan;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbrematkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_NLMK;
        private System.Windows.Forms.TextBox textBox_Email;
    }
}