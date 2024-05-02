namespace DataStructures.SortingAlgorithms;

public class MergeSorter
{
    public static int[] Sort(int[] arr)
    { 
        return MergeSort(arr, 0, arr.Length);
    }

    private static int[] MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            var mid = (left + right) / 2;
            var leftArr = MergeSort(arr, left, mid);
            var rightArr = MergeSort(arr, mid + 1, right);
            return Merge(leftArr, rightArr);
        }

        return new int[] { arr[left] };
    }

    private static int[] Merge(int[] leftArr, int[] rightArr)
    {
        var newArr = new int[] { };
        var index = 0;

        // If left array contains smaller elements
        if (leftArr[0] < rightArr[0])
        { 
            while (leftArr[index] < rightArr[0])
            {
                newArr[index] = leftArr[index];
                index++;
            }

            // append the rest 
            for (index = 0; index < rightArr.Length; index++)
            {
                newArr[newArr.Length + index] = rightArr[index];
            }
        }
        else
        {
            
            // If right array contains smaller elements
            while (rightArr[index] <= leftArr[0])
            {
                newArr[index] = rightArr[index];
                index++;
            }
            // append the rest 
            for (index = 0; index < leftArr.Length; index++)
            {
                newArr[newArr.Length + index] = leftArr[index];
            }
        } 

        return newArr;
    }
    
}