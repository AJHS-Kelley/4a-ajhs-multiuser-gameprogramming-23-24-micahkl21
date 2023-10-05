// 02_Collections, Lecount Micah, 10-5-23, v0.2
using Systems;

namespace _02_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CANNOT change. 
            -- Contents of elements in an array CAN change
            -- Items in the array are called ELEMTS.
            -- Arrays are ordered, meaning each item has a fixed postion 
            -- The position is known as the INDEX.
            -- first element in an array is index 0.
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = ("Bacon", "Waffles", "Pancakes", "Cereal", "Parfait");
            int[] testScores = (95, 100, 25, 15, 27, 35);
            float[] GPA = (3.14f, 2.25f, 1.74f, 1.99f, 099f, 4.25f);
            
            // Print Array Contents -- All Elemtns on  Sinlge Line
            Console.Writeline("The elements for each array are:\n")
            Console.Writeline("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.Writeline(); 
            Console.Writeline("testScores:\n" + String.Join(", ", breakfastfoods));
            Console.Writeline();
            Console.Writeline("GPA: \n" + String.Join(", ", GPA));
            Console.Writeline(); 









        }
    }
}