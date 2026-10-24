public class Bird : Animal
{
    public override void Move()
    {
       System.Console.WriteLine(d+" Flies");
    }
    public override void MakeSound()
    {
      System.Console.WriteLine("Pchir Pchir");
    }
    string d;
    public Bird()
    {
    }
    public Bird(string a) : base(a)
    {
     d=a;   
    }
}