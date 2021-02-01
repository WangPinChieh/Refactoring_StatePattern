using System;

namespace Refactoring_StatePattern
{
    public class High : IState
    {
        public void Pull(CeilingFanPullChain wrapper)
        {
            wrapper.SetState(new Off());
            Console.WriteLine("turing off");
            
        }
    }
}