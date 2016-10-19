using BaiTapLonCSharp.dataComponent;
using System.Data;
using BaiTapLonCSharp.dataLayer;
using System;

class busCongViec
{
    private DataCongViec dataCongViec;
    public busCongViec()
    {
        dataCongViec = new DataCongViec();
    }

    public DataTable getAllCongViecInfo()
    {
        CongViec congviec = new CongViec();
        DataTable table = new DataTable();
        table = dataCongViec.getCongViecInfo();
        return table;
    }
    public bool insertCongViec(CongViec _congviec)
    {
        bool isDone = false;
        isDone = dataCongViec.insertCongviecInfo(_congviec.IdCongViec, _congviec.NameCongViec, _congviec.SalaryCongViec);
        Console.WriteLine("BusCongViec true");
        return isDone;
    }
    public bool modifyCongViec(CongViec _congviec)
    {
        bool isDone = false;
        isDone = dataCongViec.modifyCongViecInfo(_congviec.IdCongViec,_congviec.NameCongViec, _congviec.SalaryCongViec);
        Console.WriteLine(isDone);
        return isDone;
    }
}
