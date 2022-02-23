using QLNS.Controls;
using QuanLyNhaSach.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FrmPhieuThu : Form
    {
        public FrmPhieuThu()
        {
            InitializeComponent();
            LoadCBO();
            LoadDGW();
        }
        private void LoadCBO()
        {
            control ctr = new control();
            cbo_kh.DisplayMember = "TenKH";
            cbo_kh.ValueMember = "MaKH";
            cbo_kh.DataSource = ctr.dataCBO("KHACHHANG");
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_phieuthu.DataSource = ctr.LayDataTable("PHIEUTHU");
        }
        control ctr;
        control ctr2;
        InformationPHIEUTHU pt;
        InformationCT_PHIEUTHU ct_pt;
        private void btn_them_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pt = new InformationPHIEUTHU();
            ct_pt = new InformationCT_PHIEUTHU();
            if (txt_sopt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pt.Strsopt = txt_sopt.Text;
                pt.Dtngaythu = mt_date.Value;
                ct_pt.Inttienthu = Convert.ToInt32(txt_tienthu.Text);
                ct_pt.Strsopt = txt_sopt.Text;
                ct_pt.Strmakh = cbo_kh.SelectedValue.ToString();
                ctr2.ct_phieuthu(ct_pt.Strsopt, ct_pt.Strmakh, ct_pt.Inttienthu, "INSERT");
                ctr.phieuthu(pt.Strsopt, pt.Dtngaythu,  "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm phiếu thu thành công");
                LoadDGW();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pt = new InformationPHIEUTHU();
            ct_pt = new InformationCT_PHIEUTHU();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                ct_pt.Strsopt = txt_sopt.Text;
                pt.Strsopt = txt_sopt.Text;
                ctr2.Delete(ct_pt.Strsopt, 6);
                ctr.Delete(pt.Strsopt, 6);
                ctr.Disconnect();
                MessageBox.Show("Xóa phiếu thu thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pt = new InformationPHIEUTHU();
            ct_pt = new InformationCT_PHIEUTHU();
            if (txt_sopt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pt.Strsopt = txt_sopt.Text;
                pt.Dtngaythu = mt_date.Value;
                ct_pt.Inttienthu = Convert.ToInt32(txt_tienthu.Text);
                ct_pt.Strsopt = txt_sopt.Text;
                ct_pt.Strmakh = cbo_kh.SelectedValue.ToString();
                ctr2.ct_phieuthu(ct_pt.Strsopt, ct_pt.Strmakh, ct_pt.Inttienthu, "UPDATE");
                ctr.phieuthu(pt.Strsopt, pt.Dtngaythu, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa phiếu thu thành công");
                LoadDGW();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void dgw_phieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sopt.Text = dgw_phieuthu.CurrentRow.Cells[0].Value.ToString();
            mt_date.Value = Convert.ToDateTime(dgw_phieuthu.CurrentRow.Cells[1].Value.ToString());
            cbo_kh.Text = dgw_phieuthu.CurrentRow.Cells[2].Value.ToString();
            txt_tienno.Text = dgw_phieuthu.CurrentRow.Cells[3].Value.ToString();
            txt_tienthu.Text = dgw_phieuthu.CurrentRow.Cells[4].Value.ToString();
        }

        private void txt_tienno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tienthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        //private void btn_tinhtien_Click(object sender, EventArgs e)
        //{
        //    txt_nocuoi.Text = (Convert.ToInt32(txt_tienno.Text) - Convert.ToInt32(txt_tienthu.Text)).ToString();
        //}

        //private void cbo_kh_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    control ctr1 = new control();
        //    SqlDataReader sdr = ctr1.LoadThongTinNo(cbo_kh.SelectedValue.ToString());
        //    if (sdr.Read())
        //    {
        //        numb_tien.Value = Convert.ToInt32(sdr["TienNo"]);               
        //    }
        //}
    }
}
