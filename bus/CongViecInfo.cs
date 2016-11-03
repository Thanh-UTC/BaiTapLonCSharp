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
    class CongViecInfo
    {
        CongViecData CongViecData;
        //busCongViec congviecData;
        public CongViecInfo()
        {
            CongViecData = new CongViecData();
        }
        #region lay thong tin nhan vien
        public DataTable GetInfoCongViec()
        {
            
            DataTable tblCongViec = new DataTable();
           
            tblCongViec = CongViecData.LayDSCongViec();
           
            
            return tblCongViec;
        }
        #endregion

        #region them thong tin nhan vien
        public bool InsertCongViecInfo(CongViec CongViec)
        {
            bool isDone = false;
            isDone = CongViecData.ThemCongViecMoi(CongViec);
            return isDone;
        }
        #endregion

        #region sua thong tin nhan vien
        public bool UpdateCongViecInfo(CongViec CongViec)
        {
            bool isDone = false;
            isDone = CongViecData.SuaCongViec(CongViec);
            return isDone;
        }
        #endregion

        #region xoa thong tin nhan vien
        public bool DeleteCongViecInfo(CongViec CongViec)
        {
            bool isDone = false;
            isDone = CongViecData.XoaCongViec(CongViec);
            return isDone;
        }
        #endregion
    }
}
