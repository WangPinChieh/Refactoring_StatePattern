using System;

namespace Refactoring_StatePattern
{
    public class Medium : IState
    {
        public void Pull(CeilingFanPullChain wratter)
        {
            wratter.SetState(new High());
            Console.WriteLine("high speed");
        }
    }
}