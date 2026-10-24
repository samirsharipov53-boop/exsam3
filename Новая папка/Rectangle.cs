public class Rectangle : Shape
{
    double H;
    double W;
    public Rectangle(){}

    public Rectangle(double w, double h, string a):base(a)
    {
        W=w;
        H=h;
    }
    public override double GetArea()
    {
       return W*H;
    }

    public override double GetPerimeter()
    {
       return W+W+H+H;
    }
}