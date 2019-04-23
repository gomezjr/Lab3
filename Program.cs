using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name friend");
            string name1 = Console.ReadLine();
      

            bool doAgain = true;
            while (doAgain == true)
            {
                Console.WriteLine("{0} please enter a number between 1 and 100", name1);
                int answer1 = int.Parse(Console.ReadLine());

                if (answer1 < 0 || answer1 > 100)
                {
                    Console.WriteLine("Please enter valid number positive number between 1 - 100");
                    continue;
                }

                if (answer1 % 2 != 0 && answer1 < 60)
                {
                    Console.WriteLine("{0} the number you entered is {1} and is odd.", name1, answer1);
                }
                if (answer1 % 2 != 0 && answer1 > 60)
                {
                    Console.WriteLine("{0} the number you entered is {1} and is odd.", name1, answer1);
                }
                if (answer1 % 2 == 0 && answer1 >= 2 && answer1 <= 25)
                {
                    Console.WriteLine("{0} the number you entered is even and less than 25.", name1);
                }
                if (answer1 % 2 == 0 && answer1 >= 25 && answer1 <= 60)
                {
                    Console.WriteLine("{0} the number you entered is even.", name1);
                }
                if (answer1 % 2 == 0 && answer1 > 60)
                {
                    Console.WriteLine("{0} the number you entered is even.", name1);
                }

                Console.WriteLine("Do you wish to continue? Y/N");
                string input1 = Console.ReadLine();
                if (input1 == "Y" || input1 == "y")
                {
                    doAgain = true;
                }
                if (input1 == "N" || input1 == "n")
                {
                    doAgain = false;
                }
               
            }
            Console.WriteLine("Thanks for playing :)");
        }
        
    }

    
        

}
