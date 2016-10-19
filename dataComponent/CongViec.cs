using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonCSharp.dataComponent
{
    class CongViec
    {
        private String idCongViec;
        private String nameCongViec;
        private String salaryCongViec;

        public string IdCongViec
        {
            get
            {
                return idCongViec;
            }

            set
            {
                idCongViec = value;
            }
        }

        public string NameCongViec
        {
            get
            {
                return nameCongViec;
            }

            set
            {
                nameCongViec = value;
            }
        }

        public string SalaryCongViec
        {
            get
            {
                return salaryCongViec;
            }

            set
            {
                salaryCongViec = value;
            }
        }
    }
}
