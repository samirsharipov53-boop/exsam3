// task 1
List<string> names = new List<string>(){"ali", "Mdina", "bob", "Anora", "Tom", "farukh"};
// for(int i=0; i<=names.Count(); i++)
// {
//     System.Console.WriteLine(i+" "+names[i]);
// }
// names.RemoveAll(x=>x.Length<4);
// names.Sort();
// foreach (var item in names)
// {
//     System.Console.WriteLine(item);
// }
// string a=Console.ReadLine();
// bool s=names.Contains(a);
// System.Console.WriteLine(s);
// int cnt=0;
// foreach (var item in names)
// {
//     if(item[0]=='a' || item[0] == 'A')
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

// // Task 2
// List<int> numbers = new List<int> { 5, -3, 12, 0, -7, 8, 15, -1, 20 };
// // numbers.RemoveAll(x=>x<0);
// System.Console.WriteLine(numbers.Count());
// System.Console.WriteLine(numbers.Sum());
// System.Console.WriteLine(numbers.Average());
// int max = int.MinValue;
// List<int> nums10= [];
// foreach (var item in numbers)
// {
//     if(item>max) max=item;
//     if (item => 10)
//     {
//         nums10.Add(item);
//     }
// }
// System.Console.WriteLine(max);
// foreach (var item in nums10)
// {
//     System.Console.Write(item+" ");
// }
// // Task 3
// Person person=  new Person("Qrbon", 18);
// Student student= new Student("Ali", 21);
// person.Introduce();
// System.Console.WriteLine();
// student.Introduce();
// // Task 4
// List<Venicle> venicles = new List<Venicle>();
// Car car1 = new Car("Range", 2019, 4);
// Car car2 = new Car("Ferarri", 2019, 2);
// Car car3 = new Car("BMW m8", 2022, 2);
// Truc truc1 = new Truc("Shacman", 2013, 200);
// Truc truc2 = new Truc("Motorol", 2025, 2);
// venicles.AddRange(car1, car2, car3, truc1, truc2);
// foreach (var item in venicles)
// {
//     if(item.Year>2015) System.Console.WriteLine(item.Brand+" "+item.Year);
// }
// // Task 5
// List<Animal> animals = new List<Animal>();
// //Metodi movero dar dog ivaz nakardem baroi on ki sag roh megardad
// Dog dog = new Dog("Tom");
// Fish fish = new Fish("Dummy");
// Bird bird = new Bird("Tuti");
// dog.Move();
// dog.MakeSound();
// fish.Move();
// fish.MakeSound();
// bird.Move();
// bird.MakeSound();

// // Task 6
// List<Shape> shapes = new List<Shape>();
// Rectangle rectangle = new Rectangle(1.2, 2.1, "kk");
// Circle circle = new Circle(2.3, "AA");
// Rectangle rectangle1 = new Rectangle(1.2, 2.1, "kk");
// Circle circle1 = new Circle(2.3, "AA");
// shapes.AddRange(rectangle, rectangle1, circle, circle1);
// foreach (var item in shapes)
// {
//     System.Console.WriteLine(item.GetArea()+" "+item.GetPerimeter()+" "+item.Name);
// }
// // Task 7
// List<BankAcount> bankAcounts = new List<BankAcount>();
// CreditAcc creditAcc1 = new CreditAcc("ahmad", 800);
// CreditAcc creditAcc2 = new CreditAcc("ahmad", 800);
// CreditAcc creditAcc3 = new CreditAcc("ahmad", 800);
// CreditAcc creditAcc4 = new CreditAcc("ahmad", 800);
// CreditAcc creditAcc5 = new CreditAcc("ahmad", 800);
// CreditAcc creditAcc6 = new CreditAcc("ahmad", 800);
// bankAcounts.AddRange(creditAcc1,creditAcc2,creditAcc3,creditAcc4,creditAcc5,creditAcc6);
// foreach (var item in bankAcounts)
// {
//     System.Console.WriteLine(item.Withdraw(1000));
// }
// // Task 8

//         List<Transport> list = new List<Transport>();
//         Taxi taxi = new Taxi();
//         list.Add(taxi);
//         Bus bus = new Bus();
//         list.Add(bus);
//         Metro metro = new Metro();
//         list.Add(metro);

//         double km = Convert.ToDouble(Console.ReadLine());

//         double minPrice = list[0].CalculateFare(km);
//         string cheapName = list[0].Namei;

//         foreach (Transport t in list)
//         {
//             double price = t.CalculateFare(km);

//             Console.WriteLine(t.Namei + ": " + price);

//             if (price < minPrice)
//             {
//                 minPrice = price;
//                 cheapName = t.Namei;
//             }
//         }

//         Console.WriteLine("Cheapest transport: " + cheapName);
    