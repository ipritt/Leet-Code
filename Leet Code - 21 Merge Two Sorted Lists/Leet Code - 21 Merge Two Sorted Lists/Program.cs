Console.WriteLine(MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4)))));

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummy = new ListNode(-1);
    ListNode current = dummy;

    while(list1 != null && list2 != null)
    {
        if(list1.val < list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }

    current.next = list1 ?? list2;
    return dummy.next;
}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
