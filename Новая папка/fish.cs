public class Fish : Animal
{
    public override void Move()
    {
       System.Console.WriteLine(d+" swims");
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("BOOL BOOL");
    }
    public Fish()
    {
    }
string d;
    public Fish(string a) : base(a)
    {
     d=a;   
    }
}