using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class MaxSubArrayRecursion
    {
        public int MaxSubArrayRecursive(int[] nums)
        {
            if(nums.Length < 1)
            {
                return 0;
            }
            int res = MaxSubArray(nums, 0, nums.Length - 1);
            return res;
        }

        private int MaxSubArray(int[] nums, int low, int high)
        {
            int res;
            if (low == high)
            {
                return nums[low];
            }
            else
            {
                int mid = (low + high) / 2;
                int leftMax = MaxSubArray(nums, low, mid);
                int rightMax = MaxSubArray(nums, mid + 1, high);
                int crossMax = CrossOverMax(nums, low, mid, high);
                if (crossMax >= leftMax && crossMax >= rightMax)
                {
                    res = crossMax;
                }
                else if (leftMax >= crossMax && leftMax >= rightMax)
                {
                    res = leftMax;
                }
                else
                {
                    res = rightMax;
                }
            }
            return res;
        }

        private int CrossOverMax(int[] nums, int low, int mid, int high)
        {
            int sum = 0;
            int left_sum = int.MinValue;
            int right_sum = int.MinValue;
            for (int i = mid; i >= low; i--)
            {
                sum += nums[i];
                if (sum > left_sum)
                {
                    left_sum = sum;
                }
            }
            sum = 0;
            for (int i = mid + 1; i <= high; i++)
            {
                sum += nums[i];
                if (sum > right_sum)
                {
                    right_sum = sum;
                }
            }
            return Math.Max(Math.Max(left_sum, right_sum), (left_sum + right_sum));
        }
    }
}

