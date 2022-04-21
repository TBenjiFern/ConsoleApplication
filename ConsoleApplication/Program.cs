using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Store two variables - Your name, Your location (state or country)
            Console.Write("Please insert your name: ");
            string name = Console.ReadLine();
            Console.Write("Please insert your location: ");
            string location = Console.ReadLine();

            // 3. Output two WriteLine staements that display those two variables with proper labels using String Interpolation

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);
            //Console.WriteLine($"My name is {name}, I am from {location}");

            // 4. Output the current date, but not the current time

            DateTime fullDate = DateTime.Now;
            Console.WriteLine(fullDate.ToString("d"));
            //Console.WriteLine(DateTime.Now.ToString("d"));

            // 5. Output the number of days until Christmas this year and, of course, apply an appropriate label to that output

            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            Console.WriteLine("There are " + (christmas.Date - fullDate.Date).Days + " days until Christmas!");

            // 6. Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles
            // 7. Add these requirements to the code:
            /* - Provide appropriate text labels when requesting dimensional input.
             * - Cause the program to pause in the console so that the application does not automatically terminate when launched
             * from Visual Studio ren debugger tool. Hint: Consider Console.ReadKey()
             * - You do NOT need to add any sort of input validation.
            */

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please input the width of the window frame (meters): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please input the height of the window frame (meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();

        }
    }
}

