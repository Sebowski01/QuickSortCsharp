

using System.ComponentModel.Design;

namespace QuickSortCsharp
{
    internal class Program
    {
        static void Main(string[] args) //Here I execute my code and assign my array
        {
            int[] array = { 1, 3, 5, 4, 2 };
            Console.WriteLine("Quick Sort Algorythm");
            Console.WriteLine("--------------------");

            QuickSort(array, 0, array.Length - 1);


        }

        static void QuickSort(int[] arr, int left, int right)
        {
           
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }

            
            
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}