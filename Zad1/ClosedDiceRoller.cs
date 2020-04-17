﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class ClosedDiceRoller: IDiceRoller
    {

        private List<Die> dice;
        private List<int> resultForEachRoll;
        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>();
            for (int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(numberOfSides));
            }
            this.resultForEachRoll = new List<int>();
        }
        //public void InsertDie(Die die)
        //{
        //    throw new NotImplementedException();
        //}
        //public void RemoveAllDice()
        //{
        //    throw new NotImplementedException();
        //}
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }

        }
    }
}
