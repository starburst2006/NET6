using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


List<Person> lide = new();

//vyrobí 50ks náhodných osob
for (int i = 0; i < 50; i++)
{
    lide.Add(RandomPersonGenerator.GetRandomPerson());
}

var result = lide.OrderBy(osoba => osoba.DateOfBirth).Where(osoba => osoba.Address.City == "Brno").First();

//foreach (Person osoba in result)
//{
//    Console.WriteLine(osoba + " " + osoba.DateOfBirth.ToString("yyyy-MM-dd"));
//}

Console.WriteLine(result + " " + result.DateOfBirth.ToString("yyyy-MM-dd") + " " + result.Address.City);
