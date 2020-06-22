namespace DynamicTypeChecking.Types
{
    public interface IActionHandler<in TAction> where TAction : IAction
    {
        void Execute(TAction action);
    }
}