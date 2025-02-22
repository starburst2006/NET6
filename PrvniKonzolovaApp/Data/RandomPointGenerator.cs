﻿using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Data
{
    internal class RandomPointGenerator
    {
        private static int Counter;

        public static int GetCount()
        {
            return Counter;
        }
        /// <summary>
        /// vygeneruje náhodné souřadnice X a Y v rozsahu int.MinValue - int.MaxValue
        /// </summary>
        /// <returns>instanci _2D</returns>
        public static _2D GetRandomPoint()
        {
            Random random = new Random();
            int x = random.Next(int.MinValue, int.MaxValue);
            int y = random.Next(int.MinValue, int.MaxValue);
            Counter++;
            _2D result = new _2D(x,y);
            
            return result;

        }
    }
}
