namespace QLNS
{
    partial class FrmDuLieuSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuLieuSach));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_themcd = new System.Windows.Forms.Button();
            this.txt_macd = new System.Windows.Forms.TextBox();
            this.grb_cd = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_cd = new System.Windows.Forms.DataGridView();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tencd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suacd = new System.Windows.Forms.Button();
            this.btn_xoacd = new System.Windows.Forms.Button();
            this.grb_tg = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_tg = new System.Windows.Forms.DataGridView();
            this.txt_diachitg = new System.Windows.Forms.TextBox();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_matg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_suatg = new System.Windows.Forms.Button();
            this.btn_xoatg = new System.Windows.Forms.Button();
            this.btn_themtg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grb_nxb = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgv_nxb = new System.Windows.Forms.DataGridView();
            this.txt_diachinxb = new System.Windows.Forms.TextBox();
            this.txt_tennxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_manxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_suanxb = new System.Windows.Forms.Button();
            this.btn_xoanxb = new System.Windows.Forms.Button();
            this.btn_themnxb = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.grb_cd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).BeginInit();
            this.grb_tg.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tg)).BeginInit();
            this.grb_nxb.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ Liệu Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chủ Đề:";
            // 
            // btn_themcd
            // 
            this.btn_themcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themcd.Location = new System.Drawing.Point(36, 230);
            this.btn_themcd.Name = "btn_themcd";
            this.btn_themcd.Size = new System.Drawing.Size(96, 48);
            this.btn_themcd.TabIndex = 2;
            this.btn_themcd.Text = "Thêm";
            this.btn_themcd.UseVisualStyleBackColor = true;
            this.btn_themcd.Click += new System.EventHandler(this.btn_themcd_Click);
            // 
            // txt_macd
            // 
            this.txt_macd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_macd.Location = new System.Drawing.Point(131, 57);
            this.txt_macd.MaxLength = 10;
            this.txt_macd.Name = "txt_macd";
            this.txt_macd.Size = new System.Drawing.Size(216, 27);
            this.txt_macd.TabIndex = 3;
            // 
            // grb_cd
            // 
            this.grb_cd.Controls.Add(this.groupBox2);
            this.grb_cd.Controls.Add(this.txt_ghichu);
            this.grb_cd.Controls.Add(this.txt_tencd);
            this.grb_cd.Controls.Add(this.label4);
            this.grb_cd.Controls.Add(this.txt_macd);
            this.grb_cd.Controls.Add(this.label3);
            this.grb_cd.Controls.Add(this.btn_suacd);
            this.grb_cd.Controls.Add(this.btn_xoacd);
            this.grb_cd.Controls.Add(this.btn_themcd);
            this.grb_cd.Controls.Add(this.label2);
            this.grb_cd.Location = new System.Drawing.Point(12, 61);
            this.grb_cd.Name = "grb_cd";
            this.grb_cd.Size = new System.Drawing.Size(410, 678);
            this.grb_cd.TabIndex = 4;
            this.grb_cd.TabStop = false;
            this.grb_cd.Text = "Thông tin chủ đề";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_cd);
            this.groupBox2.Location = new System.Drawing.Point(10, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 369);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chủ đề";
            // 
            // dgv_cd
            // 
            this.dgv_cd.AllowUserToAddRows = false;
            this.dgv_cd.AllowUserToDeleteRows = false;
            this.dgv_cd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cd.Location = new System.Drawing.Point(3, 18);
            this.dgv_cd.Name = "dgv_cd";
            this.dgv_cd.ReadOnly = true;
            this.dgv_cd.RowHeadersVisible = false;
            this.dgv_cd.RowTemplate.Height = 24;
            this.dgv_cd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cd.Size = new System.Drawing.Size(388, 348);
            this.dgv_cd.TabIndex = 0;
            this.dgv_cd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cd_CellContentClick);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(131, 171);
            this.txt_ghichu.MaxLength = 100;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(216, 27);
            this.txt_ghichu.TabIndex = 3;
            this.txt_ghichu.Text = "Không";
            // 
            // txt_tencd
            // 
            this.txt_tencd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tencd.Location = new System.Drawing.Point(131, 113);
            this.txt_tencd.MaxLength = 100;
            this.txt_tencd.Name = "txt_tencd";
            this.txt_tencd.Size = new System.Drawing.Size(216, 27);
            this.txt_tencd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi Chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Chủ Đề:";
            // 
            // btn_suacd
            // 
            this.btn_suacd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suacd.Location = new System.Drawing.Point(281, 230);
            this.btn_suacd.Name = "btn_suacd";
            this.btn_suacd.Size = new System.Drawing.Size(96, 48);
            this.btn_suacd.TabIndex = 2;
            this.btn_suacd.Text = "Sửa";
            this.btn_suacd.UseVisualStyleBackColor = true;
            this.btn_suacd.Click += new System.EventHandler(this.btn_suacd_Click);
            // 
            // btn_xoacd
            // 
            this.btn_xoacd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoacd.Location = new System.Drawing.Point(160, 230);
            this.btn_xoacd.Name = "btn_xoacd";
            this.btn_xoacd.Size = new System.Drawing.Size(96, 48);
            this.btn_xoacd.TabIndex = 2;
            this.btn_xoacd.Text = "Xóa ";
            this.btn_xoacd.UseVisualStyleBackColor = true;
            this.btn_xoacd.Click += new System.EventHandler(this.btn_xoacd_Click);
            // 
            // grb_tg
            // 
            this.grb_tg.Controls.Add(this.groupBox4);
            this.grb_tg.Controls.Add(this.txt_diachitg);
            this.grb_tg.Controls.Add(this.txt_tentg);
            this.grb_tg.Controls.Add(this.label5);
            this.grb_tg.Controls.Add(this.txt_matg);
            this.grb_tg.Controls.Add(this.label6);
            this.grb_tg.Controls.Add(this.btn_suatg);
            this.grb_tg.Controls.Add(this.btn_xoatg);
            this.grb_tg.Controls.Add(this.btn_themtg);
            this.grb_tg.Controls.Add(this.label7);
            this.grb_tg.Location = new System.Drawing.Point(439, 62);
            this.grb_tg.Name = "grb_tg";
            this.grb_tg.Size = new System.Drawing.Size(410, 678);
            this.grb_tg.TabIndex = 5;
            this.grb_tg.TabStop = false;
            this.grb_tg.Text = "Thông tin tác giả";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_tg);
            this.groupBox4.Location = new System.Drawing.Point(10, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 369);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tác giả";
            // 
            // dgv_tg
            // 
            this.dgv_tg.AllowUserToAddRows = false;
            this.dgv_tg.AllowUserToDeleteRows = false;
            this.dgv_tg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tg.Location = new System.Drawing.Point(3, 18);
            this.dgv_tg.Name = "dgv_tg";
            this.dgv_tg.ReadOnly = true;
            this.dgv_tg.RowHeadersVisible = false;
            this.dgv_tg.RowTemplate.Height = 24;
            this.dgv_tg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tg.Size = new System.Drawing.Size(388, 348);
            this.dgv_tg.TabIndex = 1;
            this.dgv_tg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tg_CellContentClick);
            // 
            // txt_diachitg
            // 
            this.txt_diachitg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachitg.Location = new System.Drawing.Point(131, 171);
            this.txt_diachitg.MaxLength = 100;
            this.txt_diachitg.Name = "txt_diachitg";
            this.txt_diachitg.Size = new System.Drawing.Size(216, 27);
            this.txt_diachitg.TabIndex = 3;
            this.txt_diachitg.Text = "Tp.HCM";
            // 
            // txt_tentg
            // 
            this.txt_tentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentg.Location = new System.Drawing.Point(131, 113);
            this.txt_tentg.MaxLength = 100;
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(216, 27);
            this.txt_tentg.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txt_matg
            // 
            this.txt_matg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matg.Location = new System.Drawing.Point(131, 57);
            this.txt_matg.MaxLength = 10;
            this.txt_matg.Name = "txt_matg";
            this.txt_matg.Size = new System.Drawing.Size(216, 27);
            this.txt_matg.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Tác Giả:";
            // 
            // btn_suatg
            // 
            this.btn_suatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suatg.Location = new System.Drawing.Point(281, 230);
            this.btn_suatg.Name = "btn_suatg";
            this.btn_suatg.Size = new System.Drawing.Size(96, 48);
            this.btn_suatg.TabIndex = 2;
            this.btn_suatg.Text = "Sửa";
            this.btn_suatg.UseVisualStyleBackColor = true;
            this.btn_suatg.Click += new System.EventHandler(this.btn_suatg_Click);
            // 
            // btn_xoatg
            // 
            this.btn_xoatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoatg.Location = new System.Drawing.Point(160, 230);
            this.btn_xoatg.Name = "btn_xoatg";
            this.btn_xoatg.Size = new System.Drawing.Size(96, 48);
            this.btn_xoatg.TabIndex = 2;
            this.btn_xoatg.Text = "Xóa ";
            this.btn_xoatg.UseVisualStyleBackColor = true;
            this.btn_xoatg.Click += new System.EventHandler(this.btn_xoatg_Click);
            // 
            // btn_themtg
            // 
            this.btn_themtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themtg.Location = new System.Drawing.Point(36, 230);
            this.btn_themtg.Name = "btn_themtg";
            this.btn_themtg.Size = new System.Drawing.Size(96, 48);
            this.btn_themtg.TabIndex = 2;
            this.btn_themtg.Text = "Thêm";
            this.btn_themtg.UseVisualStyleBackColor = true;
            this.btn_themtg.Click += new System.EventHandler(this.btn_themtg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Tác Giả:";
            // 
            // grb_nxb
            // 
            this.grb_nxb.Controls.Add(this.groupBox6);
            this.grb_nxb.Controls.Add(this.txt_diachinxb);
            this.grb_nxb.Controls.Add(this.txt_tennxb);
            this.grb_nxb.Controls.Add(this.label8);
            this.grb_nxb.Controls.Add(this.txt_manxb);
            this.grb_nxb.Controls.Add(this.label9);
            this.grb_nxb.Controls.Add(this.btn_suanxb);
            this.grb_nxb.Controls.Add(this.btn_xoanxb);
            this.grb_nxb.Controls.Add(this.btn_themnxb);
            this.grb_nxb.Controls.Add(this.label10);
            this.grb_nxb.Location = new System.Drawing.Point(867, 62);
            this.grb_nxb.Name = "grb_nxb";
            this.grb_nxb.Size = new System.Drawing.Size(410, 678);
            this.grb_nxb.TabIndex = 6;
            this.grb_nxb.TabStop = false;
            this.grb_nxb.Text = "Thông tin NXB";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgv_nxb);
            this.groupBox6.Location = new System.Drawing.Point(10, 303);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 369);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "NXB";
            // 
            // dgv_nxb
            // 
            this.dgv_nxb.AllowUserToAddRows = false;
            this.dgv_nxb.AllowUserToDeleteRows = false;
            this.dgv_nxb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nxb.Location = new System.Drawing.Point(3, 18);
            this.dgv_nxb.Name = "dgv_nxb";
            this.dgv_nxb.ReadOnly = true;
            this.dgv_nxb.RowHeadersVisible = false;
            this.dgv_nxb.RowTemplate.Height = 24;
            this.dgv_nxb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nxb.Size = new System.Drawing.Size(388, 348);
            this.dgv_nxb.TabIndex = 1;
            this.dgv_nxb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nxb_CellContentClick);
            // 
            // txt_diachinxb
            // 
            this.txt_diachinxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachinxb.Location = new System.Drawing.Point(131, 171);
            this.txt_diachinxb.MaxLength = 100;
            this.txt_diachinxb.Name = "txt_diachinxb";
            this.txt_diachinxb.Size = new System.Drawing.Size(216, 27);
            this.txt_diachinxb.TabIndex = 3;
            this.txt_diachinxb.Text = "Tp.HCM";
            // 
            // txt_tennxb
            // 
            this.txt_tennxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennxb.Location = new System.Drawing.Point(131, 113);
            this.txt_tennxb.MaxLength = 100;
            this.txt_tennxb.Name = "txt_tennxb";
            this.txt_tennxb.Size = new System.Drawing.Size(216, 27);
            this.txt_tennxb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Địa Chỉ:";
            // 
            // txt_manxb
            // 
            this.txt_manxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manxb.Location = new System.Drawing.Point(131, 57);
            this.txt_manxb.MaxLength = 10;
            this.txt_manxb.Name = "txt_manxb";
            this.txt_manxb.Size = new System.Drawing.Size(216, 27);
            this.txt_manxb.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên NXB:";
            // 
            // btn_suanxb
            // 
            this.btn_suanxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suanxb.Location = new System.Drawing.Point(281, 230);
            this.btn_suanxb.Name = "btn_suanxb";
            this.btn_suanxb.Size = new System.Drawing.Size(96, 48);
            this.btn_suanxb.TabIndex = 2;
            this.btn_suanxb.Text = "Sửa";
            this.btn_suanxb.UseVisualStyleBackColor = true;
            this.btn_suanxb.Click += new System.EventHandler(this.btn_suanxb_Click);
            // 
            // btn_xoanxb
            // 
            this.btn_xoanxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanxb.Location = new System.Drawing.Point(160, 230);
            this.btn_xoanxb.Name = "btn_xoanxb";
            this.btn_xoanxb.Size = new System.Drawing.Size(96, 48);
            this.btn_xoanxb.TabIndex = 2;
            this.btn_xoanxb.Text = "Xóa ";
            this.btn_xoanxb.UseVisualStyleBackColor = true;
            this.btn_xoanxb.Click += new System.EventHandler(this.btn_xoanxb_Click);
            // 
            // btn_themnxb
            // 
            this.btn_themnxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnxb.Location = new System.Drawing.Point(36, 230);
            this.btn_themnxb.Name = "btn_themnxb";
            this.btn_themnxb.Size = new System.Drawing.Size(96, 48);
            this.btn_themnxb.TabIndex = 2;
            this.btn_themnxb.Text = "Thêm";
            this.btn_themnxb.UseVisualStyleBackColor = true;
            this.btn_themnxb.Click += new System.EventHandler(this.btn_themnxb_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã NXB:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 32);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Trở Lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FrmDuLieuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 762);
            this.Controls.Add(this.grb_nxb);
            this.Controls.Add(this.grb_tg);
            this.Controls.Add(this.grb_cd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDuLieuSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dữ Liệu Sách";
            this.grb_cd.ResumeLayout(false);
            this.grb_cd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).EndInit();
            this.grb_tg.ResumeLayout(false);
            this.grb_tg.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tg)).EndInit();
            this.grb_nxb.ResumeLayout(false);
            this.grb_nxb.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_themcd;
        private System.Windows.Forms.TextBox txt_macd;
        private System.Windows.Forms.GroupBox grb_cd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_cd;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tencd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suacd;
        private System.Windows.Forms.Button btn_xoacd;
        private System.Windows.Forms.GroupBox grb_tg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_diachitg;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_matg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_suatg;
        private System.Windows.Forms.Button btn_xoatg;
        private System.Windows.Forms.Button btn_themtg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grb_nxb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_diachinxb;
        private System.Windows.Forms.TextBox txt_tennxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_manxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_suanxb;
        private System.Windows.Forms.Button btn_xoanxb;
        private System.Windows.Forms.Button btn_themnxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_tg;
        private System.Windows.Forms.DataGridView dgv_nxb;
        private System.Windows.Forms.Button btn_back;
    }
}