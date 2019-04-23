using System;
using System.Collections.Generic;

namespace algs
{
    public static class HackHank
    {
        public static int sockMerchantN2(int n, int[] ar)
        {
            int count = 0;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = i + 1; j < n; j++)
                {

                    if (ar[i] == 0) break;

                    if (ar[i] == ar[j])
                    {
                        ar[i] = ar[j] = 0;
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
        public static int sockMerchantN(int n, int[] ar)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                int currentValue = 0;
                if (dic.TryGetValue(ar[i], out currentValue))
                    dic[ar[i]] = currentValue + 1;
                else
                    dic.Add(ar[i], 1);
            }

            int pairs = 0;
            foreach (var item in dic.Values)
                pairs += item >> 1;

            return pairs;
        }
        public static int countingValleys(int n, string s)
        {
            int valley = 0;
            var path = s.ToCharArray();
            int seaLevel = 0;

            for (int x = 0; x < n; x++)
            {
                if (path[x] == 'D')
                    seaLevel--;
                else if (path[x] == 'U')
                {
                    seaLevel++;
                    if (seaLevel == 0)
                        valley++;
                }
            }

            return valley;
        }
        public static long repeatedString(string s, long n)
        {
            var array = s.ToCharArray();
            int countA = 0;
            int countLeft = 0;
            long total  = 0;

            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] == 'a')
                    countA++;
            }

            long multiplier = n / array.Length;
            total = multiplier * countA;

            long left = n % array.Length;
            for (int x = 0; x < left; x++)
            {
                if (array[x] == 'a')
                    countLeft++;
            }

            total += countLeft;

            return total;
        }
    }
}