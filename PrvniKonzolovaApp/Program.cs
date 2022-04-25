// See https://aka.ms/new-console-template for more information
Console.WriteLine("napiš teplotu ve stupních Celsia");
string vstup = Console.ReadLine();

double teplota_C = double.Parse(vstup);

double teplota_F = (1.8  * teplota_C) + 32;

Console.WriteLine($"Teplota = {teplota_C}°C je {teplota_F}°F");
