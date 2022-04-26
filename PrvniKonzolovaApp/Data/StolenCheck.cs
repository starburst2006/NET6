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
        /// <summary>
        /// zkontroluje zda není SPZ v databázi kradených SPZ
        /// </summary>
        /// <returns>Vrátí true pokud je auto kradené, jinak false</returns>
        public static bool GetRegisterInfo(Car auto)
        {
            
            if (auto.SPZ == "1B18855") { return true; }
            else { return false; }
            
        }
    }
}
