using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Data
{
    internal class Point2DMath
    {
public static _2D WhitchIsBigger(_2D bod1, _2D bod2)
        {

            double obsah1 = bod1.VypocitejObsah();
            double obsah2 = bod2.VypocitejObsah();
            if (obsah1 > obsah2) return bod1;
            else return bod2;

        } 

    }
}
