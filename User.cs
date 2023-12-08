using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class User
    {
        private string name;

        // Read only Property 
        private string companyName;
        private int age;
        //private string City { get; set; }   

        // Constructor 
        public User()
        {
            //Initialize company name as ABC
            companyName = "ABC";
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // return only
        public string CompanyName
        {
            get
            {
                return companyName; 
            }
        }
        // Age property
        public int Age
        {
            get
            { 
                return age; 
            }
            set
            {
                if (value < 18)
                    throw new ArgumentException("Invaild Age");
                age = value;
            
            }
        }
    }
}
