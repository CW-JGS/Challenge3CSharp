using System.Reflection.Emit;
using System;

namespace DiceNamespace
{
    public class Dice
    {
        private Random randomInstance = new Random();
        public int Sides { get; set; }
        public Dice()
        {
            this.Sides = 6;
        }
        public Dice(int pSides)
        {
            this.Sides = pSides;
        }
        public int Roll()
        {

            return randomInstance.Next(1, Sides);
        }
    }
}