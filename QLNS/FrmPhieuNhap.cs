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
    public partial class FrmPhieuNhap : Form
    {
        public FrmPhieuNhap()
        {
            InitializeComponent();
            LoadCBO();
            LoadDGW();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
        control ctr;
        control ctr2;
        InformationPHIEUNHAP pn;
        InformationCT_PHIEUNHAP ct_pn;
        private void btn_them_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pn = new InformationPHIEUNHAP();
            ct_pn = new InformationCT_PHIEUNHAP();
            if (txt_sopn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pn.Strsopn = txt_sopn.Text;
                pn.Dtngaynhap = mt_date.Value;            
                pn.Intgianhap = Convert.ToInt32(Numb_gianhap.Value);
                pn.Inttongtien = Convert.ToInt32(txt_tongtien.Text);
                ct_pn.Strsopn = txt_sopn.Text;
                ct_pn.Intsoluong = Convert.ToInt32(numb_soluong.Value);
                ct_pn.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_pn.Strmanv = cbo_nv.SelectedValue.ToString();
                ctr2.ct_phieunhap(ct_pn.Strsopn, ct_pn.Intsoluong, ct_pn.Strmasach, ct_pn.Strmanv, "INSERT");
                ctr.phieunhap(pn.Strsopn, pn.Dtngaynhap, pn.Intgianhap,pn.Inttongtien, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm phiếu nhập thành công");
                LoadDGW();
            }
        }

        private void LoadCBO()
        {
            control ctr = new control();
            
            cbo_sach.DisplayMember = "TenSach";
            cbo_sach.ValueMember = "MaSach";
            cbo_sach.DataSource = ctr.dataCBO("SACH");

            cbo_nv.DisplayMember = "TenNV";
            cbo_nv.ValueMember = "MaNV";
            cbo_nv.DataSource = ctr.dataCBO("NHANVIEN");

        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_phieunhap.DataSource = ctr.LayDataTable("PHIEUNHAP");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pn = new InformationPHIEUNHAP();
            ct_pn = new InformationCT_PHIEUNHAP();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                ct_pn.Strsopn = txt_sopn.Text;
                pn.Strsopn = txt_sopn.Text;
                ctr2.Delete(ct_pn.Strsopn, 4);
                ctr.Delete(pn.Strsopn, 4);
                ctr.Disconnect();
                MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
                LoadDGW();
            }

        }

        private void dgw_phieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sopn.Text = dgw_phieunhap.CurrentRow.Cells[0].Value.ToString();
            mt_date.Value = Convert.ToDateTime(dgw_phieunhap.CurrentRow.Cells[1].Value.ToString());
            cbo_sach.Text = dgw_phieunhap.CurrentRow.Cells[2].Value.ToString();        
            numb_soluong.Text = dgw_phieunhap.CurrentRow.Cells[3].Value.ToString();
            Numb_gianhap.Text = dgw_phieunhap.CurrentRow.Cells[4].Value.ToString();        
            cbo_nv.Text = dgw_phieunhap.CurrentRow.Cells[5].Value.ToString();
            txt_tongtien.Text = dgw_phieunhap.CurrentRow.Cells[6].Value.ToString();
        }

        private void numb_soluong_ValueChanged(object sender, EventArgs e)
        {
            txt_tongtien.Text = (numb_soluong.Value * Numb_gianhap.Value).ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pn = new InformationPHIEUNHAP();
            ct_pn = new InformationCT_PHIEUNHAP();
            if (txt_sopn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pn.Strsopn = txt_sopn.Text;
                pn.Dtngaynhap = mt_date.Value;
                pn.Intgianhap = Convert.ToInt32(Numb_gianhap.Value);
                pn.Inttongtien = Convert.ToInt32(txt_tongtien.Text);
                ct_pn.Strsopn = txt_sopn.Text;
                ct_pn.Intsoluong = Convert.ToInt32(numb_soluong.Value);
                ct_pn.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_pn.Strmanv = cbo_nv.SelectedValue.ToString();
                ctr2.ct_phieunhap(ct_pn.Strsopn, ct_pn.Intsoluong, ct_pn.Strmasach, ct_pn.Strmanv, "UPDATE");
                ctr.phieunhap(pn.Strsopn, pn.Dtngaynhap, pn.Intgianhap, pn.Inttongtien, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa phiếu nhập thành công");
                LoadDGW();
            }
        }

        private void cbo_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            control ctr1 = new control();
            SqlDataReader sdr = ctr1.LoadThongTin(cbo_sach.SelectedValue.ToString());
            if (sdr.Read())
            {
                txt_cd.Text = Convert.ToString(sdr["TenCD"]);
                txt_nxb.Text = Convert.ToString(sdr["TenNXB"]);
                txt_tg.Text = Convert.ToString(sdr["TenTG"]);
                numb_soluong.Value = Convert.ToInt32(sdr["SoLuong"]);
                Numb_gianhap.Value = Convert.ToInt32(sdr["DonGia"]);
            }
        }
    }
}
