

class Metro : Transport
{
    public Metro() : base("Metro")
    {
    }

    public override double CalculateFare(double km)
    {
        if (km <= 10)
        {
            return 2;
        }
        else
        {
            return 4;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Transport> list = new List<Transport>();

        list.Add(new Taxi());
        list.Add(new Bus());
        list.Add(new Metro());

        Console.Write("Enter distance in km: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double minPrice = list[0].CalculateFare(km);
        string cheapName = list[0].Name;

        foreach (Transport t in list)
        {
            double price = t.CalculateFare(km);

            Console.WriteLine(t.Name + ": " + price);

            if (price < minPrice)
            {
                minPrice = price;
                cheapName = t.Name;
            }
        }

        Console.WriteLine("Cheapest transport: " + cheapName);
    }
}