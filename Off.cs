using System;

namespace Refactoring_StatePattern
{
    public class Off : IState
    {
        public void Pull(CeilingFanPullChain wrapper)
        {
            wrapper.SetState(new Low());
            Console.WriteLine("low speed");
        }
    }
}