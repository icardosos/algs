using System;

namespace algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertSort2();
        }

        public static void InsetionSort()
        {
            int[] arr = { 5, 3, 1, 2, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    var atual = arr[j];
                    var anterior = arr[j - 1];
                    if (anterior > atual)
                    {
                        arr[j] = anterior;
                        arr[j - 1] = atual;
                    }
                }
            }
            Console.WriteLine(string.Join(",", arr));
        }

        public static void InsertSort2()
        {
            int[] arr = { 5, 3, 1, 2, 4 };

            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;

            }

            Console.WriteLine(string.Join(",", arr));


        }

        public static void SelectionSort()
        {
            int[] arr = { 1, 3, 1, 2, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                int posicao = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[posicao])
                        posicao = j;
                }

                if (arr[i] != arr[posicao])
                {
                    int temp = arr[i];
                    arr[i] = arr[posicao];
                    arr[posicao] = temp;
                }
            }
            Console.WriteLine(string.Join(",", arr));

        }

        public static void BubbleSort()
        {
            int[] arr = { 5, 3, 1, 2, 4, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.WriteLine(string.Join(",", arr));
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine(string.Join(",", arr));


        }

        public static void BinarySearch()
        {
            int key = 4;
            int[] arr = { 1, 3, 4, 5, 7 };



        }
    }
}
 