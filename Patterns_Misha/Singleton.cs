using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Person person = new Person();
        //    person.Born("Mykhailo", "Maksymenko", "Sergiyovuch");
        //    Console.WriteLine(person.PIB.Name);
        //    Console.WriteLine(person.PIB.SurName);
        //    Console.WriteLine(person.PIB.Patronymic);

        //    person.PIB = PIB.getInstance("Vitya", "Maksymenko",  "Romanovich");
        //    Console.WriteLine(person.PIB.Name);
        //    Console.WriteLine(person.PIB.SurName);
        //    Console.WriteLine(person.PIB.Patronymic);

        //    Console.ReadLine();
        //}
    }
    class Person
    {
        public PIB PIB { get; set; }
        public void Born(string Name, string surname, string patronymic)
        {
            PIB = PIB.getInstance(Name, surname, patronymic);
        }
    }
    class PIB
    {
        private static PIB instance;

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Patronymic { get; private set; }

        protected PIB(string name, string surname, string patronymic)
        {
            this.Name = name;
            this.SurName = surname;
            this.Patronymic = patronymic;
        }

        public static PIB getInstance(string name, string surname, string patronymic)
        {
            if (instance == null)
                instance = new PIB(name, surname, patronymic);
            return instance;
        }
    }
}
