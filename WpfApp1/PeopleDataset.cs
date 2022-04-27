using PrvniKonzolovaApp.Data;
using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal static class PeopleDataset
    {
        public static List<Person> People = new();

        public static void GeneratePeople(int count)
        {
            People = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                People.Add(RandomPersonGenerator.GetRandomPerson());   
            }
        }
    }
}
