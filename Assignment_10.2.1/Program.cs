/*
1. Write a program in C# Sharp to find the +ve numbers from a list of numbers using where conditions in LINQ Query.
Input: { 2, -1, 3, -3, 10, -200}
Expected output: {2, 3, 10}
*/

namespace Assignment_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, -1, 3, -3, 10, -200 };

            var numQuery = from num in nums where num >= 0 select num;

            foreach (int num in numQuery)
            {
                Console.Write(num + ",");
            }
        }
    }
}
