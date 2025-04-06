using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HK2_KTLT
{
    public partial class Main1: Form
    {
        public Main1(String Loai_TaiKhoan)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (Loai_TaiKhoan == "0")
            {
                mmuDanhMuc.Enabled = true;
                mmuQuanliHoSo.Enabled = true;
                mmuQuanTriHeThong.Enabled = true;
            }
            else if (Loai_TaiKhoan == "1")
            {

            }
        }

        private void Main1_Load(object sender, EventArgs e)
        {

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.MdiParent = this;
            chucVu.Show();
        }
    }
}
