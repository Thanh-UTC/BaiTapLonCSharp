using BaiTapLonCSharp.dataComponent;
using BaiTapLonCSharp.dataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLonCSharp.database;
namespace BaiTapLonCSharp.bus
{
    class NhanVienInfo
    {
        NhanVienData nhanvienData = new NhanVienData();
        //CongViecInfo congviecInfo = new CongViecInfo();
        public NhanVienInfo()
        {
            nhanvienData = new NhanVienData();
        }
        #region lay thong tin nhan vien
        public void GetInfoNhanvien (DataGridView dgv)
        {
            
            DataTable tblNhanVien = new DataTable();
            //DataTable tblCongViec = new DataTable();
            //DataTable combineTable = new DataTable();
            //combineTable = tblNhanVien.Copy();
            //combineTable.Merge(tblCongViec);
            
            tblNhanVien = nhanvienData.LayDSNhanVien();
            dgv.DataSource = tblNhanVien;
            
            //return tblNhanVien;
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
