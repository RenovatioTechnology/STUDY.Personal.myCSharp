using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    // Exception Handling, runtime errors  
    // Exception Handler and Keywords  
    // try, catch, finally, throw
    internal class Calculation
    {
        // mehtod calculate that takes two numbers
        public void Calculate(int num1, int num2)
        {
            // if 100 / 0 will throw an error in Program.CS
            /*  int retult;
              retult = num1 / num2;
              Console.WriteLine(retult); 
            */

            int result = 0;
            // If no exception run try and skip catch
            try
            {
                result = num1 / num2;

            }
            // If exception occur run the messages below
            catch (Exception ex)
            {
                //customized exception
                Console.WriteLine("Exeption Occured.");

                Console.WriteLine(ex.Message);   
            }

            // finally block always get executed whether an exception occurs  or not
            finally 
            {
                Console.WriteLine("Always execute!");
                // In case try is unable to calculate
                Console.WriteLine(result);

            } 
        }

        // Multi catch exeception using one try and finally
        public void CalculateAnother()
        {
            int num1, num2,result = 0;

            // If no exception run try and skip catch
            try
            {
                // Start by asking user to enter values
                Console.Write("Enter number one: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter number two: ");
                num2 = int.Parse(Console.ReadLine());   
                result = num1 / num2;
            }
            // Arithmetic Exception
            catch (DivideByZeroException ex)
            {
                //customized exception
                Console.WriteLine("Exeption Occured.");

                Console.WriteLine(ex.Message);
            }
            // Catch Formated Execption 
            catch (FormatException ex)
            {
                //customized exception
                Console.WriteLine("Exeption Occured.");

                Console.WriteLine(ex.Message);
            }
            // Final catch block 
            catch(Exception ex)
            {
                Console.WriteLine("Exeption Occured.");
                Console.WriteLine(ex.Message);
            }

            // finally block always get executed whether an exception occurs  or not
            finally
            {
                Console.WriteLine("Always execute!");
                // In case try is unable to calculate
                Console.WriteLine(result);
            }
        }
    }
}


