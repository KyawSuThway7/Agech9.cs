using System;

namespace Agech9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");//Age
                Console.Write("Age : ");
                int inputage = Convert.ToInt32(Console.ReadLine());
                bool plays = isgreatherthan(inputage);
                    if (plays)
                    {
                        Console.WriteLine("You can vote because your age is 18 or greather than 18");
                    }
                    else
                    {   
                    Console.WriteLine("you can not because your age is lower than 18");
                    }

                }
            catch(FormatException)
            {
                Console.WriteLine("\nError !!! Your input must be ( number )");
            }
            catch(Exception e1)
            {
                Console.WriteLine("\n Error !!! Inputing is not be negative");
            }
           
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
        static bool isgreatherthan (int inputage)
        {
            bool plays = false;
            if(inputage<0)
            {
              throw new ArgumentException("Inputing is not be negative ");
            }
            else if(inputage>18)
            {
                plays = true;
            }
            return plays;
        }
    }
}
