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
        public FrmQuanLy()
        {
            InitializeComponent();         
        }
        public FrmQuanLy(string a, string b)
        {
            InitializeComponent();
            lbl_chao.Text = "Chào bạn " + a + " - " + b;
        }
        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            FrmDangNhap f = new FrmDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMK f = new FrmDoiMK();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = new DialogResult();
            tb = MessageBox.Show("Bạn có chắc muốn rời khỏi chương trình ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSach s = new FrmSach();
            s.ShowDialog();    
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.ShowDialog();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTraCuuSach f = new FrmTraCuuSach();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTraCuuNhanVien f = new FrmTraCuuNhanVien();
            f.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap f = new FrmPhieuNhap();
            f.ShowDialog();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuMuon f = new FrmPhieuMuon();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            f.ShowDialog();
        }


        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuyDinh f = new FrmQuyDinh();
            f.ShowDialog();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuThu f = new FrmPhieuThu();
            f.ShowDialog();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoCongNo f = new FrmBaoCaoCongNo();
            f.ShowDialog();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.ShowDialog();
        }
    }
}
