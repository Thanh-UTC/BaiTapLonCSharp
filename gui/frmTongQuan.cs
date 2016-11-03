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
        private frmNhanVien frm_NhanVien = null;
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

        private void btnQuanLiNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_NhanVien == null || frm_NhanVien.IsDisposed)
            {
                frm_NhanVien = new frmNhanVien();
                frm_NhanVien.MdiParent = frmTongQuan.ActiveForm;
                frm_NhanVien.Show();
            }
            else
            {
                frm_NhanVien.Activate();
            }
        }
    }
}
