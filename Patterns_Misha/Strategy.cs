using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    class Strategy
    {
        //static void Main()
        //{

        //    double side = 4;
        //    double diagonal = side * Math.Sqrt(2);

        //    AreaByside areaByside = new AreaByside();
        //    AreaByDiagonal areaByDiagonal = new AreaByDiagonal();

        //    areaByDiagonal.Area(diagonal);
        //    areaByside.Area(side);

        //    Console.WriteLine("area by side=" + areaByside.Area(side));
        //    Console.WriteLine("area by diagonal=" + areaByDiagonal.Area(diagonal));

        //    Console.ReadKey();
        //}
    }


        abstract class SquareArea
        {
            public abstract double Area(double parameter);
        }


        class AreaByside : SquareArea

        {
            public override double Area(double side)
            {
                return side * side;
            }
        }

        class AreaByDiagonal : SquareArea

        {
            public override double Area(double diagonal)
            {
                return (1 / 2) * (diagonal * diagonal);
            }

        }

        class Area

        {
            private double side;
            private double diagonal;

            private SquareArea _squareArea;

            public void SetSquareArea(SquareArea squarearea)
            {
                this._squareArea = squarearea;
            }

            public double Sort()
            {
                return side * side;
            }
        }
    }


