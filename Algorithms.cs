using System;

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

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (int)(high - low) / 2;

                int compare = value.CompareTo(arr[mid]);

                if (compare == 0)
                {
                    return mid;
                }
                else if (compare > 0)
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

        private static void Merge<T>(T[] arr, int start, int mid, int end) where T : IComparable
        {
            T[] temp = new T[end - start + 1];

            int i = start, j = mid + 1, k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i].CompareTo(arr[j]) <= 0)
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

        private static void MergeSort<T>(T[] arr, int start, int end) where T : IComparable
        {
            if (start < end)
            {
                int mid = start + (int)(end - start)/2;

                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        public static void MergeSort<T>(T[] arr) where T : IComparable
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T t = x;

            x = y;
            y = t;
        }

        private static int Partition<T>(T[] arr, int start, int end) where T : IComparable
        {
            int pivot = start - 1;
            for (var i = start; i < end; i++)
            {
                if (arr[i].CompareTo(arr[end]) < 0)
                {
                    pivot++;
                    Swap(ref arr[pivot], ref arr[i]);
                }
            }

            pivot++;
            Swap(ref arr[pivot], ref arr[end]);
            return pivot;
        }

        private static void QuickSort<T>(T[] arr, int start, int end) where T : IComparable
        {
            if (start < end)
            {
                int pivotIndex = Partition(arr, start, end);
                QuickSort(arr, start, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, end);
            }
        }

        public static void QuickSort<T>(T[] arr) where T : IComparable
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public static void SelectionSort<T>(T[] arr) where T: IComparable
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                int t = i;

                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[j].CompareTo(arr[t]) < 0)
                        t = j;
                }

                if (t != i)
                    Swap(ref arr[i], ref arr[t]);
            }
        }

        public static void InsertionSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int j = i;

                while (j != 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    Swap(ref arr[j], ref arr[j - 1]);

                    --j;
                }
            }
        }
    }
}
