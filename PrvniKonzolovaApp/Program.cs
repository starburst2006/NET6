using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;



Car Auto1 = new Car("1B58855",  "červená",  10000,  "Škoda");

bool result = StolenCheck.GetRegisterInfo(Auto1);

if (result) Console.WriteLine("Kradené");
else Console.WriteLine("OK");
