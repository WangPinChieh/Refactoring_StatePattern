namespace Refactoring_StatePattern
{
    public class CeilingFanPullChain
    {
        private IState _state;

        public CeilingFanPullChain()
        {
            _state = new Off();
        }

        public void Pull()
        {
            _state.Pull(this);
        }

        public void SetState(IState state)
        {
            _state = state;
        }
    }
}