using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    class Adapter
    {

        //static void Main(string[] args)
        //{
        //    Driver driver = new Driver();
        //    Auto auto = new Auto();
        //    driver.Travel(auto);
        //    Cat cat = new Cat();
        //    ITransport CatTransport = new CatAdapter(cat);
        //    driver.Travel(CatTransport);

        //    Console.Read();
        //}
    }

    interface ITransport
    {
        void Drive();
    }

    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Cat : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Кот гуляет по дивану");
        }
    }

    class CatAdapter : ITransport
    {
        Cat cat;
        public CatAdapter(Cat c)
        {
            cat = c;
        }

        public void Drive()
        {
            cat.Move();
        }
    }
}
