# Find Duplicates
Solution to the "Find Duplicates" problem in C#

## Problem

Given an array of n elements which contains elements from 0 to n-1, with any of these numbers appearing any number of times.
Find these repeating numbers in O(n) and using only constant memory space.

### Example

Input:

```
[1, 4, 3, 1, 4, 4, 8]
```

Output:

```
1 4 4
```

## Algorithm

* Iterate over the array from 0 to n - 1 elements.
* Check for the sign of array[abs[array[i]]]
* If positive (+) then
* Make it negative (-) by array[abs[array[i]]] = - array[abs[array[i]]]
* Else // i.e., A[abs(A[i])] is negative
* This element (ith element of the array) is a repetition

## Solution

```
using System;

namespace FindDuplicates
{
    class Program
    {
        public static void FindDuplicates(int[] arr, int size)
        {
            for (var i = 0; i < size-1; i++)
            {
                /*var position = i;
                var element = arr[position];
                var abs = Math.Abs(element);
                var sign = arr[abs];*/ //Code to help debug it.
                
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
            int[] arr = {1, 4, 3, 1, 4, 4, 8};
            int size = arr.Length;
            FindDuplicates(arr, size);
            Console.ReadLine();
        }
    }
}
```
