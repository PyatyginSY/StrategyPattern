using System;

namespace StrategyPattern
{
    public class TransformerDistribution : IStrategy
    {
        public void CalculateTransformer()
        {
            Console.WriteLine("Calculate transformer distribution. Get 10 kV");
        }
    }
}
