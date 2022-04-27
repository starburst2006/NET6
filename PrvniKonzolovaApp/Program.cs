using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


Car Auto1 = new Car("1B18855",  "červená",  10000,  "Škoda");
Person majitel1 = new Person("Marek", "Bohanes");

Auto1.Majitel = majitel1;

Console.WriteLine($"Auto s SPZ {Auto1.SPZ} vlastní {Auto1.Majitel.FirstName}");