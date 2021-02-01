using System;

namespace Refactoring_StatePattern
{
    public class CeilingFanPullChain
    {
        private int currentState;

        public CeilingFanPullChain()
        {
            currentState = 0;
        }

        public void pull()
        {
            if (currentState == 0)
            {
                currentState = 1;
                Console.WriteLine("low speed");
            }
            else if (currentState == 1)
            {
                currentState = 2;
                Console.WriteLine("medium speed");
            }
            else if (currentState == 2)
            {
                currentState = 3;
                Console.WriteLine("high speed");
            }
            else
            {
                currentState = 0;
                Console.WriteLine("turning off");
            }
        }
    }
}