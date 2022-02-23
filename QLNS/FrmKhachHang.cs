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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
            LoadDGW();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
        control ctr;
        InformationKHACHHANG kh;
        private void btn_them_Click(object sender, EventArgs e)
        {
            ctr = new control();
            kh = new InformationKHACHHANG();
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tenkh.Text == "")
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
            if (txt_tienno.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh.Strmakh = txt_makh.Text;
                kh.Strtenkh = txt_tenkh.Text;
                kh.Dtngaysinh = mt_ngaysinh.Value;
                kh.Blgioitinh = rad_nam.Checked ? true : false;
                kh.Strsdt = txt_sdt.Text;
                kh.Strdiachi = txt_diachi.Text;
                kh.Stremail = txt_email.Text;
                kh.Inttienno = Convert.ToInt32(txt_tienno.Text);
                ctr.themkh(kh.Strmakh, kh.Strtenkh, kh.Strdiachi, kh.Blgioitinh, kh.Strsdt, kh.Stremail, kh.Dtngaysinh,kh.Inttienno, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm khách hàng thành công !!");
                LoadDGW();
            }
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_kh.DataSource = ctr.LayDataTable("KHACHHANG");
        }

        private void dgw_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgw_kh.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dgw_kh.CurrentRow.Cells[1].Value.ToString();
            mt_ngaysinh.Value = Convert.ToDateTime(dgw_kh.CurrentRow.Cells[2].Value.ToString());
            if (dgw_kh.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            txt_sdt.Text = dgw_kh.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgw_kh.CurrentRow.Cells[5].Value.ToString();
            txt_diachi.Text = dgw_kh.CurrentRow.Cells[6].Value.ToString();
            txt_tienno.Text = dgw_kh.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            kh = new InformationKHACHHANG();
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tenkh.Text == "")
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
            else
            {
                kh.Strmakh = txt_makh.Text;
                kh.Strtenkh = txt_tenkh.Text;
                kh.Dtngaysinh = mt_ngaysinh.Value;
                kh.Blgioitinh = rad_nam.Checked ? true : false;
                kh.Strsdt = txt_sdt.Text;
                kh.Strdiachi = txt_diachi.Text;
                kh.Stremail = txt_email.Text;
                kh.Inttienno = Convert.ToInt32(txt_tienno.Text);
                ctr.themkh(kh.Strmakh, kh.Strtenkh, kh.Strdiachi, kh.Blgioitinh, kh.Strsdt, kh.Stremail, kh.Dtngaysinh, kh.Inttienno, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Thông thin khách hàng đã được thay đổi !!");
                LoadDGW();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            control ctr = new control();
            InformationKHACHHANG kh = new InformationKHACHHANG();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                kh.Strmakh = txt_makh.Text;
                ctr.Delete(kh.Strmakh, 2);
                ctr.Disconnect();
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void txt_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }

        private void txt_tienno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
