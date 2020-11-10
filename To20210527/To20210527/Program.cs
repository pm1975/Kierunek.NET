using System;
using System.Text;

namespace To20210527
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = "";
            string v1 = "";
            int tasks = 545;
            try
            {
                v = args[0];
                v1 = args[1];
            }
            catch {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Brak ilości zadań. Domyślnie " + tasks);
                builder.AppendLine("SPOSÓB UŻYCIA:");
                builder.AppendLine("    -d <ilość zadań>");
                Console.WriteLine(builder);
            }
            switch (v)
            {
                case "-h":

                        break;
                case "-d":
                    int.TryParse(v1, out tasks);
                    break;
                default:
                    break;
            }
            var date1 = DateTime.Now;
            var date2 = new DateTime(2021,05, 27);
            var odds = date2 - date1;
            Console.WriteLine(odds.Days + " dni.");
            Console.WriteLine((1200.0 - tasks)/odds.Days);
            Console.WriteLine("");
            Console.WriteLine("({0} + ({1}*2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , (tasks + (odds.Days * 2)) - 1200);
            Console.ReadKey();
        }
    }
}
