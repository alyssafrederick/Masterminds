using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] fourDigits = new int[4];
            fourDigits[0] = random.Next(0, 10);
            fourDigits[1] = random.Next(0, 10);
            fourDigits[2] = random.Next(0, 10);
            fourDigits[3] = random.Next(0, 10);

            int[] guessfourDigits = new int[4];
            guessfourDigits[0] = random.Next(0, 10);
            guessfourDigits[1] = random.Next(0, 10);
            guessfourDigits[2] = random.Next(0, 10);
            guessfourDigits[3] = random.Next(0, 10);

            //Console.WriteLine("{0}{1}{2}{3}", fourDigits[0], fourDigits[1], fourDigits[2], fourDigits[3]);

            while ((fourDigits[0] != guessfourDigits[0]) || (fourDigits[1] != guessfourDigits[1]) || (fourDigits[2] != guessfourDigits[2]) || (fourDigits[3] != guessfourDigits[3]))
            {
                Console.WriteLine("guess the first digit");
                guessfourDigits[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("guess the second digit");
                guessfourDigits[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("guess the third digit");
                guessfourDigits[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("guess the fourth digit");
                guessfourDigits[3] = int.Parse(Console.ReadLine());
    
                if ((fourDigits[0] == guessfourDigits[0]) && (fourDigits[1] == guessfourDigits[1]) && (fourDigits[2] == guessfourDigits[2]) && (fourDigits[3] == guessfourDigits[3]))
                {
                    Console.WriteLine("the whole number is correct!");
                    Console.WriteLine("would you like to play again (respond with yes or no)");
                    if (Console.ReadLine() == "yes")
                    {
                        fourDigits[0] = random.Next(0, 10);
                        fourDigits[1] = random.Next(0, 10);
                        fourDigits[2] = random.Next(0, 10);
                        fourDigits[3] = random.Next(0, 10);
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    if (fourDigits[0] == guessfourDigits[0])
                    {
                        Console.WriteLine("the first digit is correct");
                    }
                    else if (guessfourDigits.Contains(fourDigits[3]))
                    {
                        Console.WriteLine("the first digit is correct but in the wrong spot");
                    }
                    if (fourDigits[1] == guessfourDigits[1])
                    {
                        Console.WriteLine("the second digit is correct");
                    }
                    else if (guessfourDigits.Contains(fourDigits[3]))
                    {
                        Console.WriteLine("the second digit is correct but in the wrong spot");
                    }
                    if (fourDigits[2] == guessfourDigits[2])
                    {
                        Console.WriteLine("the third digit is correct");
                    }
                    else if (guessfourDigits.Contains(fourDigits[3]))
                    {
                        Console.WriteLine("the third digit is correct but in the wrong spot");
                    }
                    if (fourDigits[3] == guessfourDigits[3])
                    {
                        Console.WriteLine("the fourth digit is correct");
                    }
                    else if (guessfourDigits.Contains(fourDigits[3]))
                    {
                        Console.WriteLine("the fourth digit is correct but in the wrong spot");
                    }
                    Console.WriteLine("try again...");
                }

            }

            Console.ReadLine();
        }
    }
}

