using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class FlexibleDiceRoller : IDiceRoller, IManageDices 
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }


        void RemoveDicesWith(int value) //removes dices with n sides
        {
            for (int i = 0; i < dice.Count; i++) {

                if (dice[i].GetNumberOfSides() == value) {

                    dice.RemoveAt(i);
                    i--;
                }
            
            }

        }

    }
}
