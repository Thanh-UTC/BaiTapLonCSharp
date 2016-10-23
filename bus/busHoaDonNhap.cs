using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTapLonCSharp.dataLayer;
using System.Data;
using BaiTapLonCSharp.dataComponent;
namespace BaiTapLonCSharp.bus
{
    class BusHoaDonNhap
    {
        DataHoaDonNhap data;
        public BusHoaDonNhap()
        {
            data = new DataHoaDonNhap();
        }

         public DataTable getInfoHoaDonNhap()
        {
            HoaDonNhap hoadonNhap = new HoaDonNhap();
            DataTable dataTable = new DataTable();
            dataTable = data.getInfoHoaDonNhap();
            return dataTable;
        }

        public bool insertHoaDonNhap(HoaDonNhap hoadon)
        {
            bool isDone = false;
            isDone = data.insertInfoHoaDonNhap(hoadon);
        }
    }
}
