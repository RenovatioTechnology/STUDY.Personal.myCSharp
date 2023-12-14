using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare delegate, and return type
delegate int CalculateDelegate(int num);

namespace coreConsoleApplication
{
    internal class DelegateExample
    {
        // Start Here!
        static int number = 100;
        // Declaring integer addition method which has one input parameter of integer type
        //as the signature of delegate says that whatever number I have I will just do number equals to number plus
        public static int Addition(int num)
        {
            number = number + num;  
            return number;
        }
        // Multiple Methods 
        public static int Multiplication(int num)
        {
            number = number + num;
            return number;
        }
        // To return what is in static number type 
        public static int getNumber()
        {
            return number; 
        }
    }
}
