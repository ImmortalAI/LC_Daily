using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC_Daily.Problems;
using LC_Daily.Problems._2025._2025_08._2025_08_18;

namespace LC_Daily_Tests._2025._2025_08._2025_08_18
{
    public class Problem_24_Game_Test
    {
        [Fact]
        public void Example1()
        {
            var problem = new Problem_24_Game();

            var result = problem.JudgePoint24([4, 1, 8, 7]);

            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            var problem = new Problem_24_Game();

            var result = problem.JudgePoint24([1, 2, 1, 2]);

            Assert.False(result);
        }
    }
}
