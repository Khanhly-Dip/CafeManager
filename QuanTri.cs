using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class QuanTri : Form
    {
        public QuanTri()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            NhanVien nv  = new NhanVien();
            nv.ShowDialog();    
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            ThongkeBaocao tkbc = new ThongkeBaocao();
            tkbc.ShowDialog();
        }

        private void QuanTri_Load(object sender, EventArgs e)
        {

        }
    }
}
