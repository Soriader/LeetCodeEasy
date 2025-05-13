using NUnit.Framework.Interfaces;

namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class MergeTwoSortedListsTest
{
    [Test]
    public void MergeTwoSortedLists()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

        var result = MergeTwoSortedListsTask.MergeTwoLists(list1, list2);

        Assert.IsTrue(AreListsEqual(expected, result));
    }

    private bool AreListsEqual(ListNode list1, ListNode list2)
    {
        while (list1 != null && list2 != null)
        {
            if (list1.val != list2.val)
                return false;
            list1 = list1.next;
            list2 = list2.next;
        }
        return list1 == null && list2 == null;
    }
}