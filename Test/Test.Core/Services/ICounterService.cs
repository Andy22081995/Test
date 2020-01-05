namespace Test.Core.Services
{
    public interface ICounterService
    {
        double Increase(double value, double increment);
        double Decrease(double value, double increment);
        double Reset();
    }
}
