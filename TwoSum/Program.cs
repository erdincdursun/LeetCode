using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum;
internal class Program
{
    static void Main(string[] args)
    {
        #region QuestionDescription
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.You may assume that each input would have exactly one solution, and you may not use the same element twice.You can return the answer in any order.Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
        //Example 2:

        //Input: nums = [3, 2, 4], target = 6
        //Output: [1,2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0,1]
        #endregion

        int[] nums = { 5, 1, 4, 15 };
        int target = 9;

        int[] array = TwoSum(nums, target);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (hashTable.ContainsKey(complement))
            {
                return new int[] { hashTable[complement], i };
            }

            if (!hashTable.ContainsKey(nums[i]))
            {
                hashTable[nums[i]] = i;
            }
        }
        return new int[] { };
    }
}
