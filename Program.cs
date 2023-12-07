// See https://aka.ms/new-console-template for more information
using coreConsoleApplication;

Console.WriteLine("Hello, Welcome to the World of C#!\n\n");
Console.WriteLine("TESTING");
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
*/

// Instantiating SavingAcc
SavingAcc savingAcc = new SavingAcc();
savingAcc.openAccount();
savingAcc.deposite();
savingAcc.withdraw();
savingAcc.balance();
savingAcc.closeAccount();