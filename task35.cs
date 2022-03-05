using System;
using System.Linq;

namespace task35
{
    public class Solution
    {
        static int[] SubArr(int[] arr, int n)
        {
            int[] subArr = new int[n];
            for (int i = 0; i < n; i++)
                subArr[i] = arr[i];
            return subArr;
        }

        static bool ArrEqual(int[] arr1, int[] arr2)
        {
            bool eq = true;

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                        continue;
                    else
                    {
                        eq = false;
                        break;
                    }
                }
            }
            else
                eq = false;

            return eq;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] subArr;
            int[] curRes;

            for (int i = 1; i <= n; i++)
            {
                subArr = SubArr(arr, i);
                curRes = subArr;
                for (int j = 1; j < n/i; j++)
                    curRes = curRes.Concat(subArr).ToArray();

                if (ArrEqual(curRes, arr))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
