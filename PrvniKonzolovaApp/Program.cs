// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej číslo dne v týdnu:");
int vstup = int.Parse(Console.ReadLine());
string vystup;


switch (vstup)
{
    case 1:
        vystup = "pondělí";
        break;
    case 2:
        vystup = "úterý";
        break;
    case 3:
        vystup = "středa";
        break;
    case 4:
        vystup = "čtvrtek";
        break;
    case 5:
        vystup = "pátek";
        break;
    case 6:
        vystup = "sobota";
        break;
    case 7:
        vystup = "neděle";
        break;
    default: 
        vystup = "chyba";
        break;

}

Console.WriteLine($"Zadal jsi {vstup}, což je {vystup}.");