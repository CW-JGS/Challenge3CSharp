using System.Reflection.Emit;
using System;

namespace DiceNamespace
{
    public class Dice
    {
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
            return new Random().Next(1, Sides + 1);
        }
    }
}