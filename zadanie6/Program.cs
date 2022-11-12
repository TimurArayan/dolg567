using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    enum LvlAnge
    {
        слабо = 1,
        нормально,
        сильно,
        очень_сильно,
    }
    struct Ded
    {
        public string name;
        public byte lvlanger;
        public string[] phrases;
        public byte hits;
        public Ded(string Name, byte LvlAnger, string[] Phrases, byte Hits)
        {
            this.name = Name;
            this.lvlanger = LvlAnger;
            this.phrases = Phrases;
            this.hits = Hits;
        }
    }
    internal class Program
    {
        static void Task6(Ded ded, params string[] array)
        {
            foreach (string i in ded.phrases)
            {
                if (array.Contains(i))
                {
                    ded.hits += 1;
                }
            }
            Console.WriteLine(ded.hits);
        }


        static void Main(string[] args)
        {
            string[] d1 = { "проституки", "гады" };
            Ded ded1 = new Ded("Иван", 1, d1, 0);
            string[] d2 = { "долбаеб", "блять", "гандон" };
            Ded ded2 = new Ded("Николай", 2, d2, 0);
            string[] d3 = { "сука", "блять", "пиздец", "ебать" };
            Ded ded3 = new Ded("Сергей", 3, d3, 0);
            string[] d4 = { "проституки", "долбаеб", "гады" };
            Ded ded4 = new Ded("Алексей", 4, d4, 0);
            string[] d5 = { "гандон", "сука" };
            Ded ded5 = new Ded("Анатолий", 1, d5, 0);
            string[] slova = { "гады", "блять", "пиздец"};
            string[] baba = { "проституки", "гады", "блять" };
            Task6(ded1, baba);
            Task6(ded2, baba);
            Task6(ded3, baba);
            Task6(ded4, baba);
            Task6(ded5, baba);


        }
    }
}