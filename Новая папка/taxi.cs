
class Taxi : Transport
{
    public Taxi() : base("Taxi")
    {
    }

    public override double CalculateFare(double km)
    {
        return 5 + 2 * km;
    }
}