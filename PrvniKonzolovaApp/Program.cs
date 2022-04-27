using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


int[] cisla = { 2, 43, 22, 12, 54, -5, 41, 127, 90, -25, -71, 45 };

var result = cisla.Where(cislo => cislo > 0);

foreach (var cislo in result)
{
    Console.WriteLine(cislo);
}
