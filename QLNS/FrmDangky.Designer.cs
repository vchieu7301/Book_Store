namespace QLNS
{
    partial class FrmDangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangky));
            this.chk_dieukhoan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_passwords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_check = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lb_check2 = new System.Windows.Forms.Label();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.cbo_chucvu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.mt_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.btn_dangky2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_dieukhoan
            // 
            this.chk_dieukhoan.AutoSize = true;
            this.chk_dieukhoan.Location = new System.Drawing.Point(100, 322);
            this.chk_dieukhoan.Name = "chk_dieukhoan";
            this.chk_dieukhoan.Size = new System.Drawing.Size(406, 22);
            this.chk_dieukhoan.TabIndex = 0;
            this.chk_dieukhoan.Text = "Tôi đồng ý với Điều khoản dịch vụ và Chính sách bảo mật";
            this.chk_dieukhoan.UseVisualStyleBackColor = true;
            this.chk_dieukhoan.CheckedChanged += new System.EventHandler(this.chk_dieukhoan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(207, 84);
            this.txt_username.MaxLength = 100;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(267, 24);
            this.txt_username.TabIndex = 2;
            // 
            // btn_dangky
            // 
            this.btn_dangky.Enabled = false;
            this.btn_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.Location = new System.Drawing.Point(179, 384);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(268, 51);
            this.btn_dangky.TabIndex = 3;
            this.btn_dangky.Text = "Đăng ký ngay";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txt_passwords
            // 
            this.txt_passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwords.Location = new System.Drawing.Point(207, 128);
            this.txt_passwords.MaxLength = 100;
            this.txt_passwords.Name = "txt_passwords";
            this.txt_passwords.Size = new System.Drawing.Size(267, 24);
            this.txt_passwords.TabIndex = 2;
            this.txt_passwords.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // txt_password2
            // 
            this.txt_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password2.Location = new System.Drawing.Point(207, 176);
            this.txt_password2.MaxLength = 100;
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(267, 24);
            this.txt_password2.TabIndex = 2;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(207, 219);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(267, 24);
            this.txt_email.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(207, 279);
            this.txt_sdt.MaxLength = 10;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(267, 24);
            this.txt_sdt.TabIndex = 2;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "SĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(148, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bạn dùng email này trong trường hợp cần đổi lại mật khẩu";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(564, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 40);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Trở lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_check
            // 
            this.lb_check.AutoSize = true;
            this.lb_check.Location = new System.Drawing.Point(502, 126);
            this.lb_check.Name = "lb_check";
            this.lb_check.Size = new System.Drawing.Size(0, 18);
            this.lb_check.TabIndex = 5;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lb_check2);
            this.grb1.Controls.Add(this.lb_check);
            this.grb1.Controls.Add(this.btn_back);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.label7);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.chk_dieukhoan);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.btn_dangky);
            this.grb1.Controls.Add(this.txt_sdt);
            this.grb1.Controls.Add(this.txt_email);
            this.grb1.Controls.Add(this.txt_password2);
            this.grb1.Controls.Add(this.txt_passwords);
            this.grb1.Controls.Add(this.txt_username);
            this.grb1.Location = new System.Drawing.Point(28, 14);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(660, 487);
            this.grb1.TabIndex = 6;
            this.grb1.TabStop = false;
            this.grb1.Text = "thông tin tài khoản";
            // 
            // lb_check2
            // 
            this.lb_check2.AutoSize = true;
            this.lb_check2.Location = new System.Drawing.Point(127, 446);
            this.lb_check2.Name = "lb_check2";
            this.lb_check2.Size = new System.Drawing.Size(0, 18);
            this.lb_check2.TabIndex = 6;
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.cbo_chucvu);
            this.grb2.Controls.Add(this.label14);
            this.grb2.Controls.Add(this.btn_close);
            this.grb2.Controls.Add(this.lb);
            this.grb2.Controls.Add(this.rad_nu);
            this.grb2.Controls.Add(this.rad_Nam);
            this.grb2.Controls.Add(this.mt_ngaysinh);
            this.grb2.Controls.Add(this.btn_dangky2);
            this.grb2.Controls.Add(this.label11);
            this.grb2.Controls.Add(this.label9);
            this.grb2.Controls.Add(this.label10);
            this.grb2.Controls.Add(this.label8);
            this.grb2.Controls.Add(this.label12);
            this.grb2.Controls.Add(this.label13);
            this.grb2.Controls.Add(this.txt_diachi);
            this.grb2.Controls.Add(this.txt_makh);
            this.grb2.Controls.Add(this.txt_tenkh);
            this.grb2.Location = new System.Drawing.Point(723, 14);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(640, 485);
            this.grb2.TabIndex = 19;
            this.grb2.TabStop = false;
            this.grb2.Text = "Thông tin cá nhân";
            this.grb2.Visible = false;
            // 
            // cbo_chucvu
            // 
            this.cbo_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_chucvu.FormattingEnabled = true;
            this.cbo_chucvu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbo_chucvu.Location = new System.Drawing.Point(192, 320);
            this.cbo_chucvu.Name = "cbo_chucvu";
            this.cbo_chucvu.Size = new System.Drawing.Size(209, 26);
            this.cbo_chucvu.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Chức vụ:";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(529, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 37);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Trở lại";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(470, 199);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 18);
            this.lb.TabIndex = 17;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(264, 217);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(48, 22);
            this.rad_nu.TabIndex = 16;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Location = new System.Drawing.Point(192, 217);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(61, 22);
            this.rad_Nam.TabIndex = 16;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // mt_ngaysinh
            // 
            this.mt_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_ngaysinh.Location = new System.Drawing.Point(192, 170);
            this.mt_ngaysinh.Mask = "00/00/0000";
            this.mt_ngaysinh.Name = "mt_ngaysinh";
            this.mt_ngaysinh.Size = new System.Drawing.Size(234, 24);
            this.mt_ngaysinh.TabIndex = 15;
            this.mt_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // btn_dangky2
            // 
            this.btn_dangky2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky2.Location = new System.Drawing.Point(192, 384);
            this.btn_dangky2.Name = "btn_dangky2";
            this.btn_dangky2.Size = new System.Drawing.Size(268, 50);
            this.btn_dangky2.TabIndex = 13;
            this.btn_dangky2.Text = "Đăng ký ngay";
            this.btn_dangky2.UseVisualStyleBackColor = true;
            this.btn_dangky2.Click += new System.EventHandler(this.btn_dangky2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ngày Sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đăng ký thông tin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mã NV:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Họ tên:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(192, 260);
            this.txt_diachi.MaxLength = 100;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(316, 24);
            this.txt_diachi.TabIndex = 5;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(192, 84);
            this.txt_makh.MaxLength = 10;
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(267, 24);
            this.txt_makh.TabIndex = 8;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(192, 126);
            this.txt_tenkh.MaxLength = 100;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(267, 24);
            this.txt_tenkh.TabIndex = 8;
            this.txt_tenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenkh_KeyPress);
            // 
            // FrmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 512);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_dieukhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_passwords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_check;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.MaskedTextBox mt_ngaysinh;
        private System.Windows.Forms.Button btn_dangky2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_check2;
        private System.Windows.Forms.ComboBox cbo_chucvu;
        private System.Windows.Forms.Label label14;
    }
}