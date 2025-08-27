using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC_Daily.Problems._2025._2025_08._2025_08_19;
using Problems;

namespace LC_Daily_Tests._2025._2025_08._2025_08_19
{
    public class Problem_Zero_Subarrays_Tests
    {
        [Fact]
        public void Example1()
        {
            var solver = new Problem_Zero_Subarrays();

            var result = solver.ZeroFilledSubarray([1, 3, 0, 0, 2, 0, 0, 4]);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Example2()
        {
            var solver = new Problem_Zero_Subarrays();

            var result = solver.ZeroFilledSubarray([0, 0, 0, 2, 0, 0]);

            Assert.Equal(9, result);
        }

        [Fact]
        public void Example3()
        {
            var solver = new Problem_Zero_Subarrays();

            var result = solver.ZeroFilledSubarray([2, 10, 2019]);

            Assert.Equal(0, result);
        }
    }
}
