using QuanLyNhaSach.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FrmBaoCaoCongNo : Form
    {
        public FrmBaoCaoCongNo()
        {
            InitializeComponent();
            LoadDGW();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                control ctr = new control();
                if (rab_tenkh.Checked == true)
                {
                    dgw_baocaocongno.DataSource = ctr.Search(txt_tim.Text, "TENKH");
                }
                if (rad_sdt.Checked == true)
                {
                    dgw_baocaocongno.DataSource = ctr.Search(txt_tim.Text, "SDTKH");
                }
                if (rad_diachi.Checked == true)
                {
                    dgw_baocaocongno.DataSource = ctr.Search(txt_tim.Text, "DIACHIKH");
                }
                if (rad_email.Checked == true)
                {
                    dgw_baocaocongno.DataSource = ctr.Search(txt_tim.Text, "EMAILKH");
                }
            }

        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_baocaocongno.DataSource = ctr.LayDataTable("BAOCAOCONGNO");
        }
    }
}
