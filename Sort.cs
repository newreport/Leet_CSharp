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
        /// </summary>
        public void Bubble(int[] arr)
        {
            int temp = 0;
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i-1; j++)
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

    }
}
