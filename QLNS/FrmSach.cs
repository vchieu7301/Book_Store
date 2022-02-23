
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.Controls;
using QuanLyNhaSach.Controls;

namespace QLNS
{
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
            LoadCBO();
            LoadDGW();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            control ctr = new control();
            InformationSACH s = new InformationSACH();

            if (txt_masach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tensach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (numb_sl.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numb_gia.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                s.Strmasach = txt_masach.Text;
                s.Strtensach = txt_tensach.Text;
                s.Strmacd = cbo_cd.SelectedValue.ToString();
                s.Strmanxb = cbo_nxb.SelectedValue.ToString();
                s.Strmatg = cbo_tg.SelectedValue.ToString();
                s.Intsoluong1 = Convert.ToInt32(numb_sl.Value);
                s.Intdongia1 = Convert.ToInt32(numb_gia.Value);
                ctr.sach(s.Strmasach, s.Strtensach, s.Strmacd, s.Strmanxb, s.Strmatg, s.Intsoluong1, s.Intdongia1, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm sách thành công", "Thông báo");
                LoadDGW();
            }       
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_sach.DataSource = ctr.LayDataTable("SACH");
        }

        private void dgw_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masach.Text = dgw_sach.CurrentRow.Cells[0].Value.ToString();
            txt_tensach.Text = dgw_sach.CurrentRow.Cells[1].Value.ToString();
            cbo_cd.Text = dgw_sach.CurrentRow.Cells[2].Value.ToString();
            cbo_nxb.Text = dgw_sach.CurrentRow.Cells[3].Value.ToString();
            cbo_tg.Text = dgw_sach.CurrentRow.Cells[4].Value.ToString();
            numb_sl.Text = dgw_sach.CurrentRow.Cells[5].Value.ToString();
            numb_gia.Text = dgw_sach.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            control ctr = new control();
            InformationSACH s = new InformationSACH();

            if (txt_masach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tensach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (numb_sl.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numb_gia.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                s.Strmasach = txt_masach.Text;
                s.Strtensach = txt_tensach.Text;
                s.Strmacd = cbo_cd.SelectedValue.ToString();
                s.Strmanxb = cbo_nxb.SelectedValue.ToString();
                s.Strmatg = cbo_tg.SelectedValue.ToString();
                s.Intsoluong1 = Convert.ToInt32(numb_sl.Value);
                s.Intdongia1 = Convert.ToInt32(numb_gia.Value);
                ctr.sach(s.Strmasach, s.Strtensach, s.Strmacd, s.Strmanxb, s.Strmatg, s.Intsoluong1, s.Intdongia1, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Thông tin sách đã được thay đổi thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            control ctr = new control();
            InformationSACH s = new InformationSACH();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                s.Strmasach = txt_masach.Text;
                ctr.Delete(s.Strmasach, 0);
                ctr.Disconnect();
                MessageBox.Show("Xóa sách thành công","Thông báo");
                LoadDGW();
            }  
        }

        private void numb_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btn_dulieusach_Click(object sender, EventArgs e)
        {
            FrmDuLieuSach f = new FrmDuLieuSach();
            f.ShowDialog();
        }
    }
}
