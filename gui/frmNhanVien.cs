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
            info.GetInfoNhanvien(dgvDanhSachNhanVien);
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Mã nhân viên";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Tên nhân viên";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Giới tính";
            dgvDanhSachNhanVien.Columns[7].HeaderText = "Điện thoại";
            dgvDanhSachNhanVien.Columns[8].HeaderText = "Địa chỉ";
            dgvDanhSachNhanVien.Columns[9].HeaderText = "Công việc";

            dgvDanhSachNhanVien.Columns[3].Width = 100;
            dgvDanhSachNhanVien.Columns[4].Width = 200;
            dgvDanhSachNhanVien.Columns[5].Width = 150;
            dgvDanhSachNhanVien.Columns[6].Width = 100;
            dgvDanhSachNhanVien.Columns[7].Width = 120;
            dgvDanhSachNhanVien.Columns[8].Width = 250;
            dgvDanhSachNhanVien.Columns[9].Width = 180;


        }
    }
}
