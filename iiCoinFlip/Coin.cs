using System;
using System.Collections.Generic;
using System.Text;

namespace iiCoinFlip
{

    public class Coin
    {
        // Use random class
        Random rand;

        // Set _sideup to an empty string
        private string _sideup = "";

        // Constructor
        public Coin()
        {
            rand = new Random();
        }

        /// <summary>
        ///  Generate a random number and set sideup
        /// </summary>
        public void FlipCoin()
        {
            // Next() method returns a non-negative random integer
            int randomSide = rand.Next(2);
            
            // If the nubmer is 0, it's heads, false, it's another
            if (randomSide == 0)
            {
                _sideup = "Heads";
            }

            else
            {
                _sideup = "Tails";
            }
        }

        /// <summary>
        ///  Get _sideup in a roundabout way
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {
            return _sideup;
        }
    }
}
