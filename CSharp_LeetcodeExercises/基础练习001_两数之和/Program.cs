/*
 *【 时间】
 * 
 * 【题目】
 * 给定一个整数数组 nums 和一个目标值 target，
 * 请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
 * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
 * 示例:
 * 给定 nums = [2, 7, 11, 15], target = 9
 * 因为 nums[0] + nums[1] = 2 + 7 = 9
 * 所以返回 [0, 1]
来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/two-sum

 * 【要点】
 * 
 * 
 */
using System;

namespace 基础练习001_两数之和
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexs = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        // indexs = new int[] { i,j};
                        indexs[0] = i;
                        indexs[1] = j;
                        break;
                    }
                }
            }
            return indexs;
        }//TwoSum()
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 15, 11, 20,7,8,7};
            int target = 9;
            Solution s = new Solution();
            int[] indexs =  s.TwoSum(nums, target);

            Console.WriteLine("下标为第{0}个数:{1} + 下标为第{2}个数:{3} = 9",indexs[0],nums[indexs[0]],indexs[1], nums[indexs[1]]);
            Console.ReadKey();
        }
    }
}
