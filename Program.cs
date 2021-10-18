using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StrategyPattern");

            Context context;

            context = new Context(new TransformerPower());
            context.SetСalculateTransformer();

            context = new Context(new TransformerDistribution());
            context.SetСalculateTransformer();

            context = new Context(new TransformerPump());
            context.SetСalculateTransformer();

            context.SetStrategy(new TransformerPower());
            context.SetСalculateTransformer();

            Console.ReadLine();
        }
    }
}
