using System;
using System.Collections.Generic;

namespace Patterns_Misha
{
    class FactoryMethod

    {
        //static void Main()
        //{
        //    Garden[] gardens = new Garden[3];

        //    gardens[0] = new Orchard();
        //    gardens[1] = new GardenWithoutFruit();
        //    gardens[2] = new MixedGarden();

        //    foreach (Garden garden in gardens)
        //    {
        //        Console.WriteLine("\n" + garden.GetType().Name + "--");
        //        foreach (Trees tree in garden.Trees)
        //        {
        //            Console.WriteLine(" " + tree.GetType().Name);
        //        }
        //    }

        //    Console.ReadKey();
        //}
    }


    abstract class Trees

    {
    }


    class AppleTree : Trees

    {
    }

    class CherryTree : Trees

    {
    }

    class PeachTree : Trees

    {
    }

    class WillowTree : Trees

    {
    }

    class OakTree : Trees

    {
    }

    class BirchTree : Trees

    {
    }


    abstract class Garden

    {
        private List<Trees> trees = new List<Trees>();


        public Garden()
        {
            this.CreateGarden();
        }

        public List<Trees> Trees
        {
            get { return trees; }
        }

        public abstract void CreateGarden();
    }


    class Orchard : Garden
    {
        public override void CreateGarden()
        {
            Trees.Add(new AppleTree());
            Trees.Add(new CherryTree());
            Trees.Add(new PeachTree());
        }
    }

    class GardenWithoutFruit : Garden
    {
        public override void CreateGarden()
        {
            Trees.Add(new OakTree());
            Trees.Add(new WillowTree());
            Trees.Add(new BirchTree());
        }
    }

    class MixedGarden : Garden
    {
        public override void CreateGarden()
        {
            Trees.Add(new AppleTree());
            Trees.Add(new CherryTree());
            Trees.Add(new PeachTree());
            Trees.Add(new OakTree());
            Trees.Add(new WillowTree());
            Trees.Add(new BirchTree());
        }
    }
}
