using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class Die
    {
        private int numberOfSides;
           private RandomGenerator randomGenerator;
      
    


        //public Die(int numberOfSides)
        //  {
        //      this.numberOfSides = numberOfSides;
        //      this.randomGenerator = new Random();
        //  }

        //public Die(int numberOfSides, ref Random generator)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = generator;

        //}

            public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;

            this.randomGenerator = RandomGenerator.GetInstance();
            
        }



        //public int Roll()
        //{
        //    int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
        //    return rolledNumber;
        //}

        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }

    }

}
