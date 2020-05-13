using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class diagnosaPenyakit
    {
        public bool prediksi1, prediksi2, prediksi3, prediksi4, prediksi5, prediksi6, prediksi7;
        public bool inputpenyakit(Boolean Klasifikasi, Boolean Klasifikasi2, Boolean Klasifikasi3)
        {
            klasifikasiPenyakit penyakit = new klasifikasiPenyakit(Klasifikasi, Klasifikasi2, Klasifikasi3);
            if (Klasifikasi == true && Klasifikasi2 == false && Klasifikasi3 == false)
            {
                prediksi1 = true;
                return prediksi1;
            }
            else if (Klasifikasi2 == true && Klasifikasi == false && Klasifikasi3 == false)
            {
                prediksi2 = true;
                return prediksi2;
            }
            else if (Klasifikasi3 == true && Klasifikasi2 == false && Klasifikasi == false)
            {
                prediksi3 = true;
                return prediksi3;
            }
            else if (Klasifikasi == true && Klasifikasi2 == true && Klasifikasi3 == false)
            {
                prediksi4 = true;
                return prediksi4;
            }
            else if (Klasifikasi == true && Klasifikasi2 == false && Klasifikasi3 == true)
            {
                prediksi5 = true;
                return prediksi5;
            }
            else if (Klasifikasi == false && Klasifikasi2==true && Klasifikasi3== true)
            {
                prediksi6 = true;
                return prediksi6;
            }
            else
            {
                prediksi7 = true;
                return prediksi7;
            }
        }
    }
}
