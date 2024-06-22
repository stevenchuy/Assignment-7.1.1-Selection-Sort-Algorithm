namespace Assignment_7._1._1_Selection_Sort_Algorithm
{
    /// <summary>
    ///  1. You are a student who has recently taken an exam with your classmates. 
    ///  However, the professor has not yet provided the students with a sorted list of exam scores. 
    ///  To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
    ///  This way, you can obtain the sorted list of scores and see how you performed compared to your classmates. 
    ///  Also, you choose selection sort since that is an easy way of implementation.
    /// </summary>
    internal class Program
    {
        static void SortGrades (int[] grades)
        {
            // One by one move boundary of unsorted subarray
            for (int i = 0;  i < grades.Length; i++)
            {
                // Find the minimum element in unsorted array
                int min_index = i;
                for (int j = i + 1; j < grades.Length; j++)
                    if (grades[j] < grades[min_index])
                        min_index = j;

                // Swap the found minimum element with the first element
                int temp = grades[min_index];
                grades[min_index] = grades[i];
                grades[i] = temp; 
            }
        }
        // Prints the array
        static void Print(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++ )
            {
                Console.Write(" " + grades[i]);
            }
        }

        //Driver code
        static void Main(string[] args)
        {
            int[] grades = { 65, 87, 90, 99, 75, 63 };
            SortGrades (grades);
            Print(grades);
        }
    }
}
