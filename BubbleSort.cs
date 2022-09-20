
namespace DataStructure
{
    // in-place algorithm - Use small amount of extra memory (doesnt depend on n)
    // Stable
    // O(n2)
    // Degrade quickly 
    public class BubbleSort
    {

        public void Bubble(int[] arr)
        {
            // loop from back i.e the wall - it will shift one place from right.
            for (int index = arr.Length-1 ; index > 0 ; index--)
            {
                for (int i = 0; i < index; i++)
                {
                    // if we use >= in place of > then it will replace two equal value integer that make 
                    // the algorithm unstable
                    // Stable algo is when we preserve the relative order of element in case of equal.
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                    }
                }

            }

            for(int i = 0; i <= arr.Length-1; i++)
            {
                Console.WriteLine(arr[i]);  
            }
        }
        private static void Swap(int[] arr, int i, int j)
        {
            if (i == j)
                return;
            // tuple swap - after C# 7
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }
}
