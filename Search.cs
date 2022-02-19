using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    /// <summary>
    /// 查找
    /// </summary>
    public class Search
    {

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="orderlyArr">升序数组</param>
        /// <param name="low">起始索引</param>
        /// <param name="high">截至索引</param>
        /// <param name="target">目标值</param>
        /// <returns></returns>
        public int Binary(int[] orderlyArr, int low, int high, int target)
        {
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (orderlyArr[middle] == target)
                {
                    return middle;
                }
                else if (orderlyArr[middle] < target)
                {
                    low = middle + 1;
                }
                else if (orderlyArr[middle] > target)
                {
                    high = middle - 1;
                }
            }
            return -1;
        }
    }
}
