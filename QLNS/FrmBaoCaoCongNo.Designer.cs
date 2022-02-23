namespace QLNS
{
    partial class FrmBaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoCongNo));
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_baocaocongno = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rab_tenkh = new System.Windows.Forms.RadioButton();
            this.rad_email = new System.Windows.Forms.RadioButton();
            this.rad_diachi = new System.Windows.Forms.RadioButton();
            this.rad_sdt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_baocaocongno)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Công Nợ";
            // 
            // dgw_baocaocongno
            // 
            this.dgw_baocaocongno.AllowUserToAddRows = false;
            this.dgw_baocaocongno.AllowUserToDeleteRows = false;
            this.dgw_baocaocongno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_baocaocongno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_baocaocongno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_baocaocongno.Location = new System.Drawing.Point(0, 0);
            this.dgw_baocaocongno.Name = "dgw_baocaocongno";
            this.dgw_baocaocongno.ReadOnly = true;
            this.dgw_baocaocongno.RowHeadersVisible = false;
            this.dgw_baocaocongno.RowTemplate.Height = 24;
            this.dgw_baocaocongno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_baocaocongno.Size = new System.Drawing.Size(1007, 321);
            this.dgw_baocaocongno.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgw_baocaocongno);
            this.panel1.Location = new System.Drawing.Point(12, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 321);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rab_tenkh);
            this.panel2.Controls.Add(this.rad_email);
            this.panel2.Controls.Add(this.rad_diachi);
            this.panel2.Controls.Add(this.rad_sdt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.txt_tim);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 146);
            this.panel2.TabIndex = 3;
            // 
            // rab_tenkh
            // 
            this.rab_tenkh.AutoSize = true;
            this.rab_tenkh.Checked = true;
            this.rab_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rab_tenkh.Location = new System.Drawing.Point(115, 98);
            this.rab_tenkh.Name = "rab_tenkh";
            this.rab_tenkh.Size = new System.Drawing.Size(125, 22);
            this.rab_tenkh.TabIndex = 5;
            this.rab_tenkh.TabStop = true;
            this.rab_tenkh.Text = "Tên Nhân Viên";
            this.rab_tenkh.UseVisualStyleBackColor = true;
            // 
            // rad_email
            // 
            this.rad_email.AutoSize = true;
            this.rad_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_email.Location = new System.Drawing.Point(650, 98);
            this.rad_email.Name = "rad_email";
            this.rad_email.Size = new System.Drawing.Size(66, 22);
            this.rad_email.TabIndex = 5;
            this.rad_email.Text = "Email";
            this.rad_email.UseVisualStyleBackColor = true;
            // 
            // rad_diachi
            // 
            this.rad_diachi.AutoSize = true;
            this.rad_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_diachi.Location = new System.Drawing.Point(499, 98);
            this.rad_diachi.Name = "rad_diachi";
            this.rad_diachi.Size = new System.Drawing.Size(74, 22);
            this.rad_diachi.TabIndex = 5;
            this.rad_diachi.Text = "Địa chỉ";
            this.rad_diachi.UseVisualStyleBackColor = true;
            // 
            // rad_sdt
            // 
            this.rad_sdt.AutoSize = true;
            this.rad_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_sdt.Location = new System.Drawing.Point(305, 98);
            this.rad_sdt.Name = "rad_sdt";
            this.rad_sdt.Size = new System.Drawing.Size(115, 22);
            this.rad_sdt.TabIndex = 5;
            this.rad_sdt.Text = "Số điện thoại";
            this.rad_sdt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phương thức tìm kiếm:";
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(842, 47);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(154, 43);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm Kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(85, 56);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(712, 24);
            this.txt_tim.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(29, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(119, 43);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Trở lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FrmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaoCaoCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo công nợ";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_baocaocongno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_baocaocongno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rab_tenkh;
        private System.Windows.Forms.RadioButton rad_email;
        private System.Windows.Forms.RadioButton rad_diachi;
        private System.Windows.Forms.RadioButton rad_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_back;
    }
}