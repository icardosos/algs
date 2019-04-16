namespace algs
{
    public class Sort
    {
        public string InsetionSort()
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
            return string.Join(",", arr);
        }

        public string InsertSort2()
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
            return string.Join(",", arr);
        }

        public string SelectionSort()
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
            return string.Join(",", arr);
        }

        public string BubbleSort()
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
                return string.Join(",", arr);
            }
            return string.Join(",", arr);
        }

    }
}