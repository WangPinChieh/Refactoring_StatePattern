using System;

namespace Refactoring_StatePattern
{
    public interface IState
    {
        void Pull();
    }

    public class Off : IState
    {
        private readonly CeilingFanPullChain _ceilingFanPullChain;

        public Off(CeilingFanPullChain ceilingFanPullChain)
        {
            _ceilingFanPullChain = ceilingFanPullChain;
        }

        public void Pull()
        {
            _ceilingFanPullChain.SetState(1);
            Console.WriteLine("low speed");
        }
    }

    public class CeilingFanPullChain
    {
        private int _currentState;
        private readonly IState _state;

        public CeilingFanPullChain()
        {
            _currentState = 0;
            _state = new Off(this);
        }

        public void pull()
        {
            switch (_currentState)
            {
                case 0:
                    _state.Pull();
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

        public void SetState(int state)
        {
            _currentState = state;
        }
    }
}