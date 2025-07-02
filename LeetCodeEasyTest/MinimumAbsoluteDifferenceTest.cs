using Xunit;
using Assert = NUnit.Framework.Assert;

namespace LeetCodeEasyTest;

public class MinimumAbsoluteDifferenceTest
{
    [Test]
    public void MinimumAbsoluteDifference()
    {
        int[] arr = { 1, 3, 6, 10, 15 };
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 3 }
        };

        var result = MinimumAbsoluteDifferenceTask.MinimumAbsDifference(arr);

        Assert.AreEqual(expected, result);
    }
}