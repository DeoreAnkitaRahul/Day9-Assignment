using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            FirstName LName = new FirstName();
            Console.WriteLine("Please enter the Last name:");

            string lastName = Console.ReadLine();
            bool val = LName.validateLastName(lastName);

            if (val)
            {
                Console.WriteLine("Last name matched");
            }
            else
            {
                Console.WriteLine("Last name not matched");
            }
            Console.ReadLine();
        }
    }
    
}
