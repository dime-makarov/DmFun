namespace DmFunApp
{
    internal interface ICalculator
    {
        int Sum(int n1, int n2);
    }

    internal class Calculator : ICalculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
