using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    // Abstract classes and abstract methods
    public abstract class BankAccount
    {
        // None Abstract method
        public void getMessage()
        {
            Console.WriteLine("Welcome to ABC Bank\n");
        }
        public abstract void deposite();
        public abstract void withdraw();
        public abstract void balance();

    }
    
  

    //   Inheritance for above class BankAccount and methods 
    public class SavingAccount:BankAccount 
    {
        public override void balance()
        {
            Console.WriteLine(" Balance in Saving Account");
        }
        public override void deposite()
        {
            Console.WriteLine(" Deposite in Saving Account");
        }
        public override void withdraw() 
        {
            Console.WriteLine(" Withraw from Saving Account");
        }
    }
}
