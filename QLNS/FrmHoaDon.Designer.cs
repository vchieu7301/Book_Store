namespace QLNS
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tg = new System.Windows.Forms.TextBox();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.txt_cd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.cbo_kh = new System.Windows.Forms.ComboBox();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.cbo_nv = new System.Windows.Forms.ComboBox();
            this.cbo_sach = new System.Windows.Forms.ComboBox();
            this.numb_gia = new System.Windows.Forms.NumericUpDown();
            this.numb_sl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_sohd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_hoadon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_hoadon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hóa Đơn Bán Sách";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 29);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Trờ về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tg);
            this.groupBox1.Controls.Add(this.txt_nxb);
            this.groupBox1.Controls.Add(this.txt_cd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.cbo_kh);
            this.groupBox1.Controls.Add(this.btn_Thêm);
            this.groupBox1.Controls.Add(this.cbo_nv);
            this.groupBox1.Controls.Add(this.cbo_sach);
            this.groupBox1.Controls.Add(this.numb_gia);
            this.groupBox1.Controls.Add(this.numb_sl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mt_date);
            this.groupBox1.Controls.Add(this.txt_sohd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 634);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txt_tg
            // 
            this.txt_tg.Location = new System.Drawing.Point(12, 377);
            this.txt_tg.Name = "txt_tg";
            this.txt_tg.ReadOnly = true;
            this.txt_tg.Size = new System.Drawing.Size(256, 27);
            this.txt_tg.TabIndex = 18;
            // 
            // txt_nxb
            // 
            this.txt_nxb.Location = new System.Drawing.Point(13, 313);
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.ReadOnly = true;
            this.txt_nxb.Size = new System.Drawing.Size(256, 27);
            this.txt_nxb.TabIndex = 18;
            // 
            // txt_cd
            // 
            this.txt_cd.Location = new System.Drawing.Point(12, 247);
            this.txt_cd.Name = "txt_cd";
            this.txt_cd.ReadOnly = true;
            this.txt_cd.Size = new System.Drawing.Size(256, 27);
            this.txt_cd.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tổng tiền:";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(16, 511);
            this.txt_tongtien.MaxLength = 1000000000;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(309, 27);
            this.txt_tongtien.TabIndex = 16;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(241, 559);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 44);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(134, 559);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 44);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // cbo_kh
            // 
            this.cbo_kh.FormattingEnabled = true;
            this.cbo_kh.Location = new System.Drawing.Point(15, 447);
            this.cbo_kh.Name = "cbo_kh";
            this.cbo_kh.Size = new System.Drawing.Size(137, 28);
            this.cbo_kh.TabIndex = 15;
            this.cbo_kh.Text = "Khách hàng";
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thêm.Location = new System.Drawing.Point(16, 559);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(84, 44);
            this.btn_Thêm.TabIndex = 2;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // cbo_nv
            // 
            this.cbo_nv.FormattingEnabled = true;
            this.cbo_nv.Location = new System.Drawing.Point(181, 447);
            this.cbo_nv.Name = "cbo_nv";
            this.cbo_nv.Size = new System.Drawing.Size(144, 28);
            this.cbo_nv.TabIndex = 15;
            this.cbo_nv.Text = "Nhân viên";
            // 
            // cbo_sach
            // 
            this.cbo_sach.FormattingEnabled = true;
            this.cbo_sach.Location = new System.Drawing.Point(13, 111);
            this.cbo_sach.Name = "cbo_sach";
            this.cbo_sach.Size = new System.Drawing.Size(312, 28);
            this.cbo_sach.TabIndex = 15;
            this.cbo_sach.Text = "Sách";
            this.cbo_sach.SelectedIndexChanged += new System.EventHandler(this.cbo_sach_SelectedIndexChanged);
            // 
            // numb_gia
            // 
            this.numb_gia.Location = new System.Drawing.Point(184, 180);
            this.numb_gia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numb_gia.Name = "numb_gia";
            this.numb_gia.Size = new System.Drawing.Size(124, 27);
            this.numb_gia.TabIndex = 11;
            this.numb_gia.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // numb_sl
            // 
            this.numb_sl.Location = new System.Drawing.Point(12, 180);
            this.numb_sl.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numb_sl.Name = "numb_sl";
            this.numb_sl.Size = new System.Drawing.Size(125, 27);
            this.numb_sl.TabIndex = 12;
            this.numb_sl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numb_sl.ValueChanged += new System.EventHandler(this.numb_sl_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nhân viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chủ đề:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "NXB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá:";
            // 
            // mt_date
            // 
            this.mt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mt_date.Location = new System.Drawing.Point(184, 50);
            this.mt_date.Name = "mt_date";
            this.mt_date.Size = new System.Drawing.Size(141, 27);
            this.mt_date.TabIndex = 5;
            // 
            // txt_sohd
            // 
            this.txt_sohd.Location = new System.Drawing.Point(13, 50);
            this.txt_sohd.MaxLength = 10;
            this.txt_sohd.Name = "txt_sohd";
            this.txt_sohd.Size = new System.Drawing.Size(139, 27);
            this.txt_sohd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // dgw_hoadon
            // 
            this.dgw_hoadon.AllowUserToAddRows = false;
            this.dgw_hoadon.AllowUserToDeleteRows = false;
            this.dgw_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_hoadon.Location = new System.Drawing.Point(20, 20);
            this.dgw_hoadon.Name = "dgw_hoadon";
            this.dgw_hoadon.ReadOnly = true;
            this.dgw_hoadon.RowHeadersVisible = false;
            this.dgw_hoadon.RowTemplate.Height = 24;
            this.dgw_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_hoadon.Size = new System.Drawing.Size(1082, 576);
            this.dgw_hoadon.TabIndex = 1;
            this.dgw_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_hoadon_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgw_hoadon);
            this.panel1.Location = new System.Drawing.Point(373, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 626);
            this.panel1.TabIndex = 9;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_hoadon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.DataGridView dgw_hoadon;
        private System.Windows.Forms.DateTimePicker mt_date;
        private System.Windows.Forms.TextBox txt_sohd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_kh;
        private System.Windows.Forms.ComboBox cbo_nv;
        private System.Windows.Forms.NumericUpDown numb_gia;
        private System.Windows.Forms.NumericUpDown numb_sl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_sach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_cd;
        private System.Windows.Forms.TextBox txt_tg;
        private System.Windows.Forms.TextBox txt_nxb;
    }
}