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
            var notebooks_array_data = new Notebooks_array();
            //notebooks_array_data.add_data_array(9);

            notebooks_array_data.delete_vale_array(4);



            //Book[] book_data = Book.getBook();
            //string json_data = JsonConvert.SerializeObject(book_data);


            Console.ReadLine();

        }
    }
}
