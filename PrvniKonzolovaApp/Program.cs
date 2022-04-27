using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };

var result = cisla.Where(cislo => cislo > 0);

//// foreach (var cislo in result)
//{
//    Console.WriteLine(cislo);
//}

//var result2 = cisla.Where(cislo => cislo >= -50 && cislo <=50);

var result2 = cisla.OrderByDescending(cislo => cislo);


foreach (var cislo in result2)
{
    Console.WriteLine(cislo);
}