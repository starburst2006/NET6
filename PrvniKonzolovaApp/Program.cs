// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej číslo dne v týdnu:");
int vstup = int.Parse(Console.ReadLine());
string vystup;
bool vikend_bool = false;
string vikend;

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
        vikend_bool = true;
        break;
    case 7:
        vystup = "neděle";
        vikend_bool = true;
        break;
    default: 
        vystup = "chyba";
        break;

}
if (vikend_bool) { vikend = "je víkend"; } else { vikend = "není víkend"; };
Console.WriteLine($"Zadal jsi {vstup}, což je {vystup} a to {vikend}");