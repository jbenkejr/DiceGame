using System;

namespace DiceRollingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            bool again = true;

            int die1 = ranNum.Next(1, 7);
            int die2 = ranNum.Next(1, 7);
            while (again == true)
            {
                RollTheDice("Welcome to the Grand Circus Casino! Roll the dice? y/n ");

                while (again == true)
                {

                    int sides = DieSides("How many sides should each die have?");
            

                    for (int i = 0; i < 1; i++)
                    {
                        int roll;
                        roll = RandomNumber(sides);
                        die1 = roll++;
                        roll = RandomNumber(sides);
                        die2 = roll++;
                        Console.WriteLine("Roll: ");
                        Console.WriteLine(die1);
                        Console.WriteLine(die2);
                    }

                    Console.WriteLine("Roll again? y/n");
                    string yesNo = Console.ReadLine();
                    if (yesNo.Equals("y") || yesNo.Equals("Y"))
                    {
                        again = true;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        again = false;
                    }
                }
            }
        }

        public static int RandomNumber (int num1)
        {
            Random ranNum = new Random();
            return ranNum.Next(1, 7);
        

        }
        public static void RollTheDice(string message)
        {
            string yesNo;
            Console.WriteLine(message);
            yesNo = Console.ReadLine();
        }

        public static int DieSides(string message)
        {
            Console.WriteLine(message);
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
    }
}