using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listid_ulesanded
{
    public static class Funct
    {
        //2 
        static Dictionary<string, string> counties = new Dictionary<string, string>
            {
                    { "Таллин", "Харью" },
                    { "Тарту", "Тартумаа" },
                    { "Пярну", "Пярнумаа" },
            };
        public static List<int> RandomNumb(int number)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < number; i++)
            {
                numbers.Add(rand.Next(1, 101));
            }

            return numbers;
        }
        public static void Numbers()
        {
            Console.WriteLine("sis num");
            string numberstr = Console.ReadLine(); 
        }
        public static void Linnad()
        {
            bool flag = false;
            Console.WriteLine("sis number");
            string userinput = Console.ReadLine();
            if (counties.ContainsKey(userinput))
            {
                Console.WriteLine($"Столица {userinput} находится в округе {counties[userinput]}");
            }
            else if(counties.ContainsValue(userinput))
            {
                foreach (var vls in counties) 
                {
                    if (vls.Value == userinput)
                    {
                        Console.WriteLine($"Округ {userinput} имеет столицу {vls.Key}"); 
                        flag = true;
                    }

                }
                if (!flag)
                {
                    Console.WriteLine("kas te tahate uue sisetada")
                }
            }
        }
    }
}

