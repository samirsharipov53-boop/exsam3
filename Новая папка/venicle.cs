public class Venicle
{
    public string? Brand { get; set; }
    public int Year { get; set; }
    public Venicle(){}
    public Venicle(string b, int a)
    {
        Brand=b;
        Year=a;
    }
    public virtual string GetInfo()
    {
        return $"{Brand}, {Year}";
    }
}