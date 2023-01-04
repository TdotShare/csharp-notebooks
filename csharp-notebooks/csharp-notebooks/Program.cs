using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_notebooks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5 };
           

            int[] b = a.Where(item => item > 2).ToArray();

            Console.WriteLine(string.Join("\n", b));

            Console.ReadLine();

        }
    }
}
