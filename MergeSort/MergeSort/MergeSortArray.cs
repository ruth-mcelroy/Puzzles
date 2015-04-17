using System;


namespace MergeSort
{
    class MergeSortArray
    {

        void mergeArray(int[] array, int startPoint, int midPoint, int endPoint)
        {
            int[] sorted = new int[endPoint - startPoint + 1];      //array for storing merged array size= sum both arrays to be merged

            int i = startPoint, j = midPoint + 1, k = 0;            // Go through both arrays from start and store the smallest element of both to sorted array  
            while (i <= midPoint && j <= endPoint)
            {
                if (array[i] < array[j])
                {
                    sorted[k] = array[i];
                    k++;
                    i++;
                }
                else
                {
                    sorted[k] = array[j];
                    k++;
                    j++;
                }
            }

            while (i <= midPoint)                                   // If there is any element remain in first array then add it to temp array
            {
                sorted[k] = array[i];
                k++;
                i++;
            }

            while (j <= endPoint)                                   // If any element remain in second array then add it to temp array
            {
                sorted[k] = array[j];
                k++;
                j++;
            }



            k = 0;
            i = startPoint;                                         // Traverse temp array and store element of temp array to original array, works as out parameter cause parameter copy refers original material so change to referal changes original material.
            while (k < sorted.Length && i <= endPoint)
            {
                array[i] = sorted[k];
                i++;
                k++;
            }
        }

        void mergesort(int[] arr, int start, int end)               // Recursive Merge Procedure
        {
            if (start < end)
            {
                int mid = (end + start) / 2;                        //finding midpoint and so splitting array into 2
                mergesort(arr, start, mid);                         //recursivly splitting first half into half
                mergesort(arr, mid + 1, end);                       //recursivly splitting second half into half
                mergeArray(arr, start, mid, end);                    // merging  all halfs
            }
        }




        // Main driver function
        static void Main(string[] args)
        {

            int[] arr = { 5, 9, 2, 3, 6, 4, 11, 10, 8, 14 }; // this is the array to be sorted

            MergeSortArray merge = new MergeSortArray();

            // Calling Merge Procedure
            merge.mergesort(arr, 0, arr.Length - 1);

            // Printing Sorted array. after merge sort
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}