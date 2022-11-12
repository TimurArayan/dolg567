using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Task5()
        {

            var numbers = new Dictionary<int, string>()
            {
                [0] = "###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###",
                [1] = " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###",
                [2] = " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###",
                [3] = "## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ",
                [4] = "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###",
                [5] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ",
                [6] = " ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###",
                [7] = "###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ",
                [8] = "###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###",
                [9] = "###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###",
            };
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("Введите число или закройте строку: ");
                string x = Console.ReadLine();
                if (x.Equals("exit") || x.Equals("закрыть"))
                {
                    flag = false;
                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        int vvod = int.Parse(x);
                        if (vvod >= 0 && vvod <= 9)
                        {
                            Console.WriteLine(numbers[vvod]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!!!");
                            System.Threading.Thread.Sleep(3000);
                            Console.ResetColor();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите цифру или exit ");
                    }

                }

            }


        }
        static void Main(string[] args)
        {
            Task5();
        }
    }
}
