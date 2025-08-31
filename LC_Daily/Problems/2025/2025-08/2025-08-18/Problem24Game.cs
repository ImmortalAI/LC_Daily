using Problems;
using System.Numerics;

namespace LC_Daily.Problems._2025._2025_08._2025_08_18
{
    [Problem("2025-08-18")]
    public sealed class Problem24Game : IProblem
    {
        public bool JudgePoint24(int[] cards)
        {
            List<List<double>> input = cards.Select(x => new List<double> { x }).ToList();

            List<double> resultList = Merge(input);

            return resultList.Select(x =>
            {
                if (Math.Abs(24 - x) < 1e-12 && x > 0)
                {
                    return true;
                }
                return false;
            }).Any(x => x);
        }

        private List<double> Merge(List<List<double>> listToMerge)
        {
            if (listToMerge.Count == 0)
            {
                throw new Exception("List is Empty");
            }

            if (listToMerge.Count == 1)
                return listToMerge[0];

            var result = new List<double>();

            for (int i = 0; i < listToMerge.Count - 1; i++)
            {
                for (int j = i + 1; j < listToMerge.Count; j++)
                {
                    var merged = CartesianMerge(listToMerge[i], listToMerge[j],
                        (a, b) => a + b, (a, b) => a - b, (a, b) => b - a,
                        (a, b) => a * b, (a, b) => a / b, (a, b) => b / a)
                        .ToList();

                    var newList = new List<List<double>>(listToMerge);
                    newList.RemoveAt(i);
                    newList.RemoveAt(j - 1);
                    newList.Add(merged);

                    var next = Merge(newList);
                    result = result.Concat(next).Distinct().ToList();
                }
            }

            return result;
        }

        public static IEnumerable<T> CartesianMerge<T>(IEnumerable<T> array, IEnumerable<T> mergeWith, params Func<T, T, T>[] operations) where T : IFloatingPoint<T>
        {
            ICollection<T> result = new HashSet<T>();
            foreach (var item in array)
            {
                foreach (var merge in mergeWith)
                {
                    foreach (var operation in operations)
                    {
                        T operationResult = operation(item, merge);
                        if (T.IsInfinity(operationResult) || T.IsNaN(operationResult))
                            continue;

                        result.Add(operationResult);

                    }
                }
            }
            return result;
        }

        public void Execute()
        {
            List<int> cards = [];
            while (true)
            {
                Console.WriteLine("---------------- 679 ----------------");
                Console.WriteLine("Введите 4 числа через запятую (от 1 до 9)");

                if (Console.ReadLine() is not string input) continue;

                if (input == "exit")
                {
                    Console.WriteLine("---------------- end ----------------\n");
                    return;
                }

                bool failed = false;
                foreach (var item in input.Split(","))
                {
                    if (!int.TryParse(item, out int num) || !(num >= 1 && num <= 9))
                    {
                        failed = true;
                        break;
                    }

                    cards.Add(num);
                }

                if (failed || cards.Count != 4)
                {
                    Console.WriteLine("Ошибка ввода, повторите попытку или выйдите из меню через exit");
                    Console.WriteLine("---------------- end ----------------\n");
                    continue;
                }

                Console.WriteLine($"Result: {JudgePoint24([.. cards])}");
                Console.WriteLine("---------------- end ----------------\n");
            }
        }
    }
}
