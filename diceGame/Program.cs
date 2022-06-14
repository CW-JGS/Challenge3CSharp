using System;
using CLGameNamespace;
namespace DiceGameNamespace
{
    class Program
    {

        public static bool IsRunning { get; set; }
        public static void Main(string[] args)
        {
            IsRunning = true;
            Console.WriteLine("Welcome to the dice game");
            Console.Write(" Please enter your name\n > ");
            string Name = Console.ReadLine();
            CLGame game = new CLGame();
            game.Name = Name == "" ? "John Doe" : Name;
            while (IsRunning)
            {
                game.Results = new List<int>();
                game.Dice = new List<DiceNamespace.Dice>();
                int NumDice;
                int NumSides;
                Console.Write(" How many sides would you like you dice to have (Default is 6) ? \n >");
                bool inputIsValid = int.TryParse(Console.ReadLine(), out NumSides);
                Console.Write(" How many dice would you like to roll ? \n >");
                inputIsValid = int.TryParse(Console.ReadLine(), out NumDice);
                if (inputIsValid)
                {

                    runGame(game, NumDice, NumSides);
                }

            }
        }
        public static void runGame(CLGame gme, int numDice, int sides)
        {
            for (int i = 0; i < numDice; i++)
            {
                gme.Dice.Add(new DiceNamespace.Dice(sides));
            }
            gme.RollAllDice();
            Console.WriteLine($" total is {gme.GetTotal()}");
            Console.WriteLine($" average is {gme.GetAverage()}");
            Console.WriteLine($"[ {string.Join(" ", gme.Results)} ] ");
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.Write(" Would you like to roll again (Y/N) ? \n >");
                string a = Console.ReadLine();
                string ans = a.ToUpper();
                if ((ans == "Y") || (ans == "N"))
                {
                    if (ans == "Y")
                        return;
                    if (ans == "N")
                    {
                        IsRunning = false;
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(" [!] Invalid input please try again");
                }
            }

        }
    }
}