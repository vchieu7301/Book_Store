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
    public partial class FrmDuLieuSach : Form
    {
        public FrmDuLieuSach()
        {
            InitializeComponent();
            LoadDGW();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_themcd_Click(object sender, EventArgs e)
        {
            control ctrcd = new control();
            InformationCHUDE cd = new InformationCHUDE();

            if (txt_macd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tencd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_ghichu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cd.Strmacd = txt_macd.Text;
                cd.Strtencd = txt_tencd.Text;
                cd.Strghichu = txt_ghichu.Text;
                ctrcd.chude(cd.Strmacd, cd.Strtencd, cd.Strghichu, "INSERT");
                ctrcd.Disconnect();
                MessageBox.Show("Thêm chủ đề thành công", "Thông báo");
                LoadDGW();

            }
        }

        private void btn_themtg_Click(object sender, EventArgs e)
        {
            control ctrtg = new control();
            InformationTACGIA tg = new InformationTACGIA();

            if (txt_matg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tentg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachitg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tg.Strmatg = txt_matg.Text;
                tg.Strtentg = txt_tentg.Text;
                tg.Strdiachi = txt_diachitg.Text;
                ctrtg.tacgia(tg.Strmatg, tg.Strtentg, tg.Strdiachi, "INSERT");
                ctrtg.Disconnect();
                MessageBox.Show("Thêm tác giả thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_themnxb_Click(object sender, EventArgs e)
        {
            control ctrnxb = new control();
            InformationNXB nxb = new InformationNXB();

            if (txt_manxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tennxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachinxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nxb.Strmanxb = txt_manxb.Text;
                nxb.Strtennxb = txt_tennxb.Text;
                nxb.Strdiachi = txt_diachinxb.Text;
                ctrnxb.nxb(nxb.Strmanxb, nxb.Strtennxb, nxb.Strdiachi, "INSERT");
                ctrnxb.Disconnect();
                MessageBox.Show("Thêm NXB thành công", "Thông báo");
                LoadDGW();
            }
        }
        private void LoadDGW()
        {
            control ctr = new control();
            control ctr1 = new control();
            control ctr2 = new control();
            dgv_cd.DataSource = ctr.LayDataTable("CHUDE");
            dgv_tg.DataSource = ctr1.LayDataTable("TACGIA");
            dgv_nxb.DataSource = ctr2.LayDataTable("NXB");
        }

        private void btn_suacd_Click(object sender, EventArgs e)
        {
            control ctrcd = new control();
            InformationCHUDE cd = new InformationCHUDE();

            if (txt_macd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tencd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_ghichu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cd.Strmacd = txt_macd.Text;
                cd.Strtencd = txt_tencd.Text;
                cd.Strghichu = txt_ghichu.Text;
                ctrcd.chude(cd.Strmacd, cd.Strtencd, cd.Strghichu, "UPDATE");
                ctrcd.Disconnect();
                MessageBox.Show("Sửa chủ đề thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_suatg_Click(object sender, EventArgs e)
        {
            control ctrtg = new control();
            InformationTACGIA tg = new InformationTACGIA();

            if (txt_matg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tentg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachitg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tg.Strmatg = txt_matg.Text;
                tg.Strtentg = txt_tentg.Text;
                tg.Strdiachi = txt_diachitg.Text;
                ctrtg.tacgia(tg.Strmatg, tg.Strtentg, tg.Strdiachi, "UPDATE");
                ctrtg.Disconnect();
                MessageBox.Show("Sửa tác giả thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_suanxb_Click(object sender, EventArgs e)
        {
            control ctrnxb = new control();
            InformationNXB nxb = new InformationNXB();

            if (txt_manxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_tennxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_diachinxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nxb.Strmanxb = txt_manxb.Text;
                nxb.Strtennxb = txt_tennxb.Text;
                nxb.Strdiachi = txt_diachinxb.Text;
                ctrnxb.nxb(nxb.Strmanxb, nxb.Strtennxb, nxb.Strdiachi, "UPDATE");
                ctrnxb.Disconnect();
                MessageBox.Show("Sửa NXB thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void dgv_cd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macd.Text = dgv_cd.CurrentRow.Cells[0].Value.ToString();
            txt_tencd.Text = dgv_cd.CurrentRow.Cells[1].Value.ToString();
            txt_ghichu.Text = dgv_cd.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgv_tg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matg.Text = dgv_tg.CurrentRow.Cells[0].Value.ToString();
            txt_tentg.Text = dgv_tg.CurrentRow.Cells[1].Value.ToString();
            txt_diachitg.Text = dgv_tg.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgv_nxb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manxb.Text = dgv_nxb.CurrentRow.Cells[0].Value.ToString();
            txt_tennxb.Text = dgv_nxb.CurrentRow.Cells[1].Value.ToString();
            txt_diachinxb.Text = dgv_nxb.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_xoacd_Click(object sender, EventArgs e)
        {
            control ctrcd = new control();
            InformationCHUDE cd = new InformationCHUDE();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                cd.Strmacd = txt_macd.Text;
                ctrcd.Delete(cd.Strmacd, 7);
                ctrcd.Disconnect();
                MessageBox.Show("Xóa chủ đề thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_xoatg_Click(object sender, EventArgs e)
        {
            control ctrtg = new control();
            InformationTACGIA tg = new InformationTACGIA();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                tg.Strmatg = txt_matg.Text;
                ctrtg.Delete(tg.Strmatg, 8);
                ctrtg.Disconnect();
                MessageBox.Show("Xóa tác giả thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_xoanxb_Click(object sender, EventArgs e)
        {
            control ctrnxb = new control();
            InformationNXB nxb = new InformationNXB();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                nxb.Strmanxb = txt_manxb.Text;
                ctrnxb.Delete(nxb.Strmanxb, 9);
                ctrnxb.Disconnect();
                MessageBox.Show("Xóa NXB thành công", "Thông báo");
                LoadDGW();
            }
        }
    }
}
