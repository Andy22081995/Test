namespace Test.Core.Services
{
    public class CounterService : ICounterService
    {
        public double Decrease(double value, double increment)
        {
            return value -= increment;
        }

        public double Increase(double value, double increment)
        {
            return value += increment;
        }

        public double Reset()
        {
            return 0;
        }
    }
}
