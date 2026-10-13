namespace TWOSUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = solution.TwoSum(nums, target);

            Console.WriteLine("Indices: [" + string.Join(", ", result) + "]");
        }
    }
}
