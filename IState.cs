namespace Refactoring_StatePattern
{
    public interface IState
    {
        void Pull(CeilingFanPullChain wrapper);
    }
}