public class Circle : Shape
{
    double Rad;
    public Circle (){}
    public Circle (double r, string a):base(a)
    {
        Rad = r;
    }

    public override double GetArea()
    {
      return Rad*Rad*Math.PI;
    }

    public override double GetPerimeter()
    {
        return 2*Rad;
    }
}