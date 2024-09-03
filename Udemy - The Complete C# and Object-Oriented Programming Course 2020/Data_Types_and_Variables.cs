using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    /// <summary>
    /// The demonstration of data types and variables
    /// </summary>
    internal class Data_Types_and_Variables
    {
        public void Demo()
        {
            // Using basic variables
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            // Assign values to double float decimals
            double double_num = 0.7d;
            float float_num = 0.6f;
            decimal decimal_num = 1.0M;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is " + double_num + " float is " + float_num + " decimal is " + decimal_num);

            // Difference between float double decimal values. 
            float f_nr = 1 / 3f;
            double d_nr = 1 / 3d;
            decimal dc_nr = 1 / 3m;

            Console.WriteLine("The float : {0}", f_nr);
            Console.WriteLine("The double : {0}", d_nr);
            Console.WriteLine("The decimal : {0}", dc_nr);

        }
    }

}
