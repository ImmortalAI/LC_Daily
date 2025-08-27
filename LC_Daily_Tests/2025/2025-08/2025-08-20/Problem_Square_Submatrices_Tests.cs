using LC_Daily.Problems._2025._2025_08._2025_08_20;

namespace LC_Daily_Tests._2025._2025_08._2025_08_20
{
    public class Problem_Square_Submatrices_Tests
    {
        [Fact]
        public void Example1()
        {
            var solver = new Problem_Square_Submatrices();

            var result = solver.CountSquares([[0, 1, 1, 1], [1, 1, 1, 1], [0, 1, 1, 1]]);

            Assert.Equal(15, result);
        }

        [Fact]
        public void Example2()
        {
            var solver = new Problem_Square_Submatrices();

            var result = solver.CountSquares([[1, 0, 1], [1, 1, 0], [1, 1, 0]]);

            Assert.Equal(7, result);
        }
    }
}
