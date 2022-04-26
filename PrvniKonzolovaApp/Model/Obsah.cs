using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class Obsah
    {
        public Obsah(double _X, Double _Y)
        {
            X = _X;    
            Y = _Y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public double VypocitejObsah()
        {
            double obsah = Math.Abs(X) * Math.Abs(Y);
            return obsah;
        }


    }
}
