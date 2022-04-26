using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


Car Auto1 = new Car("1B18855",  "červená",  10000,  "Škoda");

StolenCheck.LoadStolenCars(StolenCheck.StolenCarPath);

if (!StolenCheck.IsError) { 
bool result = StolenCheck.GetRegisterInfo(Auto1);
if (result) Console.WriteLine("Kradené");
else Console.WriteLine("OK");
}
else 
    Console.WriteLine("nelze zkontrolovat");