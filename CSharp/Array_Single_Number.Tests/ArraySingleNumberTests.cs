using System;
using Xunit;
using Array_Single_Number;

namespace Array_Single_Number.Tests
{
    public class ArraySingleNumberTests
    {
        [Fact]
        public void TestExample1()
        {
            int[] nums = { 2, 2, 1 };
            var expectedOutput = 1;

            Assert.Equal(expectedOutput, Program.SingleNumber(nums));

        }
        
        [Fact]
        public void TestExample2()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            var expectedOutput = 4;

            Assert.Equal(expectedOutput, Program.SingleNumber(nums));
        }

        [Fact]
        public void TestExample3()
        {
            int[] nums = { 1 };
            var expectedOutput = 1;

            Assert.Equal(expectedOutput, Program.SingleNumber(nums));
        }
    }
}