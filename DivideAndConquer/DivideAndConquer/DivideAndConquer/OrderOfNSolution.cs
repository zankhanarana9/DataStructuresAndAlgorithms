using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class OrderOfNSolution
    {
        public int MaxSubArrayKadanesAlgo(int[] nums)
        {
            if (nums.Length < 1) return 0;
            int max_so_far = nums[0];
            int max_ending = nums[0];

            for(int i = 1; i < nums.Length ;  i++)
            {
                //max_ending += nums[i];
                max_ending = Math.Max(nums[i], max_ending + nums[i]);
                max_so_far = Math.Max(max_ending, max_so_far);
                
            }
            return max_so_far;
        }
    }
}
