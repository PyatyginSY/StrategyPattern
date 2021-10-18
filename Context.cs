using System.Collections.Generic;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetСalculateTransformer()
        {
            _strategy.CalculateTransformer();
        }


    }
}
