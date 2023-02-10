/*
 * Author: Aaron Abramson
 * Course: COMP-003A
 * Purpose: Week 4 Assignment
 *
*/

using System.Reflection.Metadata;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //begin for loop section//
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i < limit; i++)//-----------------<|The for loop with looping variable, run condition, increment
            {
                Console.WriteLine(output);//-----------------<//Block of code that
                output += "#";                                //outputs each line                
            }                                                 //of the triangle and             
                                                              //appends # to output string  
            Console.WriteLine("\n");                          
            
            //end for loop section//
            
            //begin foreach loop section//
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };//The friends array

            foreach (string friend in friends)//--------------<|foreach loop with type, local variable name, and array name. 
            {
                Console.WriteLine($"{friend}");//-------------<|Codeblock to output one friend from friends array.
            }

            Console.WriteLine("\n");

            //end foreach loop section//

            //begin do-while loop section//
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));


        }
    }
}