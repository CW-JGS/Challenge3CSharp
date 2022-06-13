using System.Reflection.Emit;
using System;

namespace DiceNamespace
{
    class Dice
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
        public int roll()
        {

            return randomInstance.Next(1, Sides);
        }
    }
}