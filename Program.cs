// See https://aka.ms/new-console-template for more information
using coreConsoleApplication;

Console.WriteLine("Hello, Welcome to the World of C#!\n\n");

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

*/


// Instantiating Calculation 
Calculation calculation = new Calculation();
// if 100 / 0 will throw an error 
//calculation.Calculate(100,0);
// Value tobe taken from the user
calculation.CalculateAnother();
