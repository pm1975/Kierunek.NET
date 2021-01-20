using System;
using System.IO;
using System.Text;

namespace SkrocKodAplikacji
{
    class Program
    {
        static void Main(string[] args)
        {
            using var stream = new MemoryStream();

            //skrócony if
            var result = 5 > 2 ? 1000m : -1m;

            
            var welcome = "Witaj";
            //interpolacja stringa
            Console.WriteLine($"{welcome} {welcome} And {welcome}");

            
            for (var i = 0; i < 10; i++)
            {
                File.AppendAllText("plik.txt", i < 10 ? "i" : "x");
            }

            
            //bool, który może być nullem
            bool? isAligned = null;
            
            //jeśli jest nullem, przypisz true
            isAligned ??= true;

            //jeśli jest null albo false, to zwróci false
            if (isAligned.GetValueOrDefault()) 
            {
                Console.WriteLine("Button is aligned!");
            }
            else
            {
                Console.WriteLine("Button is not aligned!");
            }


            StringBuilder stringBuilder = null;

            //jeśli stringBuilder będzie nullem, to tego kodu po znaku zapytania nie wykona i nie wywali exception
            var stringFromBuilder = stringBuilder?.ToString();


            var exampleString = "ABCDE";
            //czy zawiera literkę E
            var doesContainE = exampleString.Contains('E');
        }
    }
}
