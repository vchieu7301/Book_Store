using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.Controls;

namespace QLNS
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        control ctr,ctr2;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            if (ctr.Login(txt_username.Text,txt_password.Text))
            {
                string a = ctr.LayTenNV(txt_username.Text);//lấy tên nhân viên
                string b = ctr2.ChucVu(txt_username.Text); //lấy chức vụ
                FrmQuanLy f = new FrmQuanLy(a,b);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void ck_show_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_show.Checked) txt_password.UseSystemPasswordChar = false;
            else txt_password.UseSystemPasswordChar = true;

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            FrmDangky f = new FrmDangky();
            this.Hide();
            f.ShowDialog();
        }
    }
}
