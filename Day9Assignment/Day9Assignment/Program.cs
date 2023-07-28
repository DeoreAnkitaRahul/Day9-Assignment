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
            FirstName passWord = new FirstName();
            Console.WriteLine("Please enter the Password:");

            string Pass = Console.ReadLine();
            bool val = passWord.ValidatePassword(Pass);

            if (val)
            {
                Console.WriteLine("Password matched");
            }
            else
            {
                Console.WriteLine("Password not matched");
            }
            Console.ReadLine();
        }
    }
    
}
