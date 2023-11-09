// Lecount Micah, Program Template, v0.4
using System; 
/*
Void Method
Method with Return
Method with Parameter
Method with Multiple Parameters
Method with Default Parameters
Method Class using Named Arguments
Method Overloading
*/
namespace MethodsParameters
{
        class MethodsParameters
    {
        // METHOD - - named block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and output.
        // Example Signature
        static void MyMethod()
        {
         Console .WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and french fries")
        }
        // static -- This method belongs to the current class, it is NOT an object.
        // void -- This method has no return value.
}
        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System. Convert. ToInt32(Console. ReadLine ()) ;
            sum *= 2;
            Console.WriteLine (sum):
            return sum;
        }

        // Methods with Parameters
        static void MakePancakes (int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up! In");
            }
        }

        static void MakeEggs (int num, string styLe)
        {
            Console .WriteLine ("You have ordered" + num + "eggs cooked " + style + ". \n");
        }

        // Using Defaults for Parameters
        static void MakeBurger (int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + "hamburgers. In");
        }

        // Named Arguments
        static void AlIMyChildren(string childl, string child, string chiLd3)
        {
            Console WriteLine("My favorite child is " + child);
        }

        // METHOD OVERLOADING
        // Find Sum of Int
        static int FindSum(int x, int y)
        {
            int sum = × + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        // Find Sum of Double 
        static double FindSum(double x, double y)
        {
            double sum = × + y;
            Console.WriteLine("Sum: " + sum):
        }
}
