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
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
            LoadDGW();
        }
        control ctr;
        int m = 0;
        private void btn_baocao_Click(object sender, EventArgs e)
        {
            ctr = new control();
            m = ctr.baocao();
            txt_baocao.Text = m.ToString();
        }

      private void LoadDGW()
        {
            control ctr = new control();
            dgw_baocao.DataSource = ctr.LayDataTable("BAOCAO");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
    }
}
