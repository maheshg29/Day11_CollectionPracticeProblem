using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_CollectionPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
            int n = int.Parse(Console.ReadLine());
            int[][] chapters = new int[n][];
            for (int i = 0; i < n; i++)
            {
                chapters[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }
            int k = int.Parse(Console.ReadLine());

            // Find the chapter Amelia is currently reading
            int currentChapter = -1;
            for (int i = 0; i < n; i++)
            {
                if (chapters[i][0] <= k && k <= chapters[i][1])
                {
                    currentChapter = i;
                    break;
                }
            }

            // Count the remaining chapters
            int remainingChapters = n - currentChapter;
            Console.WriteLine(remainingChapters);
        }
    }
}
