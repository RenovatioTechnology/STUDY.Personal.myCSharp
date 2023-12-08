using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    // Enum is a user define data type
    // enum values starts with a value of zero by default
    enum Weekdays:byte
    {
        Monday,   // 0
        Tuesday,  // 1
        Wednesday,// 2
        Thursday, // 3
        Friday,   // 4
        Saturday, // 5
        Sunday    // 6

    }
// for access to enum we will go into a particular method
    internal class EnumDemo
    {
        public void Display()
        {
            Console.WriteLine(Weekdays.Monday);
            // If you require a integer day of the week
            int day = (int)Weekdays.Monday;
            Console.WriteLine(Weekdays.Monday + ":"+ day);

            Console.WriteLine(Weekdays.Tuesday);
            day = (int)Weekdays.Tuesday;
            Console.WriteLine(Weekdays.Tuesday + ":" + day);

            Console.WriteLine(Weekdays.Wednesday);
            day = (int)Weekdays.Wednesday;
            Console.WriteLine(Weekdays.Wednesday + ":" + day);
        }
    
    }
}
