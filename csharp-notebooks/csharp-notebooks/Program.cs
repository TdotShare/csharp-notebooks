using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_notebooks
{
    class notebooks_array
    {
        private int[] array_data = { 1, 2, 3, 4, 5 };

        public void find_value_array()
        {
            int val = array_data.Where(item => item == 1).First();
            Console.WriteLine($"1 => {val}");
        }

        public void filter_value_array()
        {
            int[] val = array_data.Where(item => item > 1).ToArray();
            Console.WriteLine(string.Join(" ", val));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var notebooks_array_data = new notebooks_array();
            notebooks_array_data.filter_value_array();


            Console.ReadLine();

        } 
    }
}
