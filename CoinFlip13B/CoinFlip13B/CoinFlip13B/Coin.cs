using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlip13B
{
    public class Coin
    {
        // this a random class created before it is flipped
        Random rand;
        // if the class below is side up, it will be heads
        private string sideUp;

        /// <summary>
        /// Describing the method of the Coin below
        /// </summary>
        public Coin()
        {
            //
            sideUp = "Heads";
            //
            rand = new Random();
        }

        /// <summary>
        /// random coin flip heads and tails.
        /// </summary>
        public void FlipCoin()
        {
            //if rand lands on 0, it will display sideUp heads
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            // if rand lands not on 0, it will display tails
            else
            {
                sideUp = "Tails";
            }
        }

        /// <summary>
        /// Retruning the string of the value
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {
            return sideUp;

        }
    }
}
