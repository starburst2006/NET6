﻿using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Data
{
    internal class StolenCheck
    {
        public static string GetRegisterInfo(string SPZ)
        {
            string status;
            if (SPZ == "1B18855") { status = $"ty jeden uličníku, prodáváš kradené auto SPZ: {SPZ}"; }
            else { status = $"Je to cajk - SPZ: {SPZ}"; }
            return status;
        }
    }
}
