using NUnit.Framework;
using SortApi.Services;

namespace NUnitSortApiTest
{
    public class SortTest
    {
        [Test]
        public void Test_sorting()
        {
            var sortService = new BubbleSortService();
            var result = sortService.GetSortedArray("5,1,2,4,3");
            Assert.AreEqual("1,2,3,4,5", result.after);
        }

        [Test]
        public void Test_sorting_with_repeating_data()
        {
            var sortService = new BubbleSortService();
            var result = sortService.GetSortedArray("5,1,2,4,3,1");
            Assert.AreEqual("1,1,2,3,4,5", result.after);
        }
    }
}