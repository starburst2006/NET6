// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej číslo dne v týdnu:");
int vstup = int.Parse(Console.ReadLine());
string vystup;


if (vstup == 1)
{ vystup = "pondělí"; }
else if (vstup == 2)
{ vystup = "úterý"; }
else if (vstup == 3)
{ vystup = "středa"; }
else if (vstup == 4)
{ vystup = "čtvrtek"; }
else if (vstup == 5)
{ vystup = "pátek"; }
else if (vstup == 6)
{ vystup = "sobota"; }
else if (vstup == 7)
{ vystup = "neděle"; }
else { vystup = "špatné číslo"; }

Console.WriteLine($"Zadal jsi {vstup}, což je {vystup}.");