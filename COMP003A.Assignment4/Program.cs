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
        {   //
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
            //
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
            //
            //begin do-while loop section//
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;//----------|initial counter value set to 0

            do
            {
                Console.WriteLine($"{counter}");//----<|Output current value of counter
                counter += 5;//-----------------------<|Increment counter by 5
            } while (counter <= 50);//----------------<|Run condition until counter is no longer less than or equal to 50
                                                     //|Condition evaluator is at end of do-while loop ensures codeblock is run at least once    
            Console.WriteLine("\n");

            //end do-while loop section//
            //
            //start while loop section//
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;//-----------------------<|initial counter2 value set to 1

            while (counter2 <= 20)//-------------------<|while loop with run condition until counter2 is no longer less than or equal to 20
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)//<|The first if statement has to evaluate 
                {                                           //|both conditions to avoid being skipped all together.  
                    Console.WriteLine("FooBar");            //|If the 2 condition statement was placed at the end, 
                }                                           //|either of the single modulus conditions for Foo or Bar
                else if (counter2 % 2 == 0)                 //|would satisfy the if else statement and would output either 
                {                                           //|Foo or Bar and continue to the next iteration of the loop
                    Console.WriteLine("Foo");               
                }                                           
                else if (counter2 % 5 == 0)                 
                {                                           
                    Console.WriteLine("Bar");               
                }                                           
                else                                        
                {                                           
                    Console.WriteLine($"{counter2}");
                }
                counter2++;//-------------------------<|Increment counter2 by 1
            }
            //end while loop section//
        }
    }
}