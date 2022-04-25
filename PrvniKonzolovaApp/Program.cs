// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Zadej číslo dne v týdnu:");
//int vstupni_hodnota = int.Parse(Console.ReadLine());
//string den;
//bool vikend = false;

//switch (vstupni_hodnota)
//{
//    case 1:
//        den = "pondělí";
//        break;
//    case 2:
//        den = "úterý";
//        break;
//    case 3:
//        den = "středa";
//        break;
//    case 4:
//        den = "čtvrtek";
//        break;
//    case 5:
//        den = "pátek";
//        break;
//    case 6:
//        den = "sobota";
//        vikend = true;
//        break;
//    case 7:
//        den = "neděle";
//        vikend = true;
//        break;
//    default:
//        den = "chyba";
//        break;

//}

//Console.WriteLine($"Zadal jsi {vstupni_hodnota}, což je {den} a to { vikend ? "je víkend.":"není víkend."});



Console.WriteLine("Zadej číslo");
int vstup = int.Parse(Console.ReadLine());
int vystup = 0; 

for (int i = 1; i <= vstup; i++)
{
    vystup = vystup + i;
}

Console.WriteLine($"součet je {vystup}");
