using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class _2D
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



    }
}
