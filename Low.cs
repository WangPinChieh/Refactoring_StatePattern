using System;

namespace Refactoring_StatePattern
{
    public class Low : IState
    {
        public void Pull(CeilingFanPullChain wrapper)
        {
            wrapper.SetState(new Medium());
            Console.WriteLine("medium speed");
        }
    }
}