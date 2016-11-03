using BaiTapLonCSharp.bus;
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
    public partial class frmNhanVien : Form
    {
        NhanVienInfo info = new NhanVienInfo();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = info.GetInfoNhanvien();
        }
    }
}
