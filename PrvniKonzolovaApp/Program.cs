﻿using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };

//čísla větší než 0
//var result2 = cisla.Where(cislo => cislo > 0);

//// foreach (var cislo in result)
//{
//    Console.WriteLine(cislo);
//}
//podmínky -50 - +50
//var result2 = cisla.Where(cislo => cislo >= -50 && cislo <=50);

//řazení
//var result2 = cisla.OrderByDescending(cislo => cislo);

// iterování výsledkem
//foreach (var cislo in result2)
//{
//    Console.WriteLine(cislo);
//}


// najít prvek
var i = cisla.Where(cislo => cislo == 127).First();


