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
    internal class String_Operations
    {
        public void Demo()
        {
            // String concatination
            string firstName, lastName, House;
            firstName = "Jeanny";
            lastName = " Snow";
            House = "Stark";

            Console.Write(string.Format("Hello, " + firstName + lastName + " of {0}", House) + Environment.NewLine);

            string MovieName = "    Lord of the Rings ";
            Console.WriteLine(MovieName[15]); 
            Console.WriteLine(MovieName.Trim());
            Console.WriteLine("Is there LORD in Lord of the rings?"); 
            Console.WriteLine(MovieName.ToUpper().Trim().Contains("LORD"));

            Console.WriteLine("The length of trimmed string: " + MovieName.Trim().Length);

            MovieName = MovieName.Replace("Lord", "Ford"); 
            Console.WriteLine(MovieName.Trim());


            string tvShow = "Game of Thrones"; 
            Console.WriteLine(tvShow.IndexOf('o'));  
            Console.WriteLine(tvShow.LastIndexOf("o"));
            Console.WriteLine(tvShow.Substring(4));
            Console.WriteLine(tvShow.Remove(4));
            Console.WriteLine(tvShow.Insert(4, "This is inserted from 4th character")) ; 
        }
    }

}
