using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    public class Sort
    {
        /// <summary>
        /// 冒泡排序
        /// 
        /// 思想是交换相邻两项的值
        /// 时间复杂度 O(n^2)
        /// </summary>
        public void Bubble(int[] arr)
        {
            int temp = 0;
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(",", arr));
        }

        /// <summary>
        /// 选择排序
        /// 
        /// 思想是选择最小(大)的值，并记录索引
        /// 时间复杂度 O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int index = i;
                int temp = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (temp > arr[j])
                    {
                        index = j;
                        temp = arr[j];
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine(String.Join(",", arr));
        }
    }
}
