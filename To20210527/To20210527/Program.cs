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
            int tasks = 593;
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
            if (odds.Days < 0)
            {
                Console.WriteLine("Czas minął.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("{0} dni zostało do {1}.", odds.Days, date2.ToString("yyyy'-'MM'-'dd"));
            Console.WriteLine("{0} tygodni.", odds.Days / 7);
            Console.WriteLine("1200 - {0} = {1}", tasks, 1200 - tasks);
            Console.WriteLine("3 * {0} = {1}", odds.Days, 3 * odds.Days);
            Console.WriteLine("{0} - {1} = {2}", 3 * odds.Days, 1200 - tasks, (3 * odds.Days) - (1200 - tasks));
            Console.WriteLine((1200.0 - tasks)/odds.Days);
            Console.WriteLine("");
            Console.WriteLine("{0} + ({1}/7 * (0 * 5 + 6 * 2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , tasks + (odds.Days/7 * (0 * 5 + 6 * 2)) - 1200);
            Console.WriteLine("{0} + ({1}/7 * (1 * 5 + 5 * 2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , tasks + (odds.Days/7 * (1 * 5 + 5 * 2)) - 1200);
            Console.WriteLine("{0} + ({1}/7 * (2 * 5 + 4 * 2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , tasks + (odds.Days/7 * (2 * 5 + 4 * 2)) - 1200);
            Console.WriteLine("{0} + ({1}/7 * (3 * 5 + 3 * 2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , tasks + (odds.Days/7 * (3 * 5 + 3 * 2)) - 1200);
            Console.WriteLine("{0} + ({1}/7 * (4 * 5 + 1 * 2)) - 1200 = {2}"
                , tasks
                , odds.Days
                , tasks + (odds.Days/7 * (4 * 5 + 1 * 2)) - 1200);
            Console.ReadKey();
        }
    }
}
