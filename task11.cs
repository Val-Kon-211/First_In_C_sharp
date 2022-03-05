using System;

namespace task11
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 7)
                Console.WriteLine("preschool child");
            else if (n < 18)
            {
                Console.WriteLine("schoolchild " + (n - 6));
            }
            else if (n < 23)
                Console.WriteLine("student " + (n - 17));
            else
                Console.WriteLine("specialist");
        }
    }
}
