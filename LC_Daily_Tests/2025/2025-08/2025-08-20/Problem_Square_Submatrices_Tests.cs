using LC_Daily.Problems._2025._2025_08._2025_08_20;
using Newtonsoft.Json.Linq;

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

        [Fact]
        public void TestCase22()
        {
            var solver = new Problem_Square_Submatrices();

            var json = File.ReadAllText("data.json");
            var obj = JObject.Parse(json);

            if (obj["2025-08-20"]?["TestCase22"] is null) 
                Assert.Fail("Отсутствуют необходимые данные для теста в data.json");

            var matrix = obj["2025-08-20"]!["TestCase22"]!.ToObject<int[][]>();
            if (matrix is null) Assert.Fail();
            
            var result = solver.CountSquares(matrix);
            
            Assert.Equal(22859, result);
        }
    }
}
