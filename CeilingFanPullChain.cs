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
            switch (currentState)
            {
                case 0:
                    SetState(1);
                    Console.WriteLine("low speed");
                    break;
                case 1:
                    SetState(2);
                    Console.WriteLine("medium speed");
                    break;
                case 2:
                    SetState(3);
                    Console.WriteLine("high speed");
                    break;
                default:
                    SetState(0);
                    Console.WriteLine("turning off");
                    break;
            }
        }

        private void SetState(int state)
        {
            currentState = state;
        }
    }
}