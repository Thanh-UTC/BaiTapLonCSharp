using BaiTapLonCSharp.database;
using BaiTapLonCSharp.dataComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonCSharp.dataLayer
{
    class NhanVienData
    {
        private IOConfig ioData;
        public NhanVienData()
        {
            ioData = new IOConfig();
        }

        #region lay thong tin nhan vien
        public DataTable LayDSNhanVien()
        {
            String query = "LayDSNhanVien";
            String tableName = "tblNhanVien";
            SqlParameter[] para = new SqlParameter[0];
            return ioData.excuteSelectQuery(query, para, tableName);
        }
        #endregion

        #region them thong tin moi 
        public bool ThemNhanVienMoi(NhanVien _nhanvien)
        {
            String query = "ThemNhanVienMoi";
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@nhanvienID", _nhanvien.NhanvienID);
            para[1] = new SqlParameter("@nhanvienName", _nhanvien.NhanvienName);
            para[2] = new SqlParameter("@nhanvienSex", _nhanvien.NhanvienSex);
            para[3] = new SqlParameter("@nhanvienBirth", _nhanvien.NhanvienBirth);
            para[4] = new SqlParameter("@nhanvienPhone", _nhanvien.NhanvienPhone);
            para[5] = new SqlParameter("@nhanvienAddress", _nhanvien.NhanvienAddress);
            para[6] = new SqlParameter("@nhanvienCongViecID", _nhanvien.NhanvienCongViecID);
            return ioData.excuteInsertQuery(query, para);
        }
        #endregion

        #region sua thong tin nhan vien
        public bool SuaNhanVien(NhanVien _nhanvien)
        {
            String query = "SuaNhanVien";
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@nhanvienID", _nhanvien.NhanvienID);
            para[1] = new SqlParameter("@nhanvienName", _nhanvien.NhanvienName);
            para[2] = new SqlParameter("@nhanvienSex", _nhanvien.NhanvienSex);
            para[3] = new SqlParameter("@nhanvienBirth", _nhanvien.NhanvienBirth);
            para[4] = new SqlParameter("@nhanvienPhone", _nhanvien.NhanvienPhone);
            para[5] = new SqlParameter("@nhanvienAddress", _nhanvien.NhanvienAddress);
            para[6] = new SqlParameter("@nhanvienCongViecID", _nhanvien.NhanvienCongViecID);
            return ioData.excuteInsertQuery(query, para);
        }
        #endregion

        #region xoa thong tin nhan vien
        public bool XoaNhanVien(NhanVien _nhanvien)
        {
            String query = "XoaNhanVien";
            SqlParameter[] para = new SqlParameter[0];
            para[0] = new SqlParameter("@nhanvienID", _nhanvien.NhanvienID);
            return ioData.excuteDeleteQuery(query, para);
        }
        #endregion 
    }
}
