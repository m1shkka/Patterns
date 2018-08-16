using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    public abstract class AutoBase
    {
        protected String Description = "";

        public String GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();


    }


    class BMW : AutoBase
    {

        public BMW()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Description = "BMW X5 — среднеразмерный кроссовер от немецкого автопроизводителя";
        }

        public override double GetCost()
        {
            return 25000;
        }
    }

    class AUDI : AutoBase
    {

        public AUDI()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Description = "Audi A8 — автомобиль представительского класса, преемник модели Audi V8";
        }

        public override double GetCost()
        {
            return 31500;
        }
    }

    class Insurance : AutoBase
    {
        private readonly AutoBase _autoBase;

        public Insurance(AutoBase autoBase)
        {
            Console.OutputEncoding = Encoding.UTF8;

            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + СТРАХОВКА на год";
            }
        }

        public override double GetCost()
        {
            double cost = 500;
            if (_autoBase != null)
            {
                cost += _autoBase.GetCost();
            }
            return cost;
        }
    }

    //class Decoretor { 
    //static void Main(string[] args)
    //{
    //var auto1 = new BMW();
    //var auto2 = new AUDI();

    //Print.PrintAuto(auto1);
    //    Print.PrintAuto(auto2);
    //    Console.WriteLine("----------------------------------");

    //    var auto3 = new Insurance(new BMW());
    //Print.PrintAuto(auto3);

    //        Console.ReadKey();
    //}
    //}

    public static class Print
    {
        public static void PrintAuto(AutoBase auto)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0} \nСтоимость: {1}$", auto.GetDescription(), auto.GetCost());
            Console.WriteLine("---");
        }
    }
}
