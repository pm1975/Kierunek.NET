using System;
using System.Text;

namespace To20210527
{
    class Program
    {
        static int PrintBeforeCalculation(string[] args)
        {
            string v = "";
            string v1 = "";
            int tasks = 697;
            try
            {
                v = args[0];
                v1 = args[1];
            }
            catch
            {
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
            return tasks;
        }

        static void Main(string[] args)
        {
            int tasks = PrintBeforeCalculation(args);
            var date1 = DateTime.Now;
            var date2 = new DateTime(2021, 05, 27);
            var odds = date2 - date1;
            if (odds.Days < 0)
            {
                Console.WriteLine("Czas minął.");
                Console.ReadKey();
                return;
            }
            string formatDate = "yyyy'-'MM'-'dd";
            Console.WriteLine("{0} dni ({1} tyg.) zostało do {2} ", odds.Days, odds.Days / 7, date2.ToString(formatDate));
            int tasksToDo = 1200 - tasks;
            Console.WriteLine("Zadań do zrobienia (1200 - {0}): {1}", tasks, tasksToDo);
            Console.WriteLine("3 * {0} - {1} = {2}", odds.Days, tasksToDo, (3 * odds.Days) - tasksToDo);
            Console.WriteLine("2 * {0} - {1} = {2}", odds.Days, tasksToDo, (2 * odds.Days) - tasksToDo);
            Console.WriteLine("Robiąc po 5 skończysz: {0}.", date1.AddDays(tasksToDo / 5).ToString(formatDate));
            PrintOptions(tasks, odds.Days);
            Console.WriteLine("");
        }

        static void PrintOptions(int tasks, int days)
        {
            int resultCheckInIf;
            int dontShow = -1 * (3 * days / 7);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 0 * 5 + 5 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 0 * 5 + 5 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 1 * 5 + 3 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 1 * 5 + 3 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 0 * 5 + 6 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 0 * 5 + 6 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (1 * 9 + 0 * 5 + 2 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (1 * 9 + 0 * 5 + 2 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (1 * 9 + 1 * 5 + 0 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (1 * 9 + 1 * 5 + 0 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 1 * 5 + 5 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 1 * 5 + 5 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 2 * 5 + 3 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 2 * 5 + 3 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 3 * 5 + 1 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 3 * 5 + 1 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 2 * 5 + 4 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 2 * 5 + 4 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (1 * 9 + 2 * 5 + 0 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (1 * 9 + 2 * 5 + 0 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (2 * 9 + 0 * 5 + 1 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (2 * 9 + 0 * 5 + 1 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 3 * 5 + 3 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 3 * 5 + 3 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
            resultCheckInIf = tasks + (days / 7 * (0 * 9 + 4 * 5 + 1 * 2)) - 1200;
            if (resultCheckInIf < 0 && resultCheckInIf > dontShow)
                Console.WriteLine("{0} + ({1}/7 * (0 * 9 + 4 * 5 + 1 * 2)) - 1200 = {2}", tasks, days, resultCheckInIf);
        }
    }
}
