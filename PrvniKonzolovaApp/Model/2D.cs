using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    public class _2D
    {
        public _2D(int x, int y)  // konstruktor
        {
            X = x;
            Y = y;
        }

        public _2D()  // prázdný konstruktor
        {

        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }

        public double VypocitejObsah()
        {
            double obsah = Math.Abs(X) * Math.Abs(Y);
            return obsah;
        }
        /// <summary>
        /// zjistí, v jakém kvadrantu se souřadnice nachází
        /// </summary>
        /// <returns>vrací karteziánský souřadnicový systém jako číslo kvadrantu</returns>
        public Quadrant GetQuadrant()
        {
            if (X == 0 && Y == 0) return Quadrant.Origin;
            if (X >= 0 && Y >= 0) return Quadrant.Quadrant1;
            else if (X < 0 && Y >= 0) return Quadrant.Quadrant2;
            else if (X < 0 && Y < 0) return Quadrant.Quadrant3;
            else if (X >= 0 && Y < 0) return Quadrant.Quadrant4;
            else return Quadrant.Error;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

    }
}
