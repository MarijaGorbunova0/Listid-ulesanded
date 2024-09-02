using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Listid_ulesanded
{
    public static class Programm
    {
        public static void Main()
        {
            //2
            List<int> randomNumbers = Funct.RandomNumb(20);
            Console.WriteLine("Исходный список чисел:");
            randomNumbers.ForEach(n => Console.Write(n + " "));

           
            List<int> evenNumbers = randomNumbers.Where(n => n % 2 == 0).ToList();
            List<int> oddNumbers = randomNumbers.Where(n => n % 2 != 0).ToList();

           
            List<int> sortNumbers = evenNumbers.Concat(oddNumbers).ToList();

            
            Console.WriteLine("\n\nСписок после сортировки:");
            sortNumbers.ForEach(n => Console.Write(n + " "));
        }
    }
}
