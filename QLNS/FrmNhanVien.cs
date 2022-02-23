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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            LoadDGW();
        }
        control ctr;
        InfomationNHANVIEN nv;
        private void btn_them_Click(object sender, EventArgs e)
        {
            ctr = new control();
            nv = new InfomationNHANVIEN();
            if (txt_manv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_username.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nv.Strmanv = txt_manv.Text;
                nv.Strtennv = txt_tennv.Text;              
                nv.Dtngaysinh = mt_ngaysinh.Value;
                nv.Blgioitinh = rad_nam.Checked ? true : false;
                nv.Strsdt = txt_sdt.Text;
                nv.Strdiachi = txt_diachi.Text;
                nv.Stremail = txt_email.Text;
                nv.Strchucvu = cbo_chucvu.Text;
                nv.Strusername = txt_username.Text;
                nv.Strpass = txt_pass.Text;
                ctr.themnv(nv.Strmanv, nv.Strtennv, nv.Strdiachi, nv.Blgioitinh, nv.Strsdt, nv.Stremail, nv.Dtngaysinh, nv.Strchucvu, nv.Strusername, nv.Strpass, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Đăng ký thành công !!");
                LoadDGW();
            }         
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_nv.DataSource = ctr.LayDataTable("NHANVIEN");
        }
        private void dgw_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgw_nv.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dgw_nv.CurrentRow.Cells[1].Value.ToString();
            mt_ngaysinh.Value = Convert.ToDateTime(dgw_nv.CurrentRow.Cells[2].Value.ToString());
            if(dgw_nv.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            txt_sdt.Text = dgw_nv.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgw_nv.CurrentRow.Cells[5].Value.ToString();
            txt_diachi.Text = dgw_nv.CurrentRow.Cells[6].Value.ToString();
            cbo_chucvu.Text = dgw_nv.CurrentRow.Cells[7].Value.ToString();
            txt_username.Text = dgw_nv.CurrentRow.Cells[8].Value.ToString();
            txt_pass.Text = dgw_nv.CurrentRow.Cells[9].Value.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            nv = new InfomationNHANVIEN();
            if (txt_manv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_username.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nv.Strmanv = txt_manv.Text;
                nv.Strtennv = txt_tennv.Text;
                nv.Dtngaysinh = mt_ngaysinh.Value;
                nv.Blgioitinh = rad_nam.Checked ? true : false;
                nv.Strsdt = txt_sdt.Text;
                nv.Strdiachi = txt_diachi.Text;
                nv.Stremail = txt_email.Text;
                nv.Strchucvu = cbo_chucvu.Text;
                nv.Strusername = txt_username.Text;
                nv.Strpass = txt_pass.Text;
                ctr.themnv(nv.Strmanv, nv.Strtennv, nv.Strdiachi, nv.Blgioitinh, nv.Strsdt, nv.Stremail, nv.Dtngaysinh, nv.Strchucvu, nv.Strusername, nv.Strpass, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Thông tin nhân viên đã được thay đổi !!");
                LoadDGW();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            control ctr = new control();
            InfomationNHANVIEN nv = new InfomationNHANVIEN();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                nv.Strmanv = txt_manv.Text;
                ctr.Delete(nv.Strmanv, 1);
                ctr.Disconnect();
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void txt_tennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }
    }
}
