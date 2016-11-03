using BaiTapLonCSharp.dataComponent;
using BaiTapLonCSharp.dataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSharp.bus
{
    class NhanVienInfo
    {
        NhanVienData nhanvienData;
        public NhanVienInfo()
        {
            nhanvienData = new NhanVienData();
        }
        #region lay thong tin nhan vien
        public DataTable GetInfoNhanvien()
        {
            //NhanVien nhanvien = new NhanVien();
            DataTable tblNhanVien = new DataTable();
            tblNhanVien = nhanvienData.LayDSNhanVien();
            //dgv.DataSource = tblNhanVien;
            return tblNhanVien;
        }
        #endregion

        #region them thong tin nhan vien
        public bool InsertNhanvienInfo(NhanVien nhanvien)
        {
            bool isDone = false;
            isDone = nhanvienData.ThemNhanVienMoi(nhanvien);
            return isDone;
        }
        #endregion

        #region sua thong tin nhan vien
        public bool UpdateNhanvienInfo(NhanVien nhanvien)
        {
            bool isDone = false;
            isDone = nhanvienData.SuaNhanVien(nhanvien);
            return isDone;
        }
        #endregion

        #region xoa thong tin nhan vien
        public bool DeleteNhanvienInfo(NhanVien nhanvien)
        {
            bool isDone = false;
            isDone = nhanvienData.XoaNhanVien(nhanvien);
            return isDone;
        }
        #endregion
    }
}
