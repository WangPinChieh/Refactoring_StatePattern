using System;

namespace Refactoring_StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceilingFanPullChain = new CeilingFanPullChain();
            while (true)
            {
                Console.WriteLine("Press Enter");
                Console.ReadLine();
                ceilingFanPullChain.Pull();
            }
        }
    }
}