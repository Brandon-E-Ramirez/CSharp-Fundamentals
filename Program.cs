//syntax
using System;
using System.Net.NetworkInformation;
using System.Security;
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
            //operators
            /*
            + 	Addition 	Adds together two values 	x + y 	
            - 	Subtraction 	Subtracts one value from another 	x - y 	
            * 	Multiplication 	Multiplies two values 	x * y 	
            / 	Division 	Divides one value by another 	x / y 	
            % 	Modulus 	Returns the division remainder 	x % y 	
            ++ 	Increment 	Increases the value of a variable by 1 	x++ 	
            -- 	Decrement 	Decreases the value of a variable by 1 	x--
            */

            Console.WriteLine("Enter number 1: ");
            int alpha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int beta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3: ");
            int gamma = Convert.ToInt32(Console.ReadLine());

            alpha++;
            beta--;
            Console.WriteLine("Wild calculation: "+(Math.Pow(Convert.ToDouble(alpha),Convert.ToDouble(beta)) + (alpha - beta) % gamma)*(gamma/(Math.Pow((x%gamma),(beta)))));

            //assignment operators:
            /*
                = 	x = 5 	x = 5 	
                += 	x += 3 	x = x + 3 	
                -= 	x -= 3 	x = x - 3 	
                *= 	x *= 3 	x = x * 3 	
                /= 	x /= 3 	x = x / 3 	
                %= 	x %= 3 	x = x % 3 	
                &= 	x &= 3 	x = x & 3 	//OR
                |= 	x |= 3 	x = x | 3 	//AND
                ^= 	x ^= 3 	x = x ^ 3   //XOR
                >>= 	x >>= 3 	x = x >> 3 	Right shift AND assignment
                <<= 	x <<= 3 	x = x << 3  Left shift AND assignment
            */

            alpha += 10;
            beta -= alpha;
            gamma *= beta %= alpha;
            alpha &= gamma |= beta;
            Console.WriteLine("Updated alpha value: " + (float)alpha);

            int value = 8;
            string binary = Convert.ToString(value, 2);//chnaging base to binary
            Console.WriteLine(value + " in binary is: " + binary);
            value >>= 2;
            Console.WriteLine(value + " shifted right by 4 digits in binary is: " + binary);
            Console.WriteLine("This is " + Convert.ToString(value,10) +" as an integer");

            /*
                == 	Equal to 	x == y 	
                != 	Not equal 	x != y 	
                > 	Greater than 	x > y 	
                < 	Less than 	x < y 	
                >= 	Greater than or equal to 	x >= y 	
                <= 	Less than or equal to 	x <= y 
                
             */

            int cash = 200;
            string result = (cash >= 100000) ? "Baller.." : "In school still?";
            Console.WriteLine(result);

            /*
            &&  	Logical and 	Returns True if both statements are true 	x < 5 &&  x < 10 	
            ||  	Logical or 	Returns True if one of the statements is true 	x < 5 || x < 4 	
            ! 	Logical not 	Reverse the result, returns False if the result is true 	!(x < 5 && x < 10)
             */

            Console.WriteLine(!(alpha > beta && (gamma < value)));

            //https://www.w3schools.com/cs/cs_math.php
            Console.WriteLine(Math.Max(3, 9)); 
            Console.WriteLine(Math.Min(-4, 0)); 
            Console.WriteLine(Math.Sqrt(144));  
            Console.WriteLine(Math.Abs(-2556.3));  
            Math.Round(31.50);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Cbrt(27));
            int stock = 10;
            Console.WriteLine(Math.Clamp(stock, 5, 15));
            Console.WriteLine(Math.Ceiling(4.235));
            Console.WriteLine(Math.Floor(4.235));
            Console.WriteLine(Math.Cbrt(27));
            Console.WriteLine(Math.Pow(2, 5));


            https://www.w3schools.com/cs/cs_strings.php
            string firstName = "Brandon";
            string lastName = "Ramirez";
            Console.WriteLine(firstName + lastName);

            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
            
            string txt = "C# is nice";
            Console.WriteLine("txt is " + txt.Length + "characters long.\n");
            Console.WriteLine(txt.ToUpper() + " " + txt.ToLower()); 

            string x = "20";
            string y = "48";
            string z = x + y;  // z will be 2048 (a string)
            //interpolation
            string name = $"My full name is: {firstName} {lastName}\n";
            Console.WriteLine(name);

            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf("e"));

            // Location of :
            int charPos = name.IndexOf(":");
            
            // Get full name + ": "
            string fName = name.Substring(charPos);
            // Print the result
            Console.WriteLine(fName);

            //booleans
            bool isAGuy = true;
            bool isRetired = false;
            Console.WriteLine(isAGuy); 
            Console.WriteLine(isRetired);   

            Console.WriteLine("Enter int value \"zetta\":");
            int zetta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter int value \"yotta\":");
            int yotta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yotta greater than zetta? ...\n");
    
            if (yotta > zetta) 
            {
              Console.WriteLine("\nTrue");
            } 
            else 
            {
              Console.WriteLine("\nFalse");
            }
            
            //control structures
            Console.WriteLine("Enter your age (int): ");
            int voterAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Citizen? (int[0 or 1]): ");
            bool isCitizen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If not citizen, are you petitioning to be one? (int[0 or 1]): ");
            bool isPetitioning = Convert.ToInt32(Console.ReadLine());
            
            if (voterAge > 18 && isCitizen) 
            {
              Console.WriteLine("You may vote!");
            } else if (voterAge > 18 && isPetitioning){
                Console.WriteLine("You may vote soon!");
            }else{
             Console.WriteLine("Try again in 4 years!");
            }


            //ternary operator
            string ageResult = (age > 18) ? "Remember to register to vote!" : "You are too younf to register!";
            Console.WriteLine(ageResult);


            https://www.w3schools.com/cs/cs_switch.php
            Console.WriteLine("Enter season (spring, summer, autumn, winter): ");
            string season = Convert.ToString(Console.ReadLine());
            season = season.ToLower()
                
            switch(season) 
            {
            case "spring":
            Console.WriteLine("Wear a long sleve or t-shirt, nice weather!");
            break;
            case "summer":
            Console.WriteLine("Drink pleanty of water and wear a t-shirt!");
            break;
            
            case "autumn":
            Console.WriteLine("It's nice and cool, turkey time :)");
            break;
            case "winter":
            Console.WriteLine("We will survive this");
            break;
            default:
            Console.WriteLine("Wrong input, try again!");
            break;
            }


            


            

        }
    }
}
