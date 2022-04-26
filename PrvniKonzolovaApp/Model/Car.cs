using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class Car
    {
        public Car(string spz, string barva, double km, string znacka)
        {
            SPZ = spz;
            Barva = barva;  
            Km = km;    
            Znacka = znacka;

        }
        public string SPZ { get; set; }
        public string Barva { get; set; }
        public double Km { get; set; }
        public string Znacka { get; set; }

    }
}
