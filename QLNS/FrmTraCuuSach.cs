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
    public partial class FrmTraCuuSach : Form
    {
        public FrmTraCuuSach()
        {
            InitializeComponent();
            LoadCBO();
            LoadDGW();
        }
        private void LoadCBO()
        {
            control ctr = new control();
            cbo_cd.DisplayMember = "TenCD";
            cbo_cd.ValueMember = "MaCD";
            cbo_cd.DataSource = ctr.dataCBO("CHUDE");

            cbo_tg.DisplayMember = "TenTG";
            cbo_tg.ValueMember = "MaTG";
            cbo_tg.DataSource = ctr.dataCBO("TACGIA");

            cbo_nxb.DisplayMember = "TenNXB";
            cbo_nxb.ValueMember = "MaNXB";
            cbo_nxb.DataSource = ctr.dataCBO("NXB");
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_timkiem.DataSource = ctr.LayDataTable("SACH");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void cbo_nxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            control ctr = new control();
            dgw_timkiem.DataSource = ctr.Search(cbo_nxb.Text, "NXB");
        }

        private void cbo_tg_SelectedIndexChanged(object sender, EventArgs e)
        {
            control ctr = new control();
            dgw_timkiem.DataSource = ctr.Search(cbo_tg.Text, "TACGIA");
        }

        private void cbo_cd_SelectedIndexChanged(object sender, EventArgs e)
        {
            control ctr = new control();
            dgw_timkiem.DataSource = ctr.Search(cbo_cd.Text, "CHUDE");
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(txt_tim.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                control ctr = new control();
                dgw_timkiem.DataSource = ctr.Search(txt_tim.Text, "TENSACH");
            }
        }
    }
}
