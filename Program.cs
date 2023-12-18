// See https://aka.ms/new-console-template for more information
using coreConsoleApplication;
using System.Linq.Expressions;

Console.WriteLine("Hello! Welcome to the World of C#!\n");

/*
// Instantiating my student class
Student student = new Student();
//student.acceptDetails();
student.displayDetails();

Console.WriteLine();

// Constructor overloading
Student student2 = new Student(122,"Jefferson Nah");
student2.displayDetails();


// Instantiating  Marks Class
Marks marks = new Marks();
marks.acceptDetails();
marks.displayDetails();


// Instantiating BankAccount
SavingAccount savingaccount = new SavingAccount();
savingaccount.getMessage();
// Access members 
savingaccount.deposite();
savingaccount.withdraw();
savingaccount.balance();


// Instantiating SavingAcc
SavingAcc savingAcc = new SavingAcc();
savingAcc.openAccount();
savingAcc.deposite();
savingAcc.withdraw();
savingAcc.balance();
savingAcc.closeAccount();


// So we cannot create an instance of Satice class 
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());

Console.WriteLine(Calculate.decrement());


// Extension Methhods 
int number = 1000;
bool result = number.IsGreaterThan(10001);
Console.WriteLine(result);



// Instance of Employee Class

var employee = new Employee();
Console.WriteLine(employee.EmpId);
Console.WriteLine(employee.EmpName);
employee.DisplayDetails();


// Instantiating User for Properties 
User user = new User();
// Set the value 
user.Name = "Jeff Shallu Nah";
user.Age = 34;
// Get property
Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);
Console.WriteLine(user.Age);


// Indexer
IndexerType indexerType = new IndexerType();
indexerType[0] = "String one";
indexerType[2] = "String two";
indexerType[3] = "String three";
indexerType[4] = "String four";

// For loop excute till 10
for(int i = 0; i < 10; i++)
    Console.WriteLine(indexerType[i]);  


// Instantiating EnumDemo class
EnumDemo enumDemo = new EnumDemo();
enumDemo.Display();




// Instantiating Calculation 
Calculation calculation = new Calculation();
// if 100 / 0 will throw an error 
//calculation.Calculate(100,0);
// Value tobe taken from the user
calculation.CalculateAnother();

*/

/*
// Anonymous Type
var obj = new
{
    fName = "Shallu",
    lName = "Nah",
    salary = "12000",
    // Storing nested object in the type
    address = new { streetName = "Woodland Hills", city = "Springs" },
    // Storing Arrays of Project
    projects = new[]
    {
        new { projectName = "ECommerce", projectDuration = "40 Hours"},
        new { projectName = "Admin Portal", projectDuration = "25 Hours"},
        new { projectName = "Accounting", projectDuration = "30 Hours"}
    }
};

// For Access 
Console.WriteLine("First Name: " + obj.fName);
Console.WriteLine(obj.lName);
Console.WriteLine(obj.salary);
// Complete address
Console.WriteLine(obj.address);
// Specific Attr
Console.WriteLine(obj.address.streetName);
Console.WriteLine("City: " + obj.address.city);

// Access Project Type with foreach Iterations 
foreach (var project in obj.projects)
{
    Console.WriteLine(project.projectName +": " + project.projectDuration);
}    



// Reference to Calculate Delegate Example Class

CalculateDelegate c1 = new CalculateDelegate(DelegateExample.Addition);
CalculateDelegate c2 = new CalculateDelegate(DelegateExample.Multiplication);

//
c1(100);
Console.WriteLine(DelegateExample.getNumber());
c2(200);
Console.WriteLine(DelegateExample.getNumber());



// Instantiate EVENTS, The Subscriber Model

EventsExample events = new EventsExample();

//events.event_OddNumber, holding the reference of addition method from EventExample.delegate_OddNumber, passing a message
events.Event_OddNumber += new EventsExample.Delegate_OddNumber(EventMessage);
events.Addition();
Console.ReadLine();
static void EventMessage()
{
    Console.WriteLine("Event Executed : Odd Number");
}



// Call Anonymous Method Example Class
AnonymousMethodExample.InvokeMethod();



// Expression Lambda:

// Lambda Arrays Example
var numbers = new int[] { 2, 4, 6, 5, 1, 3, 5, 7 };
// Count the number of '5' in the above Array
var count = numbers.Count(x => x == 5);
Console.WriteLine(count);

// Statement Lambda:
// Using the return statement 
List<int> numbers2 = new List<int> { 2, 4, 6, 5, 1, 3, 5, 7 };
count = numbers.Count(x => { return x == 5; });
Console.WriteLine(count);
*/

// Expression Tree Lambda:
// we are parsing 3 strings, two strings are the input and another is a return type.
Func<string,string,string> stringJoins =(str1,str2) => string.Concat(str1,str2);   

Expression< Func<string, string, string>> stringJoinExpr = (str1, str2) => string.Concat(str1, str2);

// Invoke the epression 
var func = stringJoinExpr.Compile();
var result = func("Hello", "World");
Console.WriteLine(result);  

// OR

// Combine the two hydrations one line
result = stringJoinExpr.Compile()("Hello","Everyone");
Console.WriteLine(result);