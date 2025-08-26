using Problems;

namespace LC_Daily.Problems._2025._2025_08._2025_08_18
{
    [Problem("2025-08-18")]
    public sealed class Problem_24_Game : IProblem
    {
        public bool JudgePoint24(int[] cards)
        {
            return false;
        }

        public void Execute()
        {
            List<int> cards = [];
            while (true)
            {
                Console.WriteLine("Введите 4 числа через запятую (от 1 до 9)");

                if(Console.ReadLine() is not string input) continue;

                bool failed = false;
                foreach (var item in input.Split(","))
                {
                    if(!int.TryParse(item, out int num) || !(num >= 1 && num <= 9))
                    {
                        failed = true;
                        break;
                    }
                    
                    cards.Add(num);
                }
                if(failed || cards.Count != 4) continue;

                JudgePoint24([.. cards]);
            }
        }
    }
}
