using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ linq = new LINQ();
            linq.FindWordsWithTH();
            linq.NoMoreDuplicates();
            linq.CalculateAverages();
            Console.ReadKey();
        }
    }
}
