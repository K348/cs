using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First app using C#!");
            
            int first_variable_to_add,
                second_variable_to_add;

            int result_of_adding = 0;

            Console.WriteLine("Type first number");
            first_variable_to_add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type second number");
            second_variable_to_add = Convert.ToInt32(Console.ReadLine());

            result_of_adding = first_variable_to_add + second_variable_to_add;
            Console.WriteLine("Wynik");
            Console.Write(result_of_adding);
            while (true) ;
        }
    }
}
