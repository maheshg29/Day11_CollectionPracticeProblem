using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_CollectionPracticeProblem
{
    public class ChaptersCount
    {
        public void RemainingChapters()
        {
            Console.WriteLine("Please Enter How many chapters in Your Book");
            int chapterCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNow Enter starting page and end page of each chapter one by one e.g. 1 4 for chapter one and then 6 8 for chapter 2");
            List<Tuple<int, int>> chaptersPage = new List<Tuple<int, int>>();
            for (int i = 0; i < chapterCount; i++)
            {
                int[] pages = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                chaptersPage.Add(new Tuple<int, int>(pages[0], pages[1]));
            }
            Console.WriteLine("\n now Enter current page number which you reading");
            int currentPage=Convert.ToInt32(Console.ReadLine());

            int currentChapter = 0;
            for (int i = 0; i < chapterCount; i++)
            {
                if (chaptersPage[i].Item1 <= currentPage && currentPage <= chaptersPage[i].Item2)
                {
                    currentChapter = i;
                    break;
                }
            }

            // Count the remaining chapters
            int remainingChapters = chapterCount - currentChapter;
            Console.WriteLine("\nThe number of chapters yet to read is " + remainingChapters);
        }
    }
}
