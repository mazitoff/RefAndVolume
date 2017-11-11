using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndVolume
{
    class Program
    {
        static void ShowArrays(int[] arr, int[] arr2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("===");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
        static int[] Test01(int[] arr)
        {
            return arr;
        }
        static int[] Test02(int[] arr)
        {
            arr[1] = 34;
            return arr;
        }
        static int[] Test03(int[] arr)
        {
            arr = new int[2];
            arr[0] = 77;
            arr[1] = 88;
            return arr;
        }
        static int[] Test04(ref int[] arr)
        {
            return arr;
        }
        static int[] Test05(ref int[] arr)
        {
            arr[1] = 34;
            return arr;
        }
        static int[] Test06(ref int[] arr)
        {
            arr = new int[2];
            arr[0] = 77;
            arr[1] = 88;
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2 };
            Console.WriteLine("=== Test01 ===");
            int[] arr2 = Test01(arr);
            ShowArrays(arr, arr2);
            Console.WriteLine();
            Console.WriteLine("=== Test02 ===");
            arr2 = Test02(arr);
            ShowArrays(arr, arr2);
            Console.WriteLine("=== Test03 ===");
            arr2 = Test03(arr);
            ShowArrays(arr, arr2);
            Console.WriteLine("=== Test04 ===");
            arr[1] = 1;
            arr2 = Test04(ref arr);
            ShowArrays(arr, arr2);
            Console.WriteLine("=== Test05 ===");
            arr2 = Test05(ref arr);
            ShowArrays(arr, arr2);
            Console.WriteLine("=== Test06 ===");
            arr2 = Test06(ref arr);
            ShowArrays(arr, arr2);
            Console.ReadKey();
        }
    }
}
