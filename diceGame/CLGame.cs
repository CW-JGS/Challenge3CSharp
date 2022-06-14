using System.Collections;
using System;
using System.Linq;
using GameNamespace;
using DiceNamespace;
namespace CLGameNamespace
{
    public class CLGame : Game
    {
        public string Name { get; set; }
        public List<int> Results = new List<int>();
        public double GetAverage()
        {
            if (Results.Count == 0)
                return 0.00;
            return ((double)GetTotal() / Results.Count());
        }
        public int GetTotal()
        {
            if (Results.Count == 0)
                return 0;
            return Results.Sum();
        }
        public override int RollAllDice()
        {

            try
            {
                if (Dice.Count() == 0)
                    throw new Exception();
                foreach (Dice die in Dice)
                {
                    Results.Add(die.Roll());
                }
                return 1;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($" something when wrong \n\n {ex}");
                return 0;
            }
        }
        public override void AddDice(int pSides)
        {
            try
            {
                Dice.Add(new Dice(pSides));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($" something when wrong \n\n {ex}");
            }
        }
    }
}