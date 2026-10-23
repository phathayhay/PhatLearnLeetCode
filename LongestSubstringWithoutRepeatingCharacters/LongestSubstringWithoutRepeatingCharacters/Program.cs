namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Test case 1
            string s1 = "abcabcbb";
            Console.WriteLine(solution.LengthOfLongestSubstring(s1));
            // Output: 3

            // Test case 2
            string s2 = "bbbbb";
            Console.WriteLine(solution.LengthOfLongestSubstring(s2));
            // Output: 1

            // Test case 3
            string s3 = "pwwkew";
            Console.WriteLine(solution.LengthOfLongestSubstring(s3));
            // Output: 3
        }
    }
}
