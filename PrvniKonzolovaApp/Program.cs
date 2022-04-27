using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


Car Auto1 = new Car("1B18855",  "černá metalýza",  10000,  "Škoda");
Person majitel1 = new Person("Marek", "Bohanes");
//Address address1 = new Address("Mikulovská 8", "Brno", 62800, "Česká republika");

Auto1.Majitel = majitel1;
//Auto1.Majitel.Address = address1;

Console.WriteLine($"Auto s SPZ {Auto1.SPZ} vlastní {Auto1.Majitel.FirstName}");

Auto1.Majitel.Address.City = "Brno";

Console.WriteLine(Auto1.Majitel.Address);