using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaiTapLonCSharp.dataComponent
{
    class HoaDonNhap
    {
        private String idHoaDon;
        private String idNhanVien;
        private Timer dateNhap;
        private String nameNhaCungCap;
        private String idHangNhap;
        private String nameHangNhap;
        private String amountHangNhap;
        private float unitPrice;
        private float totalPrice;

        #region constructor
        public HoaDonNhap()
        {

        }
        #endregion

        #region getter setter
        public string IdHoaDon
        {
            get
            {
                return idHoaDon;
            }

            set
            {
                idHoaDon = value;
            }
        }

        public string IdNhanVien
        {
            get
            {
                return idNhanVien;
            }

            set
            {
                idNhanVien = value;
            }
        }

        public Timer DateNhap
        {
            get
            {
                return dateNhap;
            }

            set
            {
                dateNhap = value;
            }
        }

        public string NameNhaCungCap
        {
            get
            {
                return nameNhaCungCap;
            }

            set
            {
                nameNhaCungCap = value;
            }
        }

        public string IdHangNhap
        {
            get
            {
                return idHangNhap;
            }

            set
            {
                idHangNhap = value;
            }
        }

        public string NameHangNhap
        {
            get
            {
                return nameHangNhap;
            }

            set
            {
                nameHangNhap = value;
            }
        }

        public string AmountHangNhap
        {
            get
            {
                return amountHangNhap;
            }

            set
            {
                amountHangNhap = value;
            }
        }

        public float UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        #endregion

        

    }
}
