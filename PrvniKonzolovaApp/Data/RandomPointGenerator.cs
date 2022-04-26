using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Data
{
    internal class RandomPointGenerator
    {
        public static _2D GetRandomPoint()
        {
            Random random = new Random();
            int x = random.Next(int.MinValue, int.MaxValue);
            int y = random.Next(int.MinValue, int.MaxValue);

            _2D result = new _2D(x,y);
            
            return result;

        }
    }
}
