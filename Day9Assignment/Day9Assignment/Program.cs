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
            FirstName moNum = new FirstName();
            Console.WriteLine("Please enter the Mobile Number:");

            string num = Console.ReadLine();
            bool val = moNum.ValidateMobileNumber(num);

            if (val)
            {
                Console.WriteLine("Mobile number matched");
            }
            else
            {
                Console.WriteLine("Mobile number not matched");
            }
            Console.ReadLine();
        }
    }
    
}
