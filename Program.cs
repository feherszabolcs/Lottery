using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {

        static void Main()
        {

            //User's numbers
            Console.WriteLine("Enter 5 number between 1-100! Press ENTER after every number!");

            
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                int input3 = int.Parse(Console.ReadLine());
                int input4 = int.Parse(Console.ReadLine());
                int input5 = int.Parse(Console.ReadLine());


            
             

            List<int> usrNum = new List<int>(5);
            

            if (input1 < 100 && input2 < 100 && input3 < 100 && input4 < 100 && input5 < 100)
            {
                usrNum.Add(input1);
                usrNum.Add(input2);
                usrNum.Add(input3);
                usrNum.Add(input4);
                usrNum.Add(input5);
            }
            else
            {
                Console.WriteLine("Input error!");
            }

            Console.WriteLine();

            //Machine picks a random number
            ArrayList numbers = new ArrayList();
            Random random = new Random();
            int rNumber;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    rNumber = random.Next(1, 100);
                } while (numbers.Contains(rNumber));
                numbers.Add(rNumber);
            }
            numbers.Sort();

            int matches = 0;
            for (int i = 0; i < 5; i++)
            {
                if (numbers.Contains(usrNum[i]))
                {
                    matches = matches + 1;
                }

            }

            //List of winner tickets
            Console.Write($"The winner tickets are: {numbers[0]}");
            for (int i = 1; i < numbers.Count; i++)
            {
                Console.Write($", {numbers[i]}");
            }
            Console.WriteLine("\n\n");


            //Match counter
            Console.WriteLine($"You have {matches} matches!");

            switch (matches)
            {
                case 0: Console.WriteLine("You won 0$!"); break;
                case 1: Console.WriteLine("You won 6$!"); break;
                case 2: Console.WriteLine("You won 16$!"); break;
                case 3: Console.WriteLine("You won 50$!"); break;
                case 4: Console.WriteLine("You won 200$!"); break;
                case 5: Console.WriteLine("You won 8000$!"); break;
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }

            //restart
            Console.WriteLine("\n Type 'restart' to restart the game or press any key to leave.");
            string restart = Console.ReadLine();
            Console.WriteLine();

            if (restart == "restart" || restart == "Restart" || restart == "RESTART")
            {
                Console.WriteLine("\n\n\n The game is restarted! \n\n\n");
                Main();
            }



            Console.ReadKey();
        }
    }
}
