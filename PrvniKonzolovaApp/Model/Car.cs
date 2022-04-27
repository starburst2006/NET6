using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    /// <summary>
    /// reprezentuje 1 auto
    /// </summary>
    internal class Car
    {
        public Car(string spz, string barva, double km, string znacka)
        {
            SPZ = spz;
            Barva = barva;  
            Km = km;    
            Znacka = znacka;

        }
        #region properties
        public string SPZ { get; set; } = "";
        public string Barva { get; set; } = "Nezadana";
        public double Km { get; set; } = 0;
        public string Znacka { get; set; } = "nezadána";
        public Person Majitel { get; set; }
        #endregion

        public void AddKilometers(double km)
        {
            Km += km;
        }

        public void AddOneKm()
        {
            Km++;
        }

    }
}
