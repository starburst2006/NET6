// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej číslo A:");
double Cislo_A = double.Parse(Console.ReadLine());

Console.WriteLine("Zadej číslo B:");
double Cislo_B = double.Parse(Console.ReadLine());

Console.WriteLine("Zadej číslo B:");
double Cislo_C = double.Parse(Console.ReadLine());

double nejvetsi_cislo = 0;

if (Cislo_A > Cislo_B && Cislo_A > Cislo_C)
{
   nejvetsi_cislo = Cislo_A;
}
else if (Cislo_B > Cislo_A && Cislo_B > Cislo_C) 
    {
    nejvetsi_cislo = Cislo_B;
    }
else nejvetsi_cislo = Cislo_C;

Console.WriteLine($"Největší je číslo {nejvetsi_cislo}");