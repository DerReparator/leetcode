using System;
using _0704_Binary_Search;
using Xunit;

namespace _0704_Binary_SearchTests
{
    public class UnitTestExamples
    {
        [Fact]
        public void TestExample1()
        {
            int[] inputNums = {-1,0,3,5,9,12};
            var inputTarget = 9;
            var expectedOutput = 4;
            var dut = new Program();
            
            var output = dut.Search(inputNums, inputTarget);

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void TestExample2()
        {
            int[] inputNums = {-1,0,3,5,9,12};
            var inputTarget = 2;
            var expectedOutput = -1;
            var dut = new Program();
            
            var output = dut.Search(inputNums, inputTarget);

            Assert.Equal(expectedOutput, output);
        }
    }
}
