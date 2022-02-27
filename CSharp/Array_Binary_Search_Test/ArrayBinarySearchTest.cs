using Xunit;
using Array_Binary_Search;

namespace Array_Binary_Search_Test
{
    public class ArrayBinarySearchTest
    {
        [Fact]
        public void TestExample1()
        {
            int[] inputNums = { -1, 0, 3, 5, 9, 12 };
            var inputTarget = 9;
            var expectedOutput = 4;
            var dut = new Program();

            var output = dut.Search(inputNums, inputTarget);

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void TestExample2()
        {
            int[] inputNums = { -1, 0, 3, 5, 9, 12 };
            var inputTarget = 2;
            var expectedOutput = -1;
            var dut = new Program();

            var output = dut.Search(inputNums, inputTarget);

            Assert.Equal(expectedOutput, output);
        }
    }
}
