using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalMethod
{
    class otherNum
    {
        public static string AddNumbers(int a, string b = "100")
        {
            //return $" a = {a}, b = {b}, a + b = {a + b}";
            
            int tempValue01 = a ;
            int tempValue02 = Convert.ToInt32(b);;
            int tempValue = tempValue01 + tempValue02;
            string tempTotal = Convert.ToString(tempValue);
            
            return tempTotal;
            
        }

       
    }
}
