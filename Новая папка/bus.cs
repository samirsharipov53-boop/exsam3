
class Bus : Transport
{
    public Bus() : base("Bus")
    {
    }

    public override double CalculateFare(double km)
    {
        return 3;
    }
}