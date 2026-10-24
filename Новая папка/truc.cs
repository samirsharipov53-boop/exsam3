public class Truc : Venicle
{
    public int Capacity{get;set;}
    public override string GetInfo()
    {
        return base.GetInfo()+$"Capasity:{Capacity}";
    }
    public Truc()
    {
    }

    public Truc(string b, int a, int c) : base(b, a)
    {
        Capacity = c;
    }
}