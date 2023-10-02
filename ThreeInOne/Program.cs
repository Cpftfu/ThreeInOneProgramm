using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeInOne
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("У НАС В НАЛАЧИИ ЕСТЬ НЕСКОЛЬКО ПРИКОЛЬНЫХ ПРОГРАММОК :");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. угадай число");
            Console.WriteLine("2. табличка умножения");
            Console.WriteLine("3. вывод делителей числа");
            Console.WriteLine("4. закрыть программку");

            while (true)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("выберите программку которую вы хотите запустить :");
                string act = Console.ReadLine();
                int action = Convert.ToInt32(act);
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = ugadai();
                            break;
                        }
                    case 2:
                        {
                            result = tablichka();
                            break;
                        }
                    case 3:
                        {
                            result = deliteli();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ладно, пака");
                            Environment.Exit(0);
                            break;
                        }

                }
                Console.WriteLine("жмякните ENTER для выбора других программок", result);
                Console.ReadKey();
            }
        }

//угадай число
        public static int ugadai()
        {
            Random ran = new Random();
            int pobeda = ran.Next(0, 50);
            bool beda = false;
            do
            {
                Console.WriteLine("УГАДАЙ ЧИСЛО ОТ 0 ДО 50");
                string v = Console.ReadLine();
                int i = int.Parse(v);
                if (i > pobeda)
                {
                    Console.WriteLine("ну размахнулись, надо меньше!");
                }
                else if (i < pobeda)
                {
                    Console.WriteLine("маловато, надо больше!");
                }
                else if (i == pobeda)
                {
                    Console.WriteLine("урa-ура!!!");
                    beda = true;
                }
            } while (beda == false);

            int result = 1;
            return result;
        }

 //матрица таблички умножения
        public static int tablichka()
        {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("круто классно, теперь у нас есть табличка");
            int result = 1;
                return result;
        }

 //делители числа
        public static int deliteli()
        {
            Console.WriteLine("введите пажавуста число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            int result = 1;
            return result;
        }
    }

}
//канец
//я очень устала :с
