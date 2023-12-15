using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    //The Publisher Model
    internal class EventsExample
    {
        // Declare Delegate
        public delegate void Delegate_OddNumber();
        // Declare Event to point to Delegate_OddNumber()
        public event Delegate_OddNumber Event_OddNumber;

        // Delegate can hold the reference addition because addition has no parameters and return type is also void
        public void Addition()
        {
            int num1, num2, result;
            Console.Write("Enter number one: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number one: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("Result is: " + result);

            // check if result is OddNumber
            if(result % 2 != 0 && Event_OddNumber != null)
            {
                //Raised Event
                Event_OddNumber();
            }
        }

    }
}
