using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolutionUseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons = GeneratePerson();
           

            string filepath = @"e:\mytemp\newfile.csv";
            //GenericTextFileProccessor.SaveToTextFile(persons, filepath);
            Console.WriteLine("------------------------------");
            Console.ReadLine();
            persons= GenericTextFileProccessor.LoadFromTextFile<Person>(filepath);
            Console.WriteLine("Firstname \t Lastname \t Age \t Birthdate");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.fistName} \t {p.lastName} \t {p.age} \t {p.birthDate.ToShortDateString()}");
            }
            Console.ReadLine();

        }

        public static List<Person> GeneratePerson()
        {
            List<Person> outList = new List<Person>();
            outList.Add(new Person() { fistName = "Alireza", lastName = "Mohammadi", age = 20, birthDate = DateTime.Parse("1980/04/03") });

            outList.Add(new Person() { fistName = "Sara", lastName = "Jafari", age = 30, birthDate = DateTime.Parse("1990/04/03") });

            outList.Add(new Person() { fistName = "Karim", lastName = "Gholami", age = 24, birthDate = DateTime.Parse("1988/04/03") });

            outList.Add(new Person() { fistName = "Reza", lastName = "Fazeli", age = 37, birthDate = DateTime.Parse("1979/04/03") });

            return outList;
        }
    }
}
