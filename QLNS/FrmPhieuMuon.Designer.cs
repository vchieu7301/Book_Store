namespace QLNS
{
    partial class FrmPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuMuon));
            this.btn_them = new System.Windows.Forms.Button();
            this.numb_soluong = new System.Windows.Forms.NumericUpDown();
            this.mt_datefrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sopm = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgw_phieumuon = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tg = new System.Windows.Forms.TextBox();
            this.txt_cd = new System.Windows.Forms.TextBox();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.cbo_nv = new System.Windows.Forms.ComboBox();
            this.cbo_kh = new System.Windows.Forms.ComboBox();
            this.cbo_sach = new System.Windows.Forms.ComboBox();
            this.mt_dateto = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numb_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_phieumuon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(20, 514);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 42);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // numb_soluong
            // 
            this.numb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb_soluong.Location = new System.Drawing.Point(299, 174);
            this.numb_soluong.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numb_soluong.Name = "numb_soluong";
            this.numb_soluong.Size = new System.Drawing.Size(77, 27);
            this.numb_soluong.TabIndex = 5;
            this.numb_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mt_datefrom
            // 
            this.mt_datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_datefrom.Location = new System.Drawing.Point(21, 109);
            this.mt_datefrom.Name = "mt_datefrom";
            this.mt_datefrom.Size = new System.Drawing.Size(132, 27);
            this.mt_datefrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày mượn:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(15, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(123, 30);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(261, 514);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 42);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quản Lý Phiếu Mượn";
            // 
            // txt_sopm
            // 
            this.txt_sopm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sopm.Location = new System.Drawing.Point(22, 49);
            this.txt_sopm.MaxLength = 10;
            this.txt_sopm.Name = "txt_sopm";
            this.txt_sopm.Size = new System.Drawing.Size(131, 27);
            this.txt_sopm.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(139, 514);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 42);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số lượng:";
            // 
            // dgw_phieumuon
            // 
            this.dgw_phieumuon.AllowUserToAddRows = false;
            this.dgw_phieumuon.AllowUserToDeleteRows = false;
            this.dgw_phieumuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_phieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_phieumuon.Location = new System.Drawing.Point(15, 13);
            this.dgw_phieumuon.Name = "dgw_phieumuon";
            this.dgw_phieumuon.ReadOnly = true;
            this.dgw_phieumuon.RowHeadersVisible = false;
            this.dgw_phieumuon.RowTemplate.Height = 24;
            this.dgw_phieumuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_phieumuon.Size = new System.Drawing.Size(1030, 559);
            this.dgw_phieumuon.TabIndex = 0;
            this.dgw_phieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_phieumuon_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chủ đề:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu mượn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw_phieumuon);
            this.panel2.Location = new System.Drawing.Point(428, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 591);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà xuất bản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tg);
            this.panel1.Controls.Add(this.txt_cd);
            this.panel1.Controls.Add(this.txt_nxb);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.cbo_nv);
            this.panel1.Controls.Add(this.cbo_kh);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.cbo_sach);
            this.panel1.Controls.Add(this.numb_soluong);
            this.panel1.Controls.Add(this.mt_dateto);
            this.panel1.Controls.Add(this.mt_datefrom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_sopm);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 591);
            this.panel1.TabIndex = 5;
            // 
            // txt_tg
            // 
            this.txt_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tg.Location = new System.Drawing.Point(22, 365);
            this.txt_tg.Name = "txt_tg";
            this.txt_tg.ReadOnly = true;
            this.txt_tg.Size = new System.Drawing.Size(277, 27);
            this.txt_tg.TabIndex = 10;
            // 
            // txt_cd
            // 
            this.txt_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cd.Location = new System.Drawing.Point(22, 299);
            this.txt_cd.Name = "txt_cd";
            this.txt_cd.ReadOnly = true;
            this.txt_cd.Size = new System.Drawing.Size(277, 27);
            this.txt_cd.TabIndex = 10;
            // 
            // txt_nxb
            // 
            this.txt_nxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nxb.Location = new System.Drawing.Point(22, 234);
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.ReadOnly = true;
            this.txt_nxb.Size = new System.Drawing.Size(277, 27);
            this.txt_nxb.TabIndex = 10;
            // 
            // cbo_nv
            // 
            this.cbo_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nv.FormattingEnabled = true;
            this.cbo_nv.Location = new System.Drawing.Point(217, 450);
            this.cbo_nv.Name = "cbo_nv";
            this.cbo_nv.Size = new System.Drawing.Size(153, 28);
            this.cbo_nv.TabIndex = 7;
            // 
            // cbo_kh
            // 
            this.cbo_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_kh.FormattingEnabled = true;
            this.cbo_kh.Location = new System.Drawing.Point(19, 450);
            this.cbo_kh.Name = "cbo_kh";
            this.cbo_kh.Size = new System.Drawing.Size(152, 28);
            this.cbo_kh.TabIndex = 7;
            // 
            // cbo_sach
            // 
            this.cbo_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sach.FormattingEnabled = true;
            this.cbo_sach.Location = new System.Drawing.Point(22, 174);
            this.cbo_sach.Name = "cbo_sach";
            this.cbo_sach.Size = new System.Drawing.Size(252, 28);
            this.cbo_sach.TabIndex = 6;
            this.cbo_sach.SelectedIndexChanged += new System.EventHandler(this.cbo_sach_SelectedIndexChanged);
            // 
            // mt_dateto
            // 
            this.mt_dateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_dateto.Location = new System.Drawing.Point(217, 109);
            this.mt_dateto.Name = "mt_dateto";
            this.mt_dateto.Size = new System.Drawing.Size(123, 27);
            this.mt_dateto.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày trả :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(213, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nhân viên phụ trách:";
            // 
            // FrmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 676);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Mượn";
            ((System.ComponentModel.ISupportInitialize)(this.numb_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_phieumuon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.NumericUpDown numb_soluong;
        private System.Windows.Forms.DateTimePicker mt_datefrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sopm;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgw_phieumuon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker mt_dateto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_sach;
        private System.Windows.Forms.ComboBox cbo_nv;
        private System.Windows.Forms.ComboBox cbo_kh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tg;
        private System.Windows.Forms.TextBox txt_cd;
        private System.Windows.Forms.TextBox txt_nxb;
    }
}