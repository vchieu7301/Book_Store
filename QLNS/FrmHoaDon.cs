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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
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
            cbo_sach.DisplayMember = "TenSach";
            cbo_sach.ValueMember = "MaSach";
            cbo_sach.DataSource = ctr.dataCBO("SACH");

            cbo_nv.DisplayMember = "TenNV";
            cbo_nv.ValueMember = "MaNV";
            cbo_nv.DataSource = ctr.dataCBO("NHANVIEN");

            cbo_kh.DisplayMember = "TenKH";
            cbo_kh.ValueMember = "MaKH";
            cbo_kh.DataSource = ctr.dataCBO("KHACHHANG");
        }
        private void LoadDGW()
        {
            control ctr = new control();
            dgw_hoadon.DataSource = ctr.LayDataTable("HOADON");
        }
        control ctr;
        control ctr2;
        InformationSACH s;
        InformationHOADON hd;
        InformationCT_HOADON ct_hd;
        private void btn_Thêm_Click(object sender, EventArgs e)
        { 
            ctr = new control();
            ctr2 = new control();
            hd = new InformationHOADON();
            ct_hd = new InformationCT_HOADON();
            s = new InformationSACH();

            if (txt_sohd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Strsohd = txt_sohd.Text;
                hd.Dtngaylap = mt_date.Value;
                hd.Intdongia = Convert.ToInt32(numb_gia.Value);         
                hd.Inttongtien = Convert.ToInt32(txt_tongtien.Text);
                ct_hd.Strsohd = txt_sohd.Text;
                ct_hd.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_hd.Strmanv = cbo_nv.SelectedValue.ToString();
                ct_hd.Strmakh = cbo_kh.SelectedValue.ToString();
                ct_hd.Intsoluong = Convert.ToInt32(numb_sl.Value);
                ctr2.ct_hoadon(ct_hd.Strsohd, ct_hd.Strmasach, ct_hd.Strmanv, ct_hd.Strmakh, ct_hd.Intsoluong, "INSERT");
                ctr.hoadon(hd.Strsohd, hd.Dtngaylap, hd.Intdongia, hd.Inttongtien, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm hóa đơn thành công");
                LoadDGW();
            }
        }

        private void numb_sl_ValueChanged(object sender, EventArgs e)
        {
            txt_tongtien.Text = (numb_sl.Value * numb_gia.Value).ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            hd = new InformationHOADON();
            ct_hd = new InformationCT_HOADON();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                ct_hd.Strsohd = txt_sohd.Text;
                hd.Strsohd = txt_sohd.Text;
                ctr2.Delete(ct_hd.Strsohd, 3);
                ctr.Delete(hd.Strsohd, 3);              
                ctr.Disconnect();
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                LoadDGW();
            }
        }

        private void dgw_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sohd.Text = dgw_hoadon.CurrentRow.Cells[0].Value.ToString();
            mt_date.Value = Convert.ToDateTime(dgw_hoadon.CurrentRow.Cells[1].Value.ToString());
            cbo_sach.Text = dgw_hoadon.CurrentRow.Cells[2].Value.ToString();           
            numb_sl.Text = dgw_hoadon.CurrentRow.Cells[3].Value.ToString();
            numb_gia.Text = dgw_hoadon.CurrentRow.Cells[4].Value.ToString();
            cbo_nv.Text = dgw_hoadon.CurrentRow.Cells[5].Value.ToString();
            cbo_kh.Text = dgw_hoadon.CurrentRow.Cells[6].Value.ToString();
            txt_tongtien.Text = dgw_hoadon.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            hd = new InformationHOADON();
            ct_hd = new InformationCT_HOADON();
            s = new InformationSACH();

            if (txt_sohd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Strsohd = txt_sohd.Text;
                hd.Dtngaylap = mt_date.Value;
                hd.Intdongia = Convert.ToInt32(numb_gia.Value);
                hd.Inttongtien = Convert.ToInt32(txt_tongtien.Text);
                ct_hd.Strsohd = txt_sohd.Text;
                ct_hd.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_hd.Strmanv = cbo_nv.SelectedValue.ToString();
                ct_hd.Strmakh = cbo_kh.SelectedValue.ToString();
                ct_hd.Intsoluong = Convert.ToInt32(numb_sl.Value);
                ctr2.ct_hoadon(ct_hd.Strsohd, ct_hd.Strmasach, ct_hd.Strmanv, ct_hd.Strmakh, ct_hd.Intsoluong, "UPDATE");
                ctr.hoadon(hd.Strsohd, hd.Dtngaylap, hd.Intdongia, hd.Inttongtien, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa hóa đơn thành công");
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
                numb_sl.Value = Convert.ToInt32(sdr["SoLuong"]);
                numb_gia.Value = Convert.ToInt32(sdr["DonGia"]);
            }
        }
    }
}
