using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{

    /// <summary>
    /// 数列
    /// </summary>
    public class SeriesNums
    {

        /// <summary>
        /// 斐波拉契
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int FibonacciNums(int x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            return FibonacciNums(x - 1) + FibonacciNums(x - 2);
        }

    }
}
