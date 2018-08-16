using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Misha
{
    public class Facade
    {
        Menu menu = new Menu();
       // menu.ShowMenu();


        Options options = new Options("Misha", 98765, 10000);

        public void Run()
        {
            options.Opcii();
        }
    }

    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1: Перевірити баланс");
            Console.WriteLine("2: Зняти кошти");
            Console.WriteLine("3: Поповнити рахунок");
            Console.WriteLine("4: Нарахувати відсотки");
            Console.WriteLine("5: Завершити роботу");
            Console.WriteLine();
        }
    }


    public class Options
    {
        private String name;
        private long numAcc;
        private double balance;
        private int percent;
        public Options(String name, long numAcc, double balance)
        {
            this.name = name;
            this.numAcc = numAcc;
            this.balance = balance;
        }
        void perc()
        {
            if (percent > 0)
            {
                balance = balance + (percent * balance / 100);
            }
            else
                Console.WriteLine("Невірний відсоток");
        }

        void deposit(int sum)
        {
            if (sum != 0)
            {
                balance += sum;

            }
            else
                Console.WriteLine("Невірна сума: ");


        }
        void znyatta(int sum)
        {
            if (sum > 0 && sum <= balance)
            {
                balance -= sum;
            }
            else
                Console.WriteLine("Невірна сума: ");
        }


        public void Opcii()
        {
            Console.WriteLine("Вітаємо: " + name);
            Console.WriteLine("id: " + numAcc);
            int an;

            do
            {
                Menu menu = new Menu();
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("Виберіть опцію: ");

                an = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("\n");


                switch (an)
                {
                    case 1:
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine("Баланс: " + balance + " грн.");
                        Console.WriteLine("------------------------------------------------------------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine("Введіть суму: ");
                        int sum = Convert.ToInt32(Console.ReadLine());
                        znyatta(sum);
                        Console.WriteLine("------------------------------------------------------------------------------------\n");
                        break;
                    case 3:
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.Write(": ");
                        Console.Write("ведіть суму: ");
                        int sum1 = Convert.ToInt32(Console.ReadLine());
                        deposit(sum1);
                        Console.WriteLine("------------------------------------------------------------------------------------\n");
                        break;
                    case 4:
                        Console.Write("Введіть відсоток: ");
                        percent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваш відсоток: " + percent + "%");
                        perc();
                        Console.WriteLine("Відсотки успішно нараховані");
                        break;
                    case 5:
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");
                        break;
                }
            }
            while (an != 5);
            Console.WriteLine("Дякуємо що скористалися нашими послугами.");
        }
    }
}
