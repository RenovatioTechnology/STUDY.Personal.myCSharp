using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace coreConsoleApplication
{
    internal class Marks:StudentInfo
    {
        float objectiveMarks;
        float subjectiveMarks;

        public void acceptDetails()
        {
           
            Console.Write("Enter Objective Marks: ");
            objectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks: ");
            subjectiveMarks = float.Parse(Console.ReadLine());
        }
        // Display Details 
        public void displayDetails()
        {
   
            Console.WriteLine("Objective Marks: " + objectiveMarks);
            Console.WriteLine("Subjective Marks: " + subjectiveMarks);
        }
    }
}
