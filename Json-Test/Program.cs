using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Json_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Sabrina = new Person()
            {
                Alter = 32,
                Vornahme = "Sabrina",
                Nachname = "Mustermann",
                Sprachen = new List<string> { "Deutsch", "Englisch" }
            };

            string Json=JsonConvert.SerializeObject(Sabrina,Formatting.Indented);
            Console.WriteLine(Json);
            //Ausgabe
            //{
            //    "Vornahme": "Sabrina",
            //    "Nachname": "Mustermann",
            //    "Alter": 32,
            //    "Sprachen": [
            //            "Deutsch",
            //            "Englisch"
            //            ]
            // }

            Person newPerson = JsonConvert.DeserializeObject<Person>(Json);
            Console.WriteLine(newPerson.Vornahme);
            //foreach (var item in newPerson)
            //{

            //}

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Vornahme { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        public List<string> Sprachen { get; set; }
    }

}
