namespace algorithms
{
    public class Algorithms
    {
        public static double Degree(double num, int x)
        {
            double c = num;
            int d = x;
            double r = 1;

            while (d > 0)
            {
                if (d % 2 == 1)
                    r *= c;

                d = d / 2;
                c *= c;
            }

            return r;
        }

        public static double DegreeMod(double num, int x, int mod)
        {
            double c = num % mod;
            int d = x;
            double r = 1;

            while (d > 0)
            {
                if (d % 2 == 1)
                    r = (r * c) % mod;

                d = d / 2;
                c = (c * c) % mod;
            }

            return r;
        }

        public static int BitwiseDegree(int num, int x)
        {
            int c = num;
            int d = x;
            int r = 1;

            while (d > 0)
            {
                if ((d & 00000001) == 1)
                    r *= c;

                d = d >> 1;
                c *= c;
            }

            return r;
        }

        public static int BitwiseDegreeMod(int num, int x, int mod)
        {
            int c = num % mod;
            int d = x;
            int r = 1;

            while (d > 0)
            {
                if ((d & 00000001) == 1)
                    r = (r * c) % mod;

                d = d >> 1;
                c = (c * c) % mod;
            }

            return r;
        }

        public static int BinarySearch(int[] arr, int value)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (value == arr[mid])
                {
                    return mid;
                }
                else if (value > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static long Fibonacci(int n)
        {
            long a = 1, b = 0;

            while (n > 0)
            {
                long t = a;
                a += b;
                b = t;
                --n;
            }

            return b;
        }

        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= end)
            {
                temp[k++] = arr[j++];
            }

            for (i = start; i <= end; i++)
            {
                arr[i] = temp[i - start];
            }
        }

        private static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        public static void MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        private static void Swap(ref int x, ref int y)
        {
            int t = x;

            x = y;
            y = t;
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = start - 1;
            for (var i = start; i < end; i++)
            {
                if (arr[i] < arr[end])
                {
                    pivot++;
                    Swap(ref arr[pivot], ref arr[i]);
                }
            }

            pivot++;
            Swap(ref arr[pivot], ref arr[end]);
            return pivot;
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(arr, start, end);
                QuickSort(arr, start, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, end);
            }
        }

        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
    }
}
