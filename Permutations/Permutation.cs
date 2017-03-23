using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public static class Permutation
    {
        public static int NextBiggerInteger(int number)
        {
            int[] buff = new int[number.ToString().Length];

            for (int i = buff.Length-1; i > -1; i--)
            {
                buff[i] = number % 10;
                number /= 10;
            }
            return GetNextPermutation(buff);
        }

        private static int GetNextPermutation(int[] perm)
        {
            int swap_index = -1;

            for (int i = 1; i < perm.Length; i++)
                if (perm[i - 1] < perm[i]) swap_index = i - 1;
             
            if (swap_index == -1) return -1;

            int l = swap_index + 1;
            for (int i = l; i < perm.Length; i++)
                if (perm[swap_index] < perm[i])
                    l = i;

            int t = perm[swap_index];
            perm[swap_index] = perm[l];
            perm[l] = t;

            Array.Reverse(perm, swap_index + 1, perm.Length - (swap_index + 1));
            return ConvertResult(perm);
        }

        private static int ConvertResult(int[] arr)
        {
            string buffer = String.Empty;
            foreach (var item in arr)
            {
                buffer += item.ToString();
            }

            int result = Convert.ToInt32(buffer);
            return result;
        }
    }
}
