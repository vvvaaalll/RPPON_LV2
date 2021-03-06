﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class DiceRoller : ILoggable
    { 
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        
        }
        public void InsertDie(Die die)
        {   
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }

        public void SetLogger(ILogger logger) {
            this.logger = logger;
        }

        //public void LogRollingResults() {

        //    for (int i = 0; i < this.resultForEachRoll.Count; i++) {

        //        logger.Log(resultForEachRoll[i].ToString());

        //    }
        
        //}


        public string GetStringRepresentation() {

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < this.resultForEachRoll.Count; i++) {

                stringBuilder.Append(resultForEachRoll.ToString()).Append("\n");   //provjeriti zasto ne add
            
            }

            return stringBuilder.ToString();
        }

    }

}
