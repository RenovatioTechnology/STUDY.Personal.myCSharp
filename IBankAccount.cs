using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
   
    interface IManageBank
    {
        void openAccount();
        void closeAccount();
    }
    internal interface IBankAccount
    {
        // By default all interface methods are public and abstract
        void deposite();
        void withdraw();
        void balance();

    }
    //  Inherit multiple interfaces 
    public class SavingAcc : IBankAccount, IManageBank
    {
        public void balance()
        {
            Console.WriteLine(" Balance in Saving Account");
        }

        public void deposite()
        {
            Console.WriteLine(" Deposite in Saving Account");
        }

        public void withdraw()
        {
            Console.WriteLine(" Withraw from Saving Account");
        }

        public void openAccount()
        {
            Console.WriteLine(" Open Saving Account");
        }
        public void closeAccount() 
        {
            Console.WriteLine(" Close Saving Account");
        }
    }
   
}
