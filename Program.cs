namespace Yousource.Strategy.App
{
    using System;

    /**
     * Instructions:
     * Use the Strategy Pattern to implement the different Sorting Algorithms: BubbleSort (given as an example), Quick Sort and Merge Sort
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sort Strategy (bubblesort, quicksort, mergesort). Defaults to bubblesort");
            ISortStrategy strategy = default;

            var input = Console.ReadLine();
            input = input.ToLower();

            if (input == "bubblesort")
            {
                strategy = new BubbleSort();
            }        
            else if (input == "quicksort")
            {
                strategy = new QuickSort();
            }
            else if (input == "mergesort")
            {
                strategy = new MergeSort();
            }

            // Implement other strategies here based on the strategy inputted by the user

            Console.WriteLine("Enter String to Sort");
            var value = Console.ReadLine();

            Console.Write("The sorted string is: " + strategy.Sort(value));

            Console.ReadKey();
        }
    }
}
