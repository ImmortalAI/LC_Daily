using Problems;

namespace LC_Daily.Problems._2025._2025_08._2025_08_19
{
    [Problem("2025-08-19")]
    public class ProblemZeroSubarrays : IProblem
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            int state = 0;
            long result = 0;
            nums = nums.Append(1).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                        state++;
                        break;
                    default:
                        result += ArithmeticSum(state);
                        state = 0;
                        break;
                }
            }
            return result;
        }

        public static long ArithmeticSum(long n)
        {
            return n < 1 ? 0 : n * (n + 1) / 2;
        }

        public void Execute()
        {
            List<int> nums = [];
            while (true)
            {
                Console.WriteLine("---------------- 2348 ----------------");
                Console.WriteLine("Введите числа через запятую:");

                if (Console.ReadLine() is not string input) continue;

                if (input == "exit")
                {
                    Console.WriteLine("---------------- end ----------------\n");
                    return;
                }

                bool failed = false;
                foreach (var item in input.Split(","))
                {
                    if (!int.TryParse(item, out int num))
                    {
                        failed = true;
                        break;
                    }

                    nums.Add(num);
                }

                if (failed)
                {
                    Console.WriteLine("Ошибка ввода, повторите попытку или выйдите из меню через exit");
                    Console.WriteLine("---------------- end ----------------\n");
                    continue;
                }

                Console.WriteLine($"Result: {ZeroFilledSubarray([.. nums])}");
                Console.WriteLine("---------------- end ----------------\n");
            }
        }
    }
}
