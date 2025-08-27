using Problems;

namespace LC_Daily.Problems._2025._2025_08._2025_08_20
{
    [Problem("2025-08-20")]
    public class Problem_Square_Submatrices : IProblem
    {
        public int CountSquares(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            var transposed = TransposeMatrix(matrix);

            for(int i = 0; i < n; i++)
            {
                for(int j = 0;  j < m; j++)
                {

                }
            }

            return 0;
        }

        public int[][] TransposeMatrix(int[][] matrix)
        {
            if (matrix.Length == 0) return [];

            int n = matrix.Length;
            int m = matrix[0].Length;

            int[][] newMatrix = new int[m][];

            for (int j = 0; j < m; j++)
            {
                int[] row = new int[n];
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

                    bool failed = false;
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
