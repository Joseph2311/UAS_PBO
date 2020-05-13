using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class Penyakit : diagnosaPenyakit
    {
        string diagnose;
        public string hasil(diagnosaPenyakit choose)
        {
            if (choose.prediksi1 == true)
            {
                diagnose = "Migrain";
                return diagnose;
            }
            else if (choose.prediksi2 == true)
            {
                diagnose = "Virus Corona(Covid-19)";
                return diagnose;
            }
            else if (choose.prediksi3)
            {
                diagnose = "Asma";
                return diagnose;
            }
            else if (choose.prediksi4)
            {
                diagnose = "Tipes";
                return diagnose;
            }
            else if (choose.prediksi5)
            {
                diagnose = "Flu";
                return diagnose;
            }
            else if (choose.prediksi6)
            {
                diagnose = "radang tenggorokan";
                return diagnose;
            }
            else
            {
                diagnose = "demam berdarah";
                return diagnose;
            }
        }
    }
}
