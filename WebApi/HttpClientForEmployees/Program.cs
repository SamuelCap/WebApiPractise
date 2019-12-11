using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientForEmployees
{
    class Program
    {
        class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string salary { get; set; }
            public override string ToString()
            {
                return $"{firstName}: {lastName}: {gender}: {salary}";
            }
        }
        public static HttpClient webClient = new HttpClient();
        static async Task Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Jake";
            person.lastName = "Feilds";
            person.gender = "Male";
            person.salary = "20";
            Program program = new Program();
            await program.PostEmployee(person);
            await program.GetEmployees();
            Console.ReadLine();
        }
        private async Task PostEmployee(Person person)
        {
            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:56711/api/employees";
            var response = await webClient.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        private async Task GetEmployees()
        {
            string response = await webClient.GetStringAsync("http://localhost:56711/api/employees");
            Console.WriteLine(response);
        }
      
    }
}
