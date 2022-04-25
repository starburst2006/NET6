// See https://aka.ms/new-console-template for more information


Console.WriteLine("zadávejte čísla, po skončení stiskni klávesu q");
 
int soucet = 0;

while(!Console.ReadKey = "q")
{
   int vstup = int.Parse(Console.ReadLine());
   soucet += vstup;

}

Console.WriteLine(soucet);




//string DayOfWeek(DenVTydnu day)
//{

//    switch (day)
//    {
//        case DenVTydnu.PONDELI:
//            return "pondělí";
//        case DenVTydnu.UTERY:
//            return "úterý";
//        case DenVTydnu.STREDA:
//            return "středa";
//        case DenVTydnu.CTVRTEK:
//            return "čtvrtek";
//        case DenVTydnu.PATEK:
//            return "pátek";
//        case DenVTydnu.SOBOTA:
//            return "sobota";
//        case DenVTydnu.NEDELE:
//            return "neděle";
//        default:
//            return "chyba";

//    }
//}

//string den = DayOfWeek(2);
//Console.WriteLine(den);


//int Suma(int a, int b)
//{
//    int sum = a + b;

//    return sum;
//}



//int sum = Suma(10, 15);
//Console.WriteLine(sum);


//enum DenVTydnu
//{
//    PONDELI,
//    UTERY,
//    STREDA,
//    CTVRTEK,
//    PATEK,
//    SOBOTA,
//    NEDELE
//}