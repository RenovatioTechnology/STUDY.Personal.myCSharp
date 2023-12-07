using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Student
    {
        //Data Members
        int studentId;
        string studentName;


        // Default Constructor 
        public Student()
        {
            studentId = 122;
            studentName = "Annonymous";
        }

        // Parameterized Constructor 
        public Student(int sId, string sName)
        {
            studentId = sId;
            studentName = sName;
        }

        //Member Functions
        // Accept the detail from user 
        public void acceptDetails()
        {
            Console.Write("Enter Student Id: ");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name ");
            studentName = Console.ReadLine();
        }
        // Display Details 
        public void displayDetails()
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}
