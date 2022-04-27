using PrvniKonzolovaApp.Model;
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


// najít prvek s ošetřením pokud nenajde
//var i = cisla.Where(cislo => cislo == 126).FirstOrDefault();

// kolik je kladných čísel?
//var result = cisla.Where(cislo => cislo > 0).Count();
//Console.WriteLine(result);

// vypište sudá čísla
//var result = cisla.Where(cislo => cislo % 2 == 0);
//foreach (var cislo in result)
//{
//    Console.WriteLine(cislo);
//}

// SELECT - transformační operátor (měním prvky které mu předhodím
var absolutnihotnota = cisla.Select(cislo => Math.Abs(cislo));
foreach (var cislo in absolutnihotnota)
{
    Console.WriteLine(cislo);
}