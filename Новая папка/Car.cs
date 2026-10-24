public class Car : Venicle
{
    public int Doors{get;set;}
    
    public Car()
    {
    }

    public Car(string b, int a, int d) : base(b, a)
    {
        Doors=d;
    }
    public override string GetInfo()
    {
        return base.GetInfo()+$"Doors:{Doors}";
    }
}