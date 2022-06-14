using System.Reflection.Emit;
using System;
using DiceNamespace;

namespace GameNamespace
{
    public abstract class Game
    {
        public List<Dice> Dice = new List<Dice>();


        public abstract int RollAllDice();
        public abstract void AddDice(int pSides);
    }
}