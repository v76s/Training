using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    public class Exception_Handling
    {
        public Exception_Handling() { }

        public void Demo()
        {
            #region [Variables]
            int Number1, Number2;

            #endregion

            try
            {
                Console.WriteLine("Enter a number : ");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number : ");
                Number2 = int.Parse(Console.ReadLine());
                // If numbers are
                int Result = Number1 / Number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
            catch (Exception ex)
            {
               // A General exception has been thrown. We don't know the 
               // details of the exception yet ...
            }
            finally
            {
                Console.WriteLine("The application completed");
            }
        }
    }
}
