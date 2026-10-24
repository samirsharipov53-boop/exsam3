using Microsoft.VisualBasic;

public class Student : Person
{
    public override void Introduce()
    {
        base.Introduce();
        System.Console.WriteLine("   My group is 201");
    }
    public Student()
    {
    }

    public Student(string a, int s) : base(a, s)
    {
    }
}