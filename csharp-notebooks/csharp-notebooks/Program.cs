using Newtonsoft.Json;
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
            //var notebooks_array_data = new Notebooks_array();
            //notebooks_array_data.check_value_in_array(7);

            Book[] book_data = Book.getBook();
            string json_data = JsonConvert.SerializeObject(book_data);

            Console.WriteLine(json_data);

            Console.ReadLine();

        } 
    }
}
