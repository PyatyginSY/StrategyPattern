using System;

namespace StrategyPattern
{
    public class TransformerPower : IStrategy
    {
        public void CalculateTransformer()
        {
            Console.WriteLine("Calculate transformer power. Get 35 kV");
        }
    }
}
