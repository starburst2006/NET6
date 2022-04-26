using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Data
{
    internal class StolenCheck
    {
        public static string[] StolenCars = { "1B18855", "1B28855", "1B38855", "1B48855" };
        
        /// <summary>
        /// zkontroluje zda není SPZ v databázi kradených SPZ
        /// </summary>
        /// <returns>Vrátí true pokud je auto kradené, jinak false</returns>
        public static bool GetRegisterInfo(Car auto)
        {
            foreach(string kradenaSPZ in StolenCars)
            {
            if (auto.SPZ == kradenaSPZ) 
                    return true; 
            
            }
             return false;
           
        }
    }
}
