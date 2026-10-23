using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            // vi tri bat dau chuoi con
            int left = 0;
            int maxLength = 0;
            int startIndex = 0;
            // right la vi tri can xet
            for (int right = 0; right < s.Length; right++)
            {
                while (chars.Contains(s[right]))
                {
                    chars.Remove(s[left]);
                    left++;
                }
                chars.Add(s[right]);

                int length = right - left + 1;

                if (length > maxLength)
                {
                    maxLength = length;
                    startIndex = left;
                }
            }
            // luu do dai lon nhat tim dc
            return maxLength;
        }
    }
}
