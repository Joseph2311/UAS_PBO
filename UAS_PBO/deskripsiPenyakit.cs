using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class deskripsiPenyakit : diagnosaPenyakit
    {
        string deskripsi;
        public string isi(diagnosaPenyakit choose)
        {
            if (choose.prediksi1 == true)
            {
                deskripsi = "salah satu jenis sakit kepala yang paling umum." +
                    "Gejala migrain yakni berdenyut di sebagian kepala dan bisa berlangsung beberapa hari. ";
                return deskripsi;
            }
            else if (choose.prediksi2 == true)
            {
                deskripsi = "Kumpulan virus yang bisa menginfeksi sistem pernapasan." +
                    "Gejala awal infeksi virus Corona atau COVID-19 bisa menyerupai gejala flu, yaitu demam, pilek, batuk kering, sakit tenggorokan, dan sakit kepala.";
                return deskripsi;
            }
            else if (choose.prediksi3 == true)
            {
                deskripsi = "Asma dapat disebabkan oleh debu, asap rokok, bulu binatang, udara dingin, aktivitas fisik,  infeksi virus atau bahkan terpapar zat kimia." +
                    "Namun, hingga kini penyebab dari asma belum diketahui secara pasti. ";
                return deskripsi;
            }
            else if (choose.prediksi4 == true)
            {
                deskripsi = "Tifus adalah infeksi yang disebabkan oleh beberapa jenis bakteri Rickettsia typhi atau R. prowazekii. " +
                    "Penyakit ini bisa diatasi dengan antibiotik. Salah satu obat tifus yang sering diresepkan dokter adalah antibiotik tetracycline seperti doxycycline. ";
                return deskripsi;
            }
            else if (choose.prediksi5 == true)
            {
                deskripsi = "Flu juga dapat dengan mudah menyebar melalui bersin dan batuk pengidapnya." +
                    " Sehingga mungkin saja kamu yang awalnya tidak mengidap flu bisa tertular." +
                    " Flu juga bisa menular melalui benda yang disentuh pengidap flu. ";
                return deskripsi;
            }
            else if (choose.prediksi6==true)
            {
                deskripsi = "Radang tenggorokan bisa menjadi sangat mengganggu. " +
                    "Sebab, makan dan minum apapun jadi akan terasa serba salah." +
                    "Tidak hanya nyeri saat menelan, radang tenggorokan juga kerap disertai dengan demam ringan yang bisa membuat aktivitas terganggu. ";
                return deskripsi;
            }
            else
            {
                deskripsi = "Penyakit demam berdarah dengue (DBD) merupakan penyakit yang disebabkan oleh virus dengue dan bisa ditularkan lewat gigitan nyamuk Aedes Aegypti. " +
                    "gejala yang ditumbulkan seperti sakit kepala, mual dan muntah, kemunculan ruam, dan bintik merah.";
                return deskripsi;
            }
        }
    }
}
