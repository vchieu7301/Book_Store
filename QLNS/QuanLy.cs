
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
    public partial class FrmQuanLy : Form
    {
         
        public FrmQuanLy(string a,string b)
        {
            InitializeComponent();
            LoadCBO();
            lbl_chao.Text = "Chào bạn " + a +" - "+ b;
            loadDTGV();
        }

        public FrmQuanLy()
        {
            
        }


        private void pic_sach_Click(object sender, EventArgs e)
        {
            FrmSach f = new FrmSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
            
                if(txt_masach.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_tensach.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                if (Numb_slg.Value==0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Numb_gia.Value == 0)
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
                        s.Intsoluong = Convert.ToInt32(Numb_slg.Value);
                        s.Intdongia = Convert.ToInt32(Numb_gia.Value);
                        ctr.sach(s.Strmasach, s.Strtensach, s.Strmacd, s.Strmanxb, s.Strmatg, s.Intsoluong, s.Intdongia, "INSERT");
                        ctr.Disconnect();
                    }
                        MessageBox.Show("Thêm sách thành công", "Thông báo");
            }
        private void loadDTGV()
        {
            control ctr = new control();
            dataGridView1.DataSource = ctr.LayDataTable("SACH");
        }

    }
}
