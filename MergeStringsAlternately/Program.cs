using Microsoft.VisualBasic;
using System.Text;

namespace MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region QuestionDescription
            //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

            //Return the merged string.
            //Example 1:

            //Input: word1 = "abc", word2 = "pqr"
            //Output: "apbqcr"
            //Explanation: The merged string will be merged as so:
            //word1: a b   c
            //word2:    p q   r
            //merged: a p b q c r
            //Example 2:

            //Input: word1 = "ab", word2 = "pqrs"
            //Output: "apbqrs"
            //Explanation: Notice that as word2 is longer, "rs" is appended to the end.
            //word1: a b
            //word2: p q   r s
            //merged: a p b q   r s
            #endregion

            string word1 = "ab c";
            string word2 = " pq r";
            //result = apbqcr 
            Console.Write(MergeStrings(word1, word2)); 

        }

        public static string MergeStrings(string word1, string word2)
        {
            int i = 0, j = 0;
            int len1 = word1.Length, len2 = word2.Length;
            StringBuilder merged = new StringBuilder();

            while (i < len1 && j < len2)
            {
                merged.Append(word1[i]);
                merged.Append(word2[j]);
                i++;
                j++;
            }

            // Append remaining characters from word1, if any
            while (i < len1)
            {
                merged.Append(word1[i]);
                i++;
            }

            // Append remaining characters from word2, if any
            while (j < len2)
            {
                merged.Append(word2[j]);
                j++;
            }

            return merged.ToString();
        }
    }

}
