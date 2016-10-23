using BaiTapLonCSharp.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

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
            SqlParameter[] sqlPara = new SqlParameter[0];
            return ioData.excuteSelectQuery(selectQuery, sqlPara);
        }

        public bool insertInfoHoaDonNhap(String _idHoaDonNhap, String _idNhanVien, Timer _dateNhap, String _nameNhaCungCap, String _idHangNhap, String _nameHangNhap, String _amountHangNhap, float _unitPrice,float _totalPrice)
        {
            String insertQuery = "insertInfoHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@idHoaDonNhap", _idHoaDonNhap);
            sqlPara[1] = new SqlParameter("@idNhanvien", _idNhanVien);
            sqlPara[2] = new SqlParameter("@dateNhap", _dateNhap);
            sqlPara[3] = new SqlParameter("@nameNhaCungCap", _nameNhaCungCap);
            sqlPara[4] = new SqlParameter("@idHangNhap", _idHangNhap);
            sqlPara[5] = new SqlParameter("@nameHangNhap", _nameHangNhap);
            sqlPara[6] = new SqlParameter("@amountHangNhap", _amountHangNhap);
            sqlPara[7] = new SqlParameter("@unitPrice", _unitPrice);
            sqlPara[8] = new SqlParameter("@totalPrice", _totalPrice);
            return ioData.excuteInsertQuery(insertQuery, sqlPara);
        }

        public bool updateInfoHoaDonNhap(String _idHoaDonNhap, String _idNhanVien, Timer _dateNhap, String _nameNhaCungCap, String _idHangNhap, String _nameHangNhap, String _amountHangNhap, float _unitPrice, float _totalPrice)
        {
            String updateQuery = "updateInfoHoaDonNhap";
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@idHoaDonNhap", _idHoaDonNhap);
            sqlPara[1] = new SqlParameter("@idNhanvien", _idNhanVien);
            sqlPara[2] = new SqlParameter("@dateNhap", _dateNhap);
            sqlPara[3] = new SqlParameter("@nameNhaCungCap", _nameNhaCungCap);
            sqlPara[4] = new SqlParameter("@idHangNhap", _idHangNhap);
            sqlPara[5] = new SqlParameter("@nameHangNhap", _nameHangNhap);
            sqlPara[6] = new SqlParameter("@amountHangNhap", _amountHangNhap);
            sqlPara[7] = new SqlParameter("@unitPrice", _unitPrice);
            sqlPara[8] = new SqlParameter("@totalPrice", _totalPrice);
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
