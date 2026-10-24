public abstract class Animal
{
    public string? Name{get;set;}
    public Animal(){}
    public Animal(string a)
    {
        Name=a;
    }
    public virtual void MakeSound()
    {
        System.Console.WriteLine("HAv HAv");
    }
    public virtual void Move()
    {
        System.Console.WriteLine($"{Name} walks");
    }
}