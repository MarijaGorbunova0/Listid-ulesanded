using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Listid_ulesanded
{
    public class Toode
    {
        public string Nimi { get; set; }
        public double Kalorid { get; set; }

        public Toode(string nimi, double kalorid)
        {
            Nimi = nimi;
            Kalorid = kalorid;
        }
    }

    public class Book
    {
        public string Nimetus { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string nimetus, string author, int year)
        {
            Nimetus = nimetus;
            Author = author;
            Year = year;
        }   
    }
        public static class Programm
    {
        public static void Main()
        { 
            // 5 oma
            Funct.Raamatukogu();
            Console.WriteLine("1. Linnad");
            // 4 
            Funct.Linnad();
            //3
            Console.WriteLine("\n2. Tooded");
            Funct.Tooded();
            //2
            Funct.ProcessNumbers(20);
        }
    }
}
