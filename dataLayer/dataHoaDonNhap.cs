using BaiTapLonCSharp.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using BaiTapLonCSharp.dataComponent;
namespace BaiTapLonCSharp.dataLayer
{
    class DataHoaDonNhap
    {
        private IOConfig ioData;
        public DataHoaDonNhap()
        {
            ioData = new IOConfig();
        }

        public DataTable getInfoHoaDonNhap()
        {
            String selectQuery = "getInfoHoaDonNhap";
            String tableName = "tblHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[0];
            return ioData.excuteSelectQuery(selectQuery, sqlPara, tableName);
        }

        public bool insertInfoHoaDonNhap(HoaDonNhap _hoadon)
        {
            String insertQuery = "insertInfoHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@idHoaDonNhap", _hoadon.IdHoaDon);
            sqlPara[1] = new SqlParameter("@idNhanvien", _hoadon.IdNhanVien);
            sqlPara[2] = new SqlParameter("@dateNhap", _hoadon.DateNhap);
            sqlPara[3] = new SqlParameter("@nameNhaCungCap", _hoadon.NameNhaCungCap);
            sqlPara[4] = new SqlParameter("@idHangNhap", _hoadon.IdHangNhap);
            sqlPara[5] = new SqlParameter("@nameHangNhap", _hoadon.NameHangNhap);
            sqlPara[6] = new SqlParameter("@amountHangNhap", _hoadon.AmountHangNhap);
            sqlPara[7] = new SqlParameter("@unitPrice", _hoadon.UnitPrice);
            sqlPara[8] = new SqlParameter("@totalPrice", _hoadon.TotalPrice);
            return ioData.excuteInsertQuery(insertQuery, sqlPara);
        }

        public bool updateInfoHoaDonNhap(HoaDonNhap _hoadon)
        {
            String updateQuery = "updateInfoHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@idHoaDonNhap", _hoadon.IdHoaDon);
            sqlPara[1] = new SqlParameter("@idNhanvien", _hoadon.IdNhanVien);
            sqlPara[2] = new SqlParameter("@dateNhap", _hoadon.DateNhap);
            sqlPara[3] = new SqlParameter("@nameNhaCungCap", _hoadon.NameNhaCungCap);
            sqlPara[4] = new SqlParameter("@idHangNhap", _hoadon.IdHangNhap);
            sqlPara[5] = new SqlParameter("@nameHangNhap", _hoadon.NameHangNhap);
            sqlPara[6] = new SqlParameter("@amountHangNhap", _hoadon.AmountHangNhap);
            sqlPara[7] = new SqlParameter("@unitPrice", _hoadon.UnitPrice);
            sqlPara[8] = new SqlParameter("@totalPrice", _hoadon.TotalPrice);
            return ioData.excuteUpdateQuery(updateQuery, sqlPara);
        }

        public bool deleteInfoHoaDonNhap(String _idHoaDonNhap)
        {
            String deleteQuery = "deleteInfoHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[0];
            sqlPara[0] = new SqlParameter("@idHoaDonNhap", _idHoaDonNhap);
            return ioData.excuteDeleteQuery(deleteQuery, sqlPara);
        }
    }
}
