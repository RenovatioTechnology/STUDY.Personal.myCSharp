using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    public delegate void PrintMessage(string message);  
    internal class AnonymousMethodExample
    {
        // Start with print message to hold the reference of the unnamed or anonymous methods, starting with the delegate keyword
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message: " + message);
            };
            // Print message has to invoke with this particular string message.
            printMessage("It works!");
        }
    }
}
