using System;
using Xunit;
using FluentAssertions;

namespace Array_Intersection_of_Two_Arrays_II.Tests
{
    public class ArrayIntersectionIITests
    {
        [Fact]
        public void TestExample1()
        {
            var nums1 = new[] { 1, 2, 2, 1 };
            var nums2 = new[] { 2, 2 };
            var expectedOutput = new[] { 2, 2 };

            expectedOutput.Should().BeEquivalentTo(Solution.Intersect(nums1, nums2));
        }

        [Fact]
        public void TestExample2()
        {
            var nums1 = new[] { 4,9,5 };
            var nums2 = new[] { 9,4,9,8,4};
            var expectedOutput = new[] { 4,9 };

            expectedOutput.Should().BeEquivalentTo(Solution.Intersect(nums1, nums2));
        }
    }
}
