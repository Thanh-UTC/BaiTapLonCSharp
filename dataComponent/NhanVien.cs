using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonCSharp.dataComponent
{
    class NhanVien
    {
        private String nhanvienID;
        private String nhanvienName;
        private String nhanvienSex;
        private DateTime nhanvienBirth;
        private String nhanvienPhone;
        private String nhanvienAddress;
        private String nhanvienCongViecID;

        public string NhanvienID
        {
            get
            {
                return nhanvienID;
            }

            set
            {
                nhanvienID = value;
            }
        }

        public string NhanvienName
        {
            get
            {
                return nhanvienName;
            }

            set
            {
                nhanvienName = value;
            }
        }

        public string NhanvienSex
        {
            get
            {
                return nhanvienSex;
            }

            set
            {
                nhanvienSex = value;
            }
        }

        public DateTime NhanvienBirth
        {
            get
            {
                return nhanvienBirth;
            }

            set
            {
                nhanvienBirth = value;
            }
        }

        public string NhanvienPhone
        {
            get
            {
                return nhanvienPhone;
            }

            set
            {
                nhanvienPhone = value;
            }
        }

        public string NhanvienAddress
        {
            get
            {
                return nhanvienAddress;
            }

            set
            {
                nhanvienAddress = value;
            }
        }

        public string NhanvienCongViecID
        {
            get
            {
                return nhanvienCongViecID;
            }

            set
            {
                nhanvienCongViecID = value;
            }
        }
    }
}
