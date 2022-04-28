using PrvniKonzolovaApp.Data;
using PrvniKonzolovaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal static class PeopleDataset
    {
        public static List<Person> People = new();
        public static string PeopleAPIUrl = "https://localhost:7178";

        public static object HTTPclient { get; private set; }

        public static void GeneratePeople(int count)
        {
            RandomPersonGenerator.GetPeople(count);
        }
        public static async Task LoadPeopleFromAPI(int cnt)
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetAsync(PeopleAPIUrl + "/people/" + cnt.ToString());
            
            if (result.IsSuccessStatusCode)
            {
                People = await result.Content.ReadFromJsonAsync<List<Person>>();
            }
        
        
        }
    }
}
