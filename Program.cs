using System;

namespace algs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new[] { 0, 0, 0, 1, 0, 0 };
            int jumps = 0;

            for (int x = 0; x <= c.Length - 2; x++)
            {
                if (x != c.Length - 2 && c[x + 2] == 0)
                    x++;

                jumps++;
            }
            Console.WriteLine(jumps);
    }
    }
}
