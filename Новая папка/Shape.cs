public abstract class Shape
{
    public string? Name{get;set;}
    public Shape(){}
    public Shape(string a)
    {
        Name=a;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();

}