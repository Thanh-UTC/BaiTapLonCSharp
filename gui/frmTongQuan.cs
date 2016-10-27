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
    public partial class frmTongQuan : DevExpress.XtraEditors.XtraForm
    {
        private frmHoaDonBan frm_HDBan = null;
        private frmLogin frm_Login = null;
        private frmDoiMatKhau frm_DoiMatKhau = null;
        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void btnHoaDonXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm_HDBan == null || frm_HDBan.IsDisposed)
            {
                frm_HDBan = new frmHoaDonBan();
                frm_HDBan.MdiParent = frmTongQuan.ActiveForm;
                frm_HDBan.Show();
            }
            else
            {
                frm_HDBan.Activate();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm_DoiMatKhau == null || frm_DoiMatKhau.IsDisposed)
            {
                frm_DoiMatKhau = new frmDoiMatKhau();
                frm_DoiMatKhau.MdiParent = frmTongQuan.ActiveForm;
                frm_DoiMatKhau.Show();
            }
            else
            {
                frm_DoiMatKhau.Activate();
            }
        }
    }
}
