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
    public partial class FrmDangky : Form
    {
        public FrmDangky()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        control ctr;
        InfomationNHANVIEN nv;
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            ctr = new control();
            nv = new InfomationNHANVIEN();
            foreach (Control k in grb1.Controls)
            {
                if (k is TextBox)
                { 
                    if (k.Text == "")
                    { 
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        nv.Strusername = txt_username.Text;
                        nv.Strpass = txt_passwords.Text;
                        nv.Strpass = txt_password2.Text;
                        if (txt_password2.Text != txt_passwords.Text)
                        {
                            lb_check.Text = "Mật khẩu không trùng khớp";
                        }
                        else
                        {

                            grb2.Location = new Point(25, 12);
                            grb2.Visible = true;
                            grb1.Visible = false;
                        }

                    }
                }
            }
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_dangky2_Click(object sender, EventArgs e)
        {
            ctr = new control();
            nv.Stremail = txt_email.Text;
            nv.Strsdt = txt_sdt.Text;
            nv.Strmanv = txt_makh.Text;
            nv.Strtennv = txt_tenkh.Text;
            int d = int.Parse(mt_ngaysinh.Text.Substring(0, 2));
            int m = int.Parse(mt_ngaysinh.Text.Substring(3, 2));
            int y = int.Parse(mt_ngaysinh.Text.Substring(6, 4));
            DateTime dt = new DateTime(y, m, d);
            nv.Dtngaysinh = dt;
            nv.Blgioitinh = rad_Nam.Checked ? true : false;
            nv.Blgioitinh = rad_nu.Checked;
            nv.Strdiachi = txt_diachi.Text;
            nv.Strchucvu = cbo_chucvu.Text;

            ctr.dangky(nv.Strusername, nv.Strpass, nv.Strmanv, nv.Strtennv, nv.Strdiachi, nv.Blgioitinh, nv.Strsdt, nv.Stremail, nv.Dtngaysinh,nv.Strchucvu, "INSERT");
            ctr.Disconnect();
            MessageBox.Show("Đăng ký thành công !!");
            FrmDangNhap f = new FrmDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void chk_dieukhoan_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_dieukhoan.Checked)
            {
                btn_dangky.Enabled = true;
            }
            else
            {
                btn_dangky.Enabled = false;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }

        private void txt_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;

        }
    }
}
