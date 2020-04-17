using System;
using System.Collections.Generic;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)

        {
           

            DiceRoller dices = new DiceRoller();
            Random randomGenerator = new Random();

            int numberOfDices = 20;

            for (int i = 0; i < numberOfDices; i++) {

                //dices.InsertDie(new Die(6));


                //dices.InsertDie(new Die(6, ref randomGenerator));

                dices.InsertDie(new Die(6));
            }

            dices.RollAllDice();

            IList<int> rolledValues = dices.GetRollingResults();

            for (int i = 0; i<rolledValues.Count; i++) {

                Console.WriteLine(rolledValues[i]);
            
            }




        }
    }
}
