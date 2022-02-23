using QLNS.Controls;
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
    public partial class FrmDoiMK : Form
    {
        public FrmDoiMK()
        {
            InitializeComponent();
            LoadCBO();
        }
        control ctr;
        InfomationNHANVIEN nv;
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_passnew.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nv = new InfomationNHANVIEN();
                nv.Strusername = cbo_user.SelectedValue.ToString();
                nv.Strpass = txt_pass.Text;
                ctr = new control();
                ctr.DoiMK(nv.Strusername, nv.Strpass, txt_passnew.Text);
                MessageBox.Show("Thay đổi đã được lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
        private void LoadCBO()
        {
            control ctr = new control();
            cbo_user.DisplayMember = "Username";
            cbo_user.ValueMember = "MaNV";
            cbo_user.DataSource = ctr.dataCBO("TAIKHOAN");
        }
    }

}
