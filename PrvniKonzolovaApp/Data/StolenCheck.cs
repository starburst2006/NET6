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
        public static List<string> StolenCars = new List<string>();
        private static bool IsLoadedStolenCars = false;
        public const string StolenCarPath = @"C:\Users\Student\source\repos\starburst2006\NET6\PrvniKonzolovaApp\SPZ\kradene.txt";
        /// <summary>
        /// zkontroluje zda není SPZ v databázi kradených SPZ
        /// </summary>
        /// <returns>Vrátí true pokud je auto kradené, jinak false</returns>
        public static bool GetRegisterInfo(Car auto)
        {
            if (!IsLoadedStolenCars) 
            {
                LoadStolenCars(StolenCarPath); 
            }
            
            foreach(string kradenaSPZ in StolenCars)
            {
            if (auto.SPZ == kradenaSPZ) 
                    return true; 
            
            }
             return false;
           
        }
        public static void LoadStolenCars(string file)
        {
            string[] lines = File.ReadAllLines(file);
            foreach(string line in lines)
            {
                StolenCars.Add(line);
            }
            IsLoadedStolenCars = true;
        }
    }
}
