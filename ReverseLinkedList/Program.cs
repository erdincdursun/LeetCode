namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the head of a singly linked list, reverse the list, and return the reversed list

        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode Prev = null;
            ListNode Curr = head;
            ListNode NextNode = null;

            while (Curr != null)
            {
                NextNode = Curr.next;
                Curr.next = Prev;
                Prev = Curr;
                Curr = NextNode;
            }
            return Prev;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
