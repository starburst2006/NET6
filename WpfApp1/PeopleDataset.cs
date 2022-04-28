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
            RandomPersonGenerator.GetPeople(count);
        }
    }
}
