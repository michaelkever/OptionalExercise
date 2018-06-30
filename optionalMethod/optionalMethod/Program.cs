using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            otherNum otherNum = new otherNum();
            //Console.WriteLine(otherNum.AddNumbers(10));
            //Console.ReadLine();

            //Console.WriteLine(otherNum.AddNumbers(100, 1000));
            //Console.ReadLine();

            Console.WriteLine("Choose a number to add to another optional number. Your number is a in the math problem a + b =. \n Press Enter:");
            int userInput01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another number or hit enter to except the default number; which is 100.");
            string userInput02 = Convert.ToString(Console.ReadLine());
            if (userInput02 == null)
            {
                Console.WriteLine(otherNum.AddNumbers(userInput01));
            }
            else
            {
                int actualTotal = Convert.ToInt32(otherNum.AddNumbers(userInput01, userInput02));
                Console.WriteLine("the result is: " + actualTotal);
                Console.ReadLine();
            }
            
            Console.ReadLine();

            
            
            
            
        }
    }
}
