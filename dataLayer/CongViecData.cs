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
    class CongViecData
    {
        private IOConfig ioData;
        public CongViecData()
        {
            ioData = new IOConfig();
        }

        #region lay thong tin nhan vien
        public DataTable LayDSCongViec()
        {
            String query = "LayDSCongViec";
            String tableName = "tblCongViec";
            SqlParameter[] para = new SqlParameter[0];
            return ioData.excuteSelectQuery(query, para, tableName);
        }
        #endregion

        #region them thong tin moi 
        public bool ThemCongViecMoi(CongViec _congviec)
        {
            String query = "ThemCongViecMoi";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@CongViecID", _congviec.IdCongViec);
            para[1] = new SqlParameter("@CongViecName", _congviec.NameCongViec);
            para[2] = new SqlParameter("@CongViecSex", _congviec.SalaryCongViec);
           
            return ioData.excuteInsertQuery(query, para);
        }
        #endregion

        #region sua thong tin nhan vien
        public bool SuaCongViec(CongViec _congviec)
        {
            String query = "SuaCongViec";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@CongViecID", _congviec.IdCongViec);
            para[1] = new SqlParameter("@CongViecName", _congviec.NameCongViec);
            para[2] = new SqlParameter("@CongViecSex", _congviec.SalaryCongViec);
            return ioData.excuteInsertQuery(query, para);
        }
        #endregion

        #region xoa thong tin nhan vien
        public bool XoaCongViec(CongViec _congviec)
        {
            String query = "XoaCongViec";
            SqlParameter[] para = new SqlParameter[0];
            
            para[0] = new SqlParameter("@CongViecID", _congviec.IdCongViec);
          
            return ioData.excuteDeleteQuery(query, para);
        }
        #endregion 
    }
}
