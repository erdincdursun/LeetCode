using System.Runtime.CompilerServices;

namespace FindMiddleNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode MiddleNodeRecursive(ListNode head)
            {
                return Helper(head, head.next);
            }
            ListNode MiddleNode(ListNode head)
            {
                //check if head is null pointer to avoid exceptions
                if (head is null) return null;

                //fasterPtr walks twice as fast slowPtr
                ListNode slowPtr = head;
                ListNode fasterPtr = head.next;

                //loop through the linked list until fasterPtr becomes null-pointer
                while (fasterPtr is not null)
                {
                    slowPtr = slowPtr.next;
                    //check if it has become null to avoid exception (happens with even length)
                    fasterPtr = fasterPtr.next;
                    if (fasterPtr is not null)
                        fasterPtr = fasterPtr.next;
                }
                return slowPtr;
            }
        }

        //Recursive
        public static ListNode Helper(ListNode slowPointingNode, ListNode fastPointingNode)
        {
            if (fastPointingNode == null) return slowPointingNode;
            else if (fastPointingNode.next == null) return slowPointingNode.next;
            else return Helper(slowPointingNode.next, fastPointingNode.next.next);
        }

    }
}



