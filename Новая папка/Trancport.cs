
abstract class Transport
{
    public string Namei{get;set;}=null!;

public Transport(){}
    public Transport(string name)
    {
        this.Namei = name;
    }

    public abstract double CalculateFare(double km);
}
