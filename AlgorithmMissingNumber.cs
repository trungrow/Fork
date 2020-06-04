using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlgorithmMissingNumber
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 2, 3, 1, 4, 6, 9, 7, 8, 10, 7 };
            FindMissingNumber(arr);
        }

        public static void FindMissingNumber(List<int> arr)
        {
            int max = arr.Max();
            List<int> compare = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                compare.Add(i);
            }
            for (int i = 0; i < compare.Count; i++)
            {
                var key = false;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (compare[i] == arr[j])
                        key = true;
                }
                if (!key) Console.WriteLine(compare[i]);
            }
        }
    }
}
