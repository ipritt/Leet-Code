Console.WriteLine(TestCycleExists());

static bool TestCycleExists()
{
    // Setup input: [3, 2, 0, -4]
    ListNode node4 = new(-4);
    ListNode node0 = new(0);
    ListNode node2 = new(2);
    ListNode head = new(3);

    head.next = node2;
    node2.next = node0;
    node0.next = node4;

    // Setup the cycle condition - comment out for other tests
    node4.next = node2;

    return HasCycle(head);
}

static bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
        {
            return true;
        }
    }

    return false;
}

public class ListNode(int x)
{
    public int val = x;
    public ListNode next = null;
}