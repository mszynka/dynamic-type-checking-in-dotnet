using System.Data;

namespace DynamicTypeChecking.Types
{
    public class SampleHandler : IActionHandler<SampleAction>
    {
        public void Execute(SampleAction action)
        {
            throw new DataException("Sample action");
        }
    }
}