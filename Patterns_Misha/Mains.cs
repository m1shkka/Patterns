using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    class Mains
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("---------SINGLETON---------");
            Person person = new Person();
            person.Born("Mykhailo", "Maksymenko", "Sergiyovuch");
            Console.WriteLine(person.PIB.Name);
            Console.WriteLine(person.PIB.SurName);
            Console.WriteLine(person.PIB.Patronymic);
            Console.WriteLine("------------------");
            person.PIB = PIB.getInstance("Vitya", "Maksymenko", "Romanovich");
            Console.WriteLine(person.PIB.Name);
            Console.WriteLine(person.PIB.SurName);
            Console.WriteLine(person.PIB.Patronymic);

            Console.ReadLine();

            Console.WriteLine("---------BUILDER---------");

            DishBuilder builder;
            Shop shop = new Shop();

            builder = new Borsch();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Vinaigrette();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Puree();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.WriteLine("------------------");
            Console.ReadKey();


            Console.WriteLine("---------FACTORY METHOD---------");


            Garden[] gardens = new Garden[3];

            gardens[0] = new Orchard();
            gardens[1] = new GardenWithoutFruit();
            gardens[2] = new MixedGarden();

            foreach (Garden garden in gardens)
            {
                Console.WriteLine("\n" + garden.GetType().Name + "--");
                foreach (Trees tree in garden.Trees)
                {
                    Console.WriteLine(" " + tree.GetType().Name);
                }
            }

            Console.ReadKey();

            Console.WriteLine("---------DECORATOR---------");

            var auto1 = new BMW();
            var auto2 = new AUDI();

            Print.PrintAuto(auto1);
            Print.PrintAuto(auto2);
            Console.WriteLine("----------------------------------");

            var auto3 = new Insurance(new BMW());
            Print.PrintAuto(auto3);

            Console.ReadKey();

            Console.WriteLine("---------ADAPTER---------");


            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Cat cat = new Cat();
            ITransport CatTransport = new CatAdapter(cat);
            driver.Travel(CatTransport);

            Console.ReadKey();


            Console.WriteLine("---------FACADE---------");

            Menu menu = new Menu();
            menu.ShowMenu();
            Facade facade = new Facade();
            facade.Run();
            Console.ReadKey();

        }
    }
}
