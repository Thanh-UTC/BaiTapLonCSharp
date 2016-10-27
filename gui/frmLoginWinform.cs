using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSharp.gui
{
    public partial class frmLoginWinform : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginWinform()
        {
            InitializeComponent();
        }

        private void lblQuenMatKhau_MouseHover(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.Red;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.Black;
        }
    }
}
