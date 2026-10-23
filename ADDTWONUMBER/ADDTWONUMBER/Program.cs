using static ADDTWONUMBER.Solution;

namespace ADDTWONUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // l1 = 342 (được lưu ngược: 2 -> 4 -> 3)
            ListNode l1 = new ListNode(2,
                            new ListNode(4,
                            new ListNode(3)));

            // l2 = 465 (được lưu ngược: 5 -> 6 -> 4)
            ListNode l2 = new ListNode(5,
                            new ListNode(6,
                            new ListNode(4)));

            Solution solution = new Solution();

            ListNode result = solution.AddTwoNumbers(l1, l2);

            // In kết quả
            Console.Write("Result: ");
            while (result != null)
            {
                Console.Write(result.val);
                if (result.next != null)
                    Console.Write(" -> ");
                result = result.next;
            }

            Console.WriteLine();
        }
    }
}

