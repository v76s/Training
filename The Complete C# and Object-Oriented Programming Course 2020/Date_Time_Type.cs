using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    /// <summary>
    /// The demonstration of string operations
    /// </summary>
    internal class Date_Time_Type
    {
        public void Demo()
        {
            // DateTime variables 
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd.MM.yyyy"));
            Console.WriteLine(date.ToFileTime());

            // Try parse demonstation
            int value = 0;
            //int.TryParse(Console.ReadLine(), out value);
            Console.WriteLine(value);
        }
    }

}
