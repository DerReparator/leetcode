using System;
using Xunit;
using Array_Contains_Duplicate;

namespace Array_Contains_Duplicate.Tests
{
    public class ArrayDuplicateTests
    {
        [Fact]
        public void Example1Test()
        {
            int[] input = { 1,2,3,1};
            bool expectedOutput = true;

            Assert.Equal(expectedOutput, Program.ContainsDuplicate(input));
        }

        [Fact]
        public void Example2Test()
        {
            int[] input = { 1, 2, 3, 4 };
            bool expectedOutput = false;

            Assert.Equal(expectedOutput, Program.ContainsDuplicate(input));
        }

        [Fact]
        public void Example3Test()
        {
            int[] input = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool expectedOutput = true;

            Assert.Equal(expectedOutput, Program.ContainsDuplicate(input));
        }
    }
}
