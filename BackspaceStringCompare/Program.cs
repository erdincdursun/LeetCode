using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

namespace BackspaceStringCompare
{
   internal class Program
   {
      static void Main(string[] args)
      {
         #region QuestionDescription
         //Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

         //Note that after backspacing an empty text, the text will continue empty.

         //Example 1:

         //Input: s = "ab#c", t = "ad#c"
         //Output: true
         //Explanation: Both s and t become "ac".
         //Example 2:

         //Input: s = "ab##", t = "c#d#"
         //Output: true
         //Explanation: Both s and t become "".
         #endregion

         string s1 = "ab#c";
         string s2 = "ad#c";
         Console.WriteLine(BackspaceCompare(s1, s2)); // true

         s1 = "ab##";
         s2 = "c#d#";
         Console.WriteLine(BackspaceCompare(s1, s2)); // true

         s1 = "a#c";
         s2 = "b";
         Console.WriteLine(BackspaceCompare(s1, s2)); // false

         s1 = "aabb##c#";
         s2 = "b#c#aa##aa";
         Console.WriteLine(BackspaceCompare(s1, s2)); // true
      }
      public static bool BackspaceCompare(string s1, string s2)
      {
         return ProcessString(s1) == ProcessString(s2);
      }
      public static string ProcessString(string s)
      {
         Stack<char> stack = new Stack<char>();
         foreach (char item in s)
         {
            if (item == '#')
            {
               if (stack.Count > 0)
               {
                  stack.Pop();
               }
            }
            else
            {
               stack.Push(item);
            }
         }
         return new string(stack.ToArray());
      }
   }
}
