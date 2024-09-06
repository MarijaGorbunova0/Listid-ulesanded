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
                    {"Tallinn", "Harju" },
                    { "Tartu", "Tartumaa" },
                    { "Pärnu", "Pärnu maakond" },
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

        //ülesanne 2
        public static void ProcessNumbers(int count)
        {
            List<int> randomNumbers = RandomNumb(count);
            Console.WriteLine("Algne numbrite loend:");
            randomNumbers.ForEach(n => Console.Write(n + " "));

            List<int> evenNumbers = randomNumbers.Where(n => n % 2 == 0).ToList();
            List<int> oddNumbers = randomNumbers.Where(n => n % 2 != 0).ToList();

            List<int> sortNumbers = evenNumbers.Concat(oddNumbers).ToList();

            Console.WriteLine("\nSortitud numbrite loend:");
            sortNumbers.ForEach(n => Console.Write(n + " "));
        }
        // ülesanne 4
        public static void Linnad()
        {
            bool flag = false;
            Console.WriteLine("sis maakond");
            string userinput = Console.ReadLine();
            if (counties.ContainsKey(userinput))
            {
                Console.WriteLine($"Osakonna {userinput} pealinn asub {counties[userinput]} maakonnas");
            }
            else if (counties.ContainsValue(userinput))
            {
                foreach (var vls in counties)
                {
                    if (vls.Value == userinput)
                    {
                        Console.WriteLine($"{userinput} pealinn on {vls.Key}");
                        flag = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("kas te tahate uue sisetada");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    Console.WriteLine("kirjutage pealinn");
                    string capital = Console.ReadLine().Trim();
                    Console.WriteLine("kirjutage maakond");
                    string county = Console.ReadLine().Trim();
                    counties[capital] = county;
                    Console.WriteLine("Uus andmepaar on lisatud.");
                }
                else
                {
                    Console.WriteLine("ok");
                }

            }
        }
        // ülesanne 3
        public static void Tooded()
        {
            var tooted = new List<Toode>
                {
                    new Toode("Õun", 52),
                    new Toode("Banaan", 89),
                    new Toode("Kanafilee", 165),
                    new Toode("Riis", 130),
                    new Toode("Kartul", 77),
                    new Toode("Brokkoli", 34),
                    new Toode("Munad", 155)
                };


            Console.WriteLine("Sisestage oma kaal (kg): ");
            double kaal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisestage oma pikkus (cm): ");
            double pikkus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisestage oma vanus (aastat): ");
            int vanus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisestage oma sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();


            double sbi;
            if (sugu == "mees")
            {
                sbi = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
            }
            else
            {
                sbi = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
            }

            Console.WriteLine("Sisestage oma füüsiline aktiivsus (1 Istuv, 2 Vähene aktiivsus, 3 Mõõdukas aktiivsus, 4  Kõrge aktiivsus, 5  Väga kõrge aktiivsus): ");
            int aktiivsusTase = Convert.ToInt32(Console.ReadLine());

            double kaloridPaevas = 0;
            switch (aktiivsusTase)
            {
                case 1:
                    kaloridPaevas = sbi * 1.2;
                    break;
                case 2:
                    kaloridPaevas = sbi * 1.375;
                    break;
                case 3:
                    kaloridPaevas = sbi * 1.55;
                    break;
                case 4:
                    kaloridPaevas = sbi * 1.725;
                    break;
                case 5:
                    kaloridPaevas = sbi * 1.9;
                    break;
                default:
                    Console.WriteLine("Vigane sisestus.");
                    return;
            }
            Console.WriteLine($"Teie päevane kalorivajadus on  {kaloridPaevas:F2} kalorit.");
            Console.WriteLine("\nTe võite päevas tarbida järgmisi toiduaineid:");
            foreach (var toode in tooted)
            {
                double kogus = kaloridPaevas / toode.Kalorid;
                Console.WriteLine($"{toode.Nimi}: {kogus:F2} grammi");
            }
        }
        // 5 oma. Ma tegin raamatukogu kus voib lisada raamatud, kustuda neid ja vaata 
        public static void Rammatukogu()
        {
            List<Book> library = new List<Book>
            {
                new Book("The Catcher in the Rye", "J.D. Salinger", 1951),
                new Book("To Kill a Mockingbird", "Harper Lee", 1960)
            };

            int valik = 0;

            while (valik != 6)
            {
                Console.WriteLine(
                    "Valige valik:\n" +
                    "1. Lisa raamat\n" +
                    "2. Eemalda raamat\n" +
                    "3. Otsi raamatut\n" +
                    "4. Vaata kõiki raamatuid\n" +
                    "5. Välju"
                );

                valik = int.Parse(Console.ReadLine());

                if (valik == 1)
                {
                    Console.WriteLine("Kirjutage raamatunimi ");
                    string UusNimi = Console.ReadLine();
                    Console.WriteLine("Kirjutage autorit ");
                    string UusAutor = Console.ReadLine();
                    Console.WriteLine("Kirjutage aasta ");
                    int UusAasta = int.Parse(Console.ReadLine());

                    library.Add(new Book(UusNimi, UusAutor, UusAasta));
                    Console.WriteLine("Raamat lisatud edukalt");
                }
                else if (valik == 2)
                {
                    Console.WriteLine("Sisestage eemaldatava raamatu nimi ");
                    string raamatNimi = Console.ReadLine();
                    var emaldaRaamat = library.Find(book => book.Nimetus.Equals(raamatNimi, StringComparison.OrdinalIgnoreCase));

                    if (emaldaRaamat != null)
                    {
                        library.Remove(emaldaRaamat);
                        Console.WriteLine("Raamat eemaldati edukalt");
                    }
                    else
                    {
                        Console.WriteLine("Raamatut ei leitud");
                    }
                }
                else if (valik == 3)
                {
                    Console.WriteLine("Sisestage otsitava raamatu nimi ");
                    string raamatNimi = Console.ReadLine();
                    var otsiRaamat = library.Find(book => book.Nimetus.Equals(raamatNimi, StringComparison.OrdinalIgnoreCase));

                    if (otsiRaamat != null)
                    {
                        Console.WriteLine($"Raamat leitud {otsiRaamat.Nimetus} - {otsiRaamat.Author} ({otsiRaamat.Year})");
                    }
                    else
                    {
                        Console.WriteLine("Raamatut ei leitud");
                    }
                }
                else if (valik == 4)
                {
                    Console.WriteLine("Raamatukogu ");
                    foreach (var book in library)
                    {
                        Console.WriteLine($"{book.Nimetus} - {book.Author} ({book.Year})");
                    }
                }
                else if (valik == 5)
                {
                    Console.WriteLine("Programm lõpetatud");
                }
                else
                {
                    Console.WriteLine("Vale valik proovige uuesti");
                }
            }
        }
    }
}
