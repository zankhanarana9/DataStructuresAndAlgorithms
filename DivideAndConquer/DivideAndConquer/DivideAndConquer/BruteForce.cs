using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class BruteForce
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length < 1) return 0;
            int max = nums[0];
            for(int i=0; i <nums.Length; i++)
            {
                int sum = 0;
                for(int j =i; j<nums.Length; j++)
                {
                    sum += nums[j];
                    if(sum > max)
                    {
                        max = sum;
                    }
                }
            }
            return max;
        }
    }
}
