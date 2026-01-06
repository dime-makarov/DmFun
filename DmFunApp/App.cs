namespace DmFunApp
{
    internal interface IApp
    {
        void Run();
    }

    internal class App : IApp
    {
        private readonly INumberProvider numberProvider;
        private readonly ICalculator calculator;

        public App(INumberProvider numberProvider, ICalculator calculator)
        {
            this.numberProvider = numberProvider;
            this.calculator = calculator;
        }

        public void Run()
        {
            int n1 = numberProvider.GetInteger();
            int n2 = numberProvider.GetInteger();

            int s = calculator.Sum(n1, n2);

            Console.WriteLine($"{n1} + {n2} = {s}");
        }
    }
}
