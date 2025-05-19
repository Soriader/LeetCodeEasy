namespace LeetCodeEasy;

public class RemoveDuplicatesFromSortedListTask
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == null)
        {           
            return null;
        }
        
        ListNode current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}
//https://leetcode.com/problems/remove-duplicates-from-sorted-list/