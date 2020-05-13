using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class klasifikasiPenyakit
    {
        private Boolean _klasifikasi;
        private Boolean _klasifikasi2;
        private Boolean _klasifikasi3;

        public Boolean klasifikasi
        {
            get { return _klasifikasi; }
            set
            {
                _klasifikasi = value;
            }
        }
        public Boolean klasifikasi2
        {
            get { return _klasifikasi2; }
            set
            {
                _klasifikasi2 = value;
            }
        }
        public Boolean klasifikasi3
        {
            get { return _klasifikasi3; }
            set
            {
                _klasifikasi3 = value;
            }
        }
        public klasifikasiPenyakit(Boolean Klasifikasi, Boolean Klasifikasi2, Boolean Klasifikasi3)
        {
            klasifikasi = Klasifikasi;
            klasifikasi2 = Klasifikasi2;
            klasifikasi3 = Klasifikasi3;
        }
    }
}
