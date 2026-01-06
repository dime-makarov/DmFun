namespace DmFunApp
{
    internal interface INumberProvider
    {
        int GetInteger();
    }

    internal class NumberProvider : INumberProvider
    {
        public int GetInteger()
        {
            return new Random().Next(100);
        }
    }
}
