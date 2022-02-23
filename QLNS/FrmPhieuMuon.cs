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
    public partial class FrmPhieuMuon : Form
    {
        public FrmPhieuMuon()
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
            dgw_phieumuon.DataSource = ctr.LayDataTable("PHIEUMUON");
        }
        control ctr;
        control ctr2;
        InformationPHIEUMUON pm;
        InformationCT_PHIEUMUON ct_pm;
        private void btn_them_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pm = new InformationPHIEUMUON();
            ct_pm = new InformationCT_PHIEUMUON();
            if (txt_sopm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pm.Strsopm = txt_sopm.Text;
                pm.Dtngaymuon = mt_datefrom.Value;
                pm.Dtngaytra = mt_dateto.Value;
                ct_pm.Strsopm = txt_sopm.Text;
                ct_pm.Intsoluong = Convert.ToInt32(numb_soluong.Value);
                ct_pm.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_pm.Strmakh = cbo_kh.SelectedValue.ToString();
                ct_pm.Strmanv = cbo_nv.SelectedValue.ToString();
                ctr2.ct_phieumuon(ct_pm.Strsopm, ct_pm.Intsoluong, ct_pm.Strmasach, ct_pm.Strmakh, ct_pm.Strmanv, "INSERT");
                ctr.phieumuon(pm.Strsopm, pm.Dtngaymuon, pm.Dtngaytra, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm phiếu mượn thành công");
                LoadDGW();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pm = new InformationPHIEUMUON();
            ct_pm = new InformationCT_PHIEUMUON();
            if (txt_sopm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pm.Strsopm = txt_sopm.Text;
                pm.Dtngaymuon = mt_datefrom.Value;
                pm.Dtngaytra = mt_dateto.Value;
              
                ct_pm.Strsopm = txt_sopm.Text;
                ct_pm.Intsoluong = Convert.ToInt32(numb_soluong.Value);
                ct_pm.Strmasach = cbo_sach.SelectedValue.ToString();
                ct_pm.Strmakh = cbo_kh.SelectedValue.ToString();
                ct_pm.Strmanv = cbo_nv.SelectedValue.ToString();
                ctr2.ct_phieumuon(ct_pm.Strsopm, ct_pm.Intsoluong, ct_pm.Strmasach, ct_pm.Strmakh, ct_pm.Strmanv, "UPDATE");
                ctr.phieumuon(pm.Strsopm, pm.Dtngaymuon, pm.Dtngaytra, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa phiếu mượn thành công");
                LoadDGW();
            }
        }

        private void dgw_phieumuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sopm.Text = dgw_phieumuon.CurrentRow.Cells[0].Value.ToString();
            mt_datefrom.Value = Convert.ToDateTime(dgw_phieumuon.CurrentRow.Cells[1].Value.ToString());
            mt_dateto.Value = Convert.ToDateTime(dgw_phieumuon.CurrentRow.Cells[2].Value.ToString());
            cbo_sach.Text = dgw_phieumuon.CurrentRow.Cells[3].Value.ToString();
            numb_soluong.Text = dgw_phieumuon.CurrentRow.Cells[4].Value.ToString();
            cbo_nv.Text = dgw_phieumuon.CurrentRow.Cells[5].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ctr = new control();
            ctr2 = new control();
            pm = new InformationPHIEUMUON();
            ct_pm = new InformationCT_PHIEUMUON();
            DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                ct_pm.Strsopm = txt_sopm.Text;
                pm.Strsopm = txt_sopm.Text;
                ctr2.Delete(ct_pm.Strsopm, 5);
                ctr.Delete(pm.Strsopm, 5);
                ctr.Disconnect();
                MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
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
            }
        }
    }
}
