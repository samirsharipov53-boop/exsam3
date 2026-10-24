public class Person
{
    public string? Name { get; set; }
    public int age { get; set; }
    public Person(){}
    public Person(string a, int s)
    {
        Name=a;
        age=s;
    }
    public virtual void Introduce()
    {
        System.Console.Write($"Hi i am {Name}. I am {age} years old");
    }
}