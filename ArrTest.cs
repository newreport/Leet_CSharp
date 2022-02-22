using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    public class ArrTest
    {

        /// <summary>
        /// 两数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    arr[0] = i;
                    arr[1] = dic[target - nums[i]];
                    return arr;
                }
                else if(!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }

            }
            return arr;
        }
    }
}
