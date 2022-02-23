namespace QLNS
{
    partial class FrmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSach));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.dgw_sach = new System.Windows.Forms.DataGridView();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.cbo_tg = new System.Windows.Forms.ComboBox();
            this.cbo_nxb = new System.Windows.Forms.ComboBox();
            this.cbo_cd = new System.Windows.Forms.ComboBox();
            this.numb_gia = new System.Windows.Forms.NumericUpDown();
            this.numb_sl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dulieusach = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sach)).BeginInit();
            this.grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_sl)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(18, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 34);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(138, 565);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(105, 40);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(261, 566);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(105, 41);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(16, 566);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(105, 39);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.dgw_sach);
            this.grb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(414, 81);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(1131, 691);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin sách";
            // 
            // dgw_sach
            // 
            this.dgw_sach.AllowUserToAddRows = false;
            this.dgw_sach.AllowUserToDeleteRows = false;
            this.dgw_sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_sach.Location = new System.Drawing.Point(17, 29);
            this.dgw_sach.Name = "dgw_sach";
            this.dgw_sach.ReadOnly = true;
            this.dgw_sach.RowHeadersVisible = false;
            this.dgw_sach.RowTemplate.Height = 24;
            this.dgw_sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_sach.Size = new System.Drawing.Size(1098, 641);
            this.dgw_sach.TabIndex = 8;
            this.dgw_sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_sach_CellContentClick);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.btn_dulieusach);
            this.grb2.Controls.Add(this.cbo_tg);
            this.grb2.Controls.Add(this.btn_xoa);
            this.grb2.Controls.Add(this.btn_sua);
            this.grb2.Controls.Add(this.cbo_nxb);
            this.grb2.Controls.Add(this.cbo_cd);
            this.grb2.Controls.Add(this.numb_gia);
            this.grb2.Controls.Add(this.numb_sl);
            this.grb2.Controls.Add(this.btn_them);
            this.grb2.Controls.Add(this.label7);
            this.grb2.Controls.Add(this.label6);
            this.grb2.Controls.Add(this.label5);
            this.grb2.Controls.Add(this.label4);
            this.grb2.Controls.Add(this.label3);
            this.grb2.Controls.Add(this.txt_tensach);
            this.grb2.Controls.Add(this.label2);
            this.grb2.Controls.Add(this.txt_masach);
            this.grb2.Controls.Add(this.label1);
            this.grb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2.Location = new System.Drawing.Point(18, 81);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(390, 670);
            this.grb2.TabIndex = 7;
            this.grb2.TabStop = false;
            this.grb2.Text = "Thêm sách mới";
            // 
            // cbo_tg
            // 
            this.cbo_tg.FormattingEnabled = true;
            this.cbo_tg.Location = new System.Drawing.Point(29, 336);
            this.cbo_tg.Name = "cbo_tg";
            this.cbo_tg.Size = new System.Drawing.Size(275, 28);
            this.cbo_tg.TabIndex = 3;
            // 
            // cbo_nxb
            // 
            this.cbo_nxb.FormattingEnabled = true;
            this.cbo_nxb.Location = new System.Drawing.Point(24, 259);
            this.cbo_nxb.Name = "cbo_nxb";
            this.cbo_nxb.Size = new System.Drawing.Size(280, 28);
            this.cbo_nxb.TabIndex = 3;
            // 
            // cbo_cd
            // 
            this.cbo_cd.FormattingEnabled = true;
            this.cbo_cd.Location = new System.Drawing.Point(24, 197);
            this.cbo_cd.Name = "cbo_cd";
            this.cbo_cd.Size = new System.Drawing.Size(280, 28);
            this.cbo_cd.TabIndex = 3;
            // 
            // numb_gia
            // 
            this.numb_gia.Location = new System.Drawing.Point(29, 479);
            this.numb_gia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numb_gia.Name = "numb_gia";
            this.numb_gia.Size = new System.Drawing.Size(185, 27);
            this.numb_gia.TabIndex = 2;
            this.numb_gia.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numb_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numb_gia_KeyPress);
            // 
            // numb_sl
            // 
            this.numb_sl.Location = new System.Drawing.Point(29, 403);
            this.numb_sl.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numb_sl.Name = "numb_sl";
            this.numb_sl.Size = new System.Drawing.Size(185, 27);
            this.numb_sl.TabIndex = 2;
            this.numb_sl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tác Giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "NXB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chủ đề:";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(24, 119);
            this.txt_tensach.MaxLength = 50;
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(280, 27);
            this.txt_tensach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách:";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(24, 57);
            this.txt_masach.MaxLength = 10;
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(151, 27);
            this.txt_masach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(715, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quản Lý Sách";
            // 
            // btn_dulieusach
            // 
            this.btn_dulieusach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dulieusach.Location = new System.Drawing.Point(321, 195);
            this.btn_dulieusach.Name = "btn_dulieusach";
            this.btn_dulieusach.Size = new System.Drawing.Size(45, 30);
            this.btn_dulieusach.TabIndex = 4;
            this.btn_dulieusach.Text = "...";
            this.btn_dulieusach.UseVisualStyleBackColor = true;
            this.btn_dulieusach.Click += new System.EventHandler(this.btn_dulieusach_Click);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1565, 784);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sach)).EndInit();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_sl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_sach;
        private System.Windows.Forms.ComboBox cbo_tg;
        private System.Windows.Forms.ComboBox cbo_nxb;
        private System.Windows.Forms.ComboBox cbo_cd;
        private System.Windows.Forms.NumericUpDown numb_gia;
        private System.Windows.Forms.NumericUpDown numb_sl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dulieusach;
    }
}