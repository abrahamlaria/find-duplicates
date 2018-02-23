using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicates
{
    class Program
    {
        public static void FindDuplicates(int[] arr, int size)
        {
            for (var i = 0; i < size; i++)
            {
                var position = i;
                var element = arr[position];
                var abs = Math.Abs(element);
                var sign = arr[abs];
                
                if (arr[Math.Abs(arr[i])] >= 0)
                {
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];                  
                }
                else
                {
                    Console.Write(Math.Abs(arr[i]));
                }          
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 1, 1, 1, 1, 3, 1};
            int size = arr.Length;
            FindDuplicates(arr, size);
            Console.ReadLine();
        }
    }
}
