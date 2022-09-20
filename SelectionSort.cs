
namespace DataStructure
{
    public class SelectionSort
    {
        // Selection Sort is unstable as original position of element not guranteed when duplicate element came up
        // O(n2)
        // usually faster then Bubble Sort as less Swap
        public void Selection(int[] arr)
        {
            // wall start from end
            for (int index = arr.Length-1; index > 0; index--)
            {
                // set largest element index at 0

                int largestAt = 0;

                for (int i = 1; i<= index; i++)
                {
                    if(arr[i] > arr[largestAt])
                    {
                        largestAt = i;
                        
                    }
                    Swap(arr, largestAt, index);
                }
            }

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        } 

        public static void Swap(int[] arr, int i, int j)
        {
            if( i == j ) return;

            (arr[i], arr[j]) = (arr[j], arr[i]);

        }
    }
}
