using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    public class MainApp
        {

        //public static void Main()
        //{
        //    DishBuilder builder;

        //    Shop shop = new Shop();

        //    builder = new Borsch();
        //    shop.Construct(builder);
        //    builder.Vehicle.Show();

        //    builder = new Vinaigrette();
        //    shop.Construct(builder);
        //    builder.Vehicle.Show();

        //    builder = new Puree();
        //    shop.Construct(builder);
        //    builder.Vehicle.Show();

        //    Console.ReadKey();
        //}
    }

    class Shop
    {
        public void Construct(DishBuilder vehicleBuilder)
        {
            vehicleBuilder.AddPotato();
            vehicleBuilder.AddBeet();
            vehicleBuilder.AddWater();
            vehicleBuilder.AddSourCream();
        }
    }

    abstract class DishBuilder
    {
        protected Dish dish;

        public Dish Vehicle
        {
            get { return dish; }
        }
        public abstract void AddPotato();
        public abstract void AddBeet();
        public abstract void AddWater();
        public abstract void AddSourCream();
    }
    class Borsch : DishBuilder

    {
        public Borsch()
        {
            dish = new Dish("Borzch");
        }

        public override void AddPotato()
        {
            dish["potato"] = "1kg";
        }

        public override void AddBeet()
        {
            dish["beet"] = "0.5kg";
        }

        public override void AddWater()
        {
            dish["water"] = "3 liters";
        }

        public override void AddSourCream()
        {
            dish["SourCream"] = "1 spoon";
        }
    }


    class Vinaigrette : DishBuilder

    {
        public Vinaigrette()
        {
            dish = new Dish("Vinaigrette");
        }

        public override void AddPotato()
        {
            dish["potato"] = "0";
        }

        public override void AddBeet()
        {
            dish["beet"] = "2kg";
        }

        public override void AddWater()
        {
            dish["water"] = "0";
        }

        public override void AddSourCream()
        {
            dish["SourCream"] = "0";
        }
    }
    class Puree : DishBuilder

    {
        public Puree()
        {
            dish = new Dish("Puree");
        }

        public override void AddPotato()
        {
            dish["potato"] = "3kg";
        }

        public override void AddBeet()
        {
            dish["beet"] = "0";
        }

        public override void AddWater()
        {
            dish["water"] = "0.2 liters";
        }

        public override void AddSourCream()
        {
            dish["SourCream"] = "0.5kg";
        }
    }

    class Dish

    {
        private string dishType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();


        public Dish(string DishType)
        {
            this.dishType = DishType;
        }


        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("");
            Console.WriteLine("Dish Type: {0}", dishType);
            Console.WriteLine(" potato : {0}", _parts["potato"]);
            Console.WriteLine(" beet : {0}", _parts["beet"]);
            Console.WriteLine(" water: {0}", _parts["water"]);
            Console.WriteLine(" sour cream : {0}", _parts["SourCream"]);
        }
    }
}
