using System.Globalization;
using Problems.Generated;

namespace LC_Daily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите дату задачи (yyyy-MM-dd): ");
                var input = Console.ReadLine();

                if (input == "clr")
                {
                    Console.Clear();
                    continue;
                }

                if(input == "exit")
                    break;

                if (!DateOnly.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out var date))
                {
                    Console.WriteLine("Неверный формат даты.\n");
                    continue;
                }

                if (ProblemRegistry.TryCreate(date, out var problem))
                {
                    problem!.Execute();
                }
                else
                {
                    Console.WriteLine("Задача для этой даты не найдена.\n");
                }
            }
        }
    }
}
