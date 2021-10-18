using System;

namespace StrategyPattern
{
    public class TransformerPump : IStrategy
    {
        public void CalculateTransformer()
        {
            Console.WriteLine("Calculate transformer pump. Get 1 kV");
        }
    }
}
