//syntax
using System;
/* multiline comment
 * review C# fundamentals 
 */
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string greeting = "Hello world!";
            int age = 22;
            double netWorth = 200.25282368923490237D;
            float ropeLength = 50.08963472F;
            char currency = '$';
            bool married = false;
            //output
            Console.WriteLine(greeting);// includes "\n" at end of string
            Console.Write(" ...VS is slow.");//used to print multiple strings to same line
            Console.WriteLine("Age: " + age + " Net worth: " + netWorth + currency);
            Console.WriteLine("Married: " + married);
            //constants
            const int birthYr = 2000;
            Console.WriteLine("Born: " + birthYr);
            //3d-space cordinates
            int x, y, z;
            x = 0;
            y = 0;
            z = 0;

            //Explicit type conversion
            int newRopeLength = (int)ropeLength;
            string boolMarried = Convert.ToString(married);
            Console.WriteLine("Is married boolean to string: "+boolMarried);
            //user input
            Console.Write("x value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input: " + x);


        }
    }
}