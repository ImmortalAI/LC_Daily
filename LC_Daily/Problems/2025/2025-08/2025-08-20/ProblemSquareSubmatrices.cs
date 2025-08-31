using Problems;

namespace LC_Daily.Problems._2025._2025_08._2025_08_20
{
    [Problem("2025-08-20")]
    public class ProblemSquareSubmatrices : IProblem
    {
        public int CountSquares(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;

            var incrementor = new int[n][];
            for (int r = 0; r < n; r++)
            {
                incrementor[r] = new int[m];
            }

            incrementor[0][0] = matrix[0][0];
            for (int i = 1; i < n; i++)
            {
                incrementor[i][0] = matrix[i][0];
            }
            for (int j = 1; j < m; j++)
            {
                incrementor[0][j] = matrix[0][j];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        incrementor[i][j] = 0;
                        continue;
                    }
                    
                    incrementor[i][j] = Math.Min(Math.Min(incrementor[i][j - 1], incrementor[i - 1][j]), 
                        incrementor[i-1][j-1]) + 1;
                }
            }

            return incrementor.Sum(x => x.Sum());
        }

        public int[][] TransposeMatrix(int[][] matrix)
        {
            if (matrix.Length == 0) return [];

            var n = matrix.Length;
            var m = matrix[0].Length;

            var newMatrix = new int[m][];

            for (int j = 0; j < m; j++)
            {
                var row = new int[n];
                for (int i = 0; i < n; i++)
                {
                    
                    row[i] = matrix[j][i];
                }
                newMatrix[j] = row;
            }

            return newMatrix;
        }

        public static long SquaresSum(long n)
        {
            return n < 1 ? 0 : n * (n + 1) * (2 * n + 1) / 6;
        }

        public void Execute()
        {
            List<int[]> nums = [];
            while (true)
            {
                Console.WriteLine("---------------- 1277 ----------------");
                Console.WriteLine("Введите матрицу через запятую и Enter:");

                while (true)
                {
                    if (Console.ReadLine() is not string input) continue;

                    if (input == "exit")
                    {
                        Console.WriteLine("---------------- end ----------------\n");
                        return;
                    }

                    if (string.IsNullOrEmpty(input))
                        break;

                    var failed = false;
                    var parsed = input.Split(",").Select(x =>
                    {
                        if (int.TryParse(x, out int n))
                            return n;
                        failed = true;
                        return 0;
                    }).ToArray();

                    if (failed || (nums.Count != 0 && parsed.Length != nums[0].Length))
                    {
                        Console.WriteLine("Ошибка ввода, повторите попытку или выйдите из меню через exit");
                        Console.WriteLine("---------------- end ----------------\n");
                        continue;
                    }
                    nums.Add(parsed);
                }

                Console.WriteLine($"Result: {(nums.Count == 0 ? 0 : CountSquares([.. nums]))}");
                Console.WriteLine("---------------- end ----------------\n");
            }
        }
    }
}
