using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class Cars
    {
        public Cars(string spz, string barva, int km, string znacka)
        {
            SPZ = spz;
            Barva = barva;  
            Km = km;    
            Znacka = znacka;

        }
        public string SPZ { get; set; }
        public string Barva { get; set; }
        public int Km { get; set; }
        public string Znacka { get; set; }

    }
}
