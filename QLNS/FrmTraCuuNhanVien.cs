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
    public partial class FrmTraCuuNhanVien : Form
    {
        public FrmTraCuuNhanVien()
        {
            InitializeComponent();
            LoadDGW();
            
        }
        
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_tim.DataSource = ctr.LayDataTable("NHANVIEN");
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
                if(rab_tennv.Checked == true)
                {
                    dgw_tim.DataSource = ctr.Search(txt_tim.Text, "TENNV");
                }
                if (rad_sdt.Checked == true)
                {
                    dgw_tim.DataSource = ctr.Search(txt_tim.Text, "SDT");
                }
                if (rad_diachi.Checked == true)
                {
                    dgw_tim.DataSource = ctr.Search(txt_tim.Text, "DIACHI");
                }
                if (rad_email.Checked == true)
                {
                    dgw_tim.DataSource = ctr.Search(txt_tim.Text, "EMAIL");
                }
            }
        }
    }
}
