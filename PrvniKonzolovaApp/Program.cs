using PrvniKonzolovaApp.Model;
using PrvniKonzolovaApp.Data;


List<Person> lide = new();

//vyrobí 50ks náhodných osob
for (int i = 0; i < 50; i++)
{
    lide.Add(RandomPersonGenerator.GetRandomPerson());
}

var result = lide.Where(osoba => osoba.DateOfBirth.Year < 1980).ToList();

foreach (Person osoba in result)
{
    Console.WriteLine(osoba + " " + osoba.DateOfBirth.ToString("yyyy-MM-dd"));
}