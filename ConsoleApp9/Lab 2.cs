using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop == true)
            {
                try
                {
                    Console.WriteLine("Please Enter the length of the classroom or type in 'quit' to exit:");
                    string length = Console.ReadLine().ToLower();

                    if (length == "quit")
                    {
                        break;
                    }

                    double Length = double.Parse(length);



                    Console.WriteLine("Please Enter the width of the classroom or type in 'quit' to exit:");
                    string width = Console.ReadLine().ToLower();

                    if ( width == "quit")
                    {
                        break;
                    }

                    double Width = double.Parse(width);

                    if (width == "quit")
                    {
                        break;
                    }


                    double area = Length * Width;
                    Console.WriteLine("The area of the classroom is: " + area);

                    double perimeter = (Length * 2) + (Width * 2);
                    Console.WriteLine("The area of the classrom is: " + perimeter);

                    double volume = Length * Width * 10;
                    Console.WriteLine("The volume of the classroom is: " + volume);

                    Console.WriteLine("Would you like to measure another room? Enter Yes or No");
                    string DoAgain = Console.ReadLine();

                    if (DoAgain == "No")
                    {
                        break;
                    }
                }

                catch
                {
                    Console.WriteLine("There was an error");
                    continue;
                }
            }
        }
    }
}