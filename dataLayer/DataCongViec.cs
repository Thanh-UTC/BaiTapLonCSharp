using BaiTapLonCSharp.database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLonCSharp.dataLayer
{
    class DataCongViec
    {
        private ioConfig ioData;

        public DataCongViec()
        {
            ioData = new ioConfig();
        }

        public DataTable getCongViecInfo()
        {
            String query = "getCongviecInfo";
            SqlParameter[] sqlPara = new SqlParameter[0];
            return ioData.excuteSelectQuery(query, sqlPara);
        }

        public bool insertCongviecInfo(String _id, String _name, String _salary)
        {
            String query = "insertCongViecInfo";
            SqlParameter[] sqlPara = new SqlParameter[3];
            sqlPara[0] = new SqlParameter("@idCongViec", _id);
            //sqlPara[0].Value = _id;
            sqlPara[1] = new SqlParameter("@nameCongViec", _name);
            //sqlPara[1].Value = _name;
            sqlPara[2] = new SqlParameter("@salaryCongViec", _salary);
            //sqlPara[2].Value = _salary;
            Console.WriteLine("DataCongViec true");
            return ioData.excuteInsertQuery(query, sqlPara);
        }

        public bool modifyCongViecInfo(String _id, String _name, String _salary)
        {
            String query = "modifyCongViecInfo";
            SqlParameter[] sqlPara = new SqlParameter[3];
            sqlPara[0] = new SqlParameter("@idCongViec", SqlDbType.NChar);
            sqlPara[0].Value = _id;
            sqlPara[1] = new SqlParameter("@nameCongViec", SqlDbType.NChar);
            sqlPara[1].Value = _name;
            sqlPara[2] = new SqlParameter("@salaryCOngViec", SqlDbType.NChar);
            sqlPara[2].Value = _salary;
            Console.WriteLine("modifyCongViec true");
            return ioData.excuteModifyQuery(query, sqlPara);
        }
        public bool deleteCongViecInfo(String _id)
        {
            String query = "deleteCongViecInfo";
            SqlParameter[] sqlPara = new SqlParameter[3];
            sqlPara[0] = new SqlParameter("@idCongViec", SqlDbType.NChar);
            sqlPara[0].Value = _id;
            Console.WriteLine("deleteCongViec true");
            return ioData.excuteModifyQuery(query, sqlPara);
        }
    }
}
