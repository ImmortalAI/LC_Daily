using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC_Daily.Problems;
using LC_Daily.Problems._2025._2025_08._2025_08_18;

namespace LC_Daily_Tests._2025._2025_08._2025_08_18
{
    public class Problem24GameTest
    {
        [Fact]
        public void Example1()
        {
            var problem = new Problem24Game();

            var result = problem.JudgePoint24([4, 1, 8, 7]);

            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            var problem = new Problem24Game();

            var result = problem.JudgePoint24([1, 2, 1, 2]);

            Assert.False(result);
        }

        /// <summary>
        /// (3 + 3) / (1 / 4)
        /// </summary>
        [Fact]
        public void DivisionExample()
        {
            var problem = new Problem24Game();

            var result = problem.JudgePoint24([3, 3, 1, 4]);

            Assert.True(result);
        }

        [Fact]
        public void TestCase66()
        {
            var problem = new Problem24Game();

            var result = problem.JudgePoint24([1, 5, 9, 1]);

            Assert.False(result);
        }

        [Fact]
        public void TestCase70()
        {
            var problem = new Problem24Game();

            var result = problem.JudgePoint24([3, 3, 8, 8]);

            Assert.True(result);
        }
    }
}
