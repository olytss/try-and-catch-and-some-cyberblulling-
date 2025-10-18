using System.ComponentModel.Design;
using System.Data;

namespace meow
{
    internal class program
    {
        private static void Main(string[] args)
        {
            int attempts = 0;
            int a;
            int b;

            do
            {
                switch (attempts)
                {
                    case 0:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Hello :3");
                        break;
                    case 1:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Lets try again");
                        break;

                    case 2:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Lets try again");
                        break;
                    case 3:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Lets try again");
                        break;
                    case 4:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Lets try again");
                        break;
                    default:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Bro cmon...");
                        break;
                }
               

                    Console.WriteLine();
                Console.WriteLine("Input your value A :3 ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Input your value B :3 ");

                b = int.Parse(Console.ReadLine());
               
                {
                   
                    try
                    {


                        int FirstMightBeZero = 1 / a;
                        int SecondMightBeZero = 1 / b;

                    }
                    catch (DivideByZeroException)
                    {
                       
                        Console.WriteLine();
                        Console.WriteLine("You can divide by zero :(");
                        attempts++;
                    }
                }
            } while (a == 0 || b == 0); 

            Console.WriteLine("Looks fine, your number is " + a + ", " + b  );

            if (attempts >= 1)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("It took you " + attempts + " attempts");
                Console.WriteLine("------------------------------------------------");
            }
            Console.ReadLine();

        }


    }
}
