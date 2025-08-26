using System.Globalization;
using Problems.Generated;

namespace LC_Daily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату задачи (yyyy-MM-dd): ");
            var input = Console.ReadLine();

            if (!DateOnly.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                                        DateTimeStyles.None, out var date))
            {
                Console.WriteLine("Неверный формат даты.");
                return;
            }

            if (ProblemRegistry.TryCreate(date, out var problem))
            {
                problem!.Execute();
            }
            else
            {
                Console.WriteLine("Задача для этой даты не найдена.");
            }
        }
    }
}
