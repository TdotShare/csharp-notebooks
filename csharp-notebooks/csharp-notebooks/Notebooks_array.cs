using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_notebooks
{
    internal class Notebooks_array
    {
        private int[] array_data = { 1, 2, 3, 4, 5 };

        public void find_value_array()
        {
            int val = array_data.Where(item => item == 1).First();
            Console.WriteLine($"val => {val}");
        }

        public void filter_value_array()
        {
            int[] val = array_data.Where(item => item > 1).ToArray();
            Console.WriteLine(string.Join(" ", val));
        }
        public void check_value_in_array(int number)
        {
            if (array_data.Contains(number))
            {
                Console.WriteLine("found Data !!");
            }
            else
            {
                Console.WriteLine("Not found Data !!");
            }
        }

        public void add_data_array(int number)
        {
            array_data = array_data.Append(number).ToArray();

            Console.WriteLine(string.Join(" ", array_data));
        }
    }
}
