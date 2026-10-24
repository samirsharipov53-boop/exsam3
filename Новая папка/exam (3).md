# C# — Вазифаҳои амалӣ (навиштани код) (ТОҶИКӢ)

**Меросгирӣ · Абстраксия · Полиморфизм · List**


*Барои ҳар як вазифа коди пурра ва дурусти C# нависед, ки компилятсия шавад. Ҳар як вазифа — 10 хол, ҳамагӣ 100 хол.*

## Вазифаи 1. List<string>: номҳо (10 хол)

- List<string> созед ва 6 ном илова кунед: Ali, Madina, Bob, Anora, Tom, Farrukh.
- Ҳамаи номҳоро бо индексашон чоп кунед (масалан: 0 - Ali).
- Ҳамаи номҳоеро, ки аз 4 ҳарф кӯтоҳтаранд, нест кунед.
- Рӯйхатро мураттаб (Sort) кунед ва боз чоп кунед.
- Аз корбар хоҳиш кунед, ки ном ворид кунад ва чоп кунед, ки оё ин ном дар рӯйхат ҳаст (Contains-ро истифода баред).
- Ҳисоб кунед ва чоп кунед, ки чанд ном бо ҳарфи «A» сар мешавад.

## Вазифаи 2. List<int>: ададҳо (10 хол)

Рӯйхати зерин дода шудааст:

```csharp
List<int> numbers = new List<int> { 5, -3, 12, 0, -7, 8, 15, -1, 20 };
```

Барномае нависед, ки:

- ҳамаи ададҳои манфиро аз рӯйхат нест мекунад;
- чоп мекунад, ки чанд адад боқӣ монд (Count);
- ҷамъ ва қимати миёнаи ададҳоро чоп мекунад;
- калонтарин ададро бе истифодаи numbers.Max() ёфта, чоп мекунад;
- List<int>-и нав месозад, ки танҳо ададҳои аз 10 калонро дорад, ва онро чоп мекунад.

## Вазифаи 3. Person ва Student (10 хол)

- Синфи Person бо хосиятҳои Name (string) ва Age (int), конструктор ва методи виртуалии Introduce() созед, ки чунин чоп кунад: "Hi, I am Ali, 19 years old."
- Синфи Student созед, ки аз Person мерос мегирад ва хосияти Group (string)-ро илова мекунад. Конструктори Student бояд конструктори Person-ро бо ёрии base даъват кунад.
- Методи Introduce()-ро дар Student override кунед, то он гурӯҳро низ чоп кунад, масалан: "My group is 201." (Маслиҳат: base.Introduce()-ро даъват кардан мумкин аст.)
- Дар Main як объекти Person ва як объекти Student созед ва барои ҳардуяш Introduce()-ро даъват кунед.

## Вазифаи 4. Воситаҳои нақлиёт (10 хол)

- Синфи Vehicle бо хосиятҳои Brand ва Year, конструктор ва методи виртуалии GetInfo() созед, ки сатре монанди "Toyota, 2018" бармегардонад.
- Синфҳои Car : Vehicle (хосияти Doors) ва Truck : Vehicle (хосияти Capacity — боркашӣ бо тонна) созед. Ҳардуи онҳо конструктори синфи асосиро бо base даъват мекунанд ва GetInfo()-ро override карда, маълумоти худро илова мекунанд, масалан: "Toyota, 2018, 4 doors".
- Дар Main List<Vehicle> бо на камтар аз 2 мошин ва 2 боркаш созед ва бо foreach GetInfo()-и ҳар якро чоп кунед.
- Танҳо воситаҳоеро чоп кунед, ки баъд аз соли 2015 истеҳсол шудаанд.

## Вазифаи 5. Ҳайвонот (10 хол)

- Синфи абстрактии Animal бо хосияти Name, методи абстрактии MakeSound() ва методи виртуалии Move() созед, ки "{Name} walks"-ро чоп мекунад.
- Синфҳои Dog, Bird ва Fish созед. Ҳар як синф MakeSound()-ро override мекунад. Bird Move()-ро override мекунад ("flies"), Fish низ ("swims"). Dog Move()-ро override намекунад.
- Дар Main List<Animal> созед ва барои ҳар як ҳайвон MakeSound() ва Move()-ро даъват кунед.
- Дар шарҳ (comment) нависед: барои Dog кадом методи Move() даъват мешавад ва чаро?

## Вазифаи 6. Шаклҳо (10 хол)

- Синфи абстрактии Shape бо хосияти Name ва методҳои абстрактии double GetArea() ва double GetPerimeter() созед.
- Синфҳои Circle (Radius) ва Rectangle (Width, Height) созед, ки аз Shape мерос мегиранд. Барои доира Math.PI-ро истифода баред.
- Синфи Square созед, ки аз Rectangle мерос мегирад. Конструктори Square(double side) бояд base(side, side)-ро даъват кунад.
- Дар Main List<Shape> бо на камтар аз 4 шакл созед. Ном, масоҳат ва периметри ҳар якро (бо 2 рақам пас аз вергул), масоҳати умумӣ ва номи шакле, ки масоҳаташ аз ҳама калон аст, чоп кунед.

## Вазифаи 7. Суратҳисобҳои бонкӣ (10 хол)

- Синфи BankAccount бо хосиятҳои Owner ва Balance, методи Deposit(double amount) (танҳо маблағи мусбатро қабул мекунад) ва методи виртуалии bool Withdraw(double amount) созед: гирифтани пул танҳо вақте мумкин аст, ки amount <= Balance бошад.
- Синфи SavingsAccount : BankAccount созед ва Withdraw()-ро override кунед: баъд аз гирифтан дар суратҳисоб на камтар аз 100 бояд боқӣ монад.
- Синфи CreditAccount : BankAccount созед ва Withdraw()-ро override кунед: баланс метавонад то -500 манфӣ шавад.
- Дар Main List<BankAccount> бо се суратҳисоби намудҳои гуногун созед, ки баланси ҳар кадом 800 аст. Кӯшиш кунед, ки аз ҳар як суратҳисоб 1000 гиред ва соҳиб, натиҷа (бомуваффақият / рад шуд) ва баланси навро чоп кунед.

## Вазифаи 8. Нархи сафар (10 хол)

- Синфи абстрактии Transport бо хосияти Name ва методи абстрактии double CalculateFare(double km) созед.
- Се синфи ворис созед: Taxi — нарх = 5 + 2 × km; Bus — ҳамеша 3; Metro — 2, агар km ≤ 10 бошад, вагарна 4.
- Дар Main List<Transport> бо объектҳои Taxi, Bus ва Metro созед. Аз корбар хоҳиш кунед, ки масофаро бо км ворид кунад.
- Нархи сафарро бо ҳар як нақлиёт ва номи арзонтарин вариантро чоп кунед.

## Вазифаи 9. Сабади харид (10 хол)

- Синфи Product бо хосиятҳои Name ва Price ва методи виртуалии double GetFinalPrice() созед, ки Price-ро бармегардонад.
- Синфи DiscountedProduct : Product бо хосияти DiscountPercent созед ва GetFinalPrice()-ро override кунед: нарх минус тахфиф бо фоиз.
- Синфи ShoppingCart бо майдони хусусии (private) List<Product> ва методҳои AddProduct(Product p), bool RemoveProduct(string name), double GetTotal() ва PrintAll() созед.
- Дар Main ба сабад 4 мол илова кунед (на камтар аз 2-то бо тахфиф), сабад ва маблағи умумиро чоп кунед, баъд як молро нест карда, маблағро боз чоп кунед.

## Вазифаи 10. Лоиҳаи хурд: музди меҳнати кормандон (10 хол)

Дар ширкат кормандони намудҳои гуногун кор мекунанд. Барнома нависед:

- Синфи абстрактии Employee бо хосиятҳои Name ва BaseSalary, конструктор, методи абстрактии double CalculateSalary() ва методи оддии PrintInfo() созед, ки ном ва музди ҳисобшударо чоп мекунад.
- Се синфи ворис созед: Manager — музд = BaseSalary + мукофоти 20%; Developer — хосияти OvertimeHours (соатҳои иловагӣ) дорад, музд = BaseSalary + OvertimeHours × 50; Intern — музд = BaseSalary / 2.
- Дар Main List<Employee> бо на камтар аз 4 корманди намудҳои гуногун созед.
- Барои ҳар як корманд PrintInfo()-ро даъват кунед, баъд маблағи умумии музди ҳамаи кормандон ва номи кормандеро, ки музди аз ҳама баландтар дорад, чоп кунед.

---

# C# — Практические задания (написание кода) (РУССКИЙ)

**Наследование · Абстракция · Полиморфизм · List**


*Для каждого задания напишите полный код на C#, который компилируется. Каждое задание — 10 баллов, всего 100 баллов.*

## Задание 1. List<string>: имена (10 баллов)

- Создайте List<string> и добавьте 6 имён: Ali, Madina, Bob, Anora, Tom, Farrukh.
- Выведите все имена с их индексом (например: 0 - Ali).
- Удалите все имена короче 4 букв.
- Отсортируйте список (Sort) и снова выведите его.
- Попросите пользователя ввести имя и выведите, есть ли оно в списке (используйте Contains).
- Посчитайте и выведите, сколько имён начинается с буквы «A».

## Задание 2. List<int>: числа (10 баллов)

Дан список:

```csharp
List<int> numbers = new List<int> { 5, -3, 12, 0, -7, 8, 15, -1, 20 };
```

Напишите программу, которая:

- удаляет из списка все отрицательные числа;
- выводит, сколько чисел осталось (Count);
- выводит сумму и среднее значение чисел;
- находит и выводит наибольшее число, не используя numbers.Max();
- создаёт новый List<int> только с числами больше 10 и выводит его.

## Задание 3. Person и Student (10 баллов)

- Создайте класс Person со свойствами Name (string) и Age (int), конструктором и виртуальным методом Introduce(), который выводит: "Hi, I am Ali, 19 years old."
- Создайте класс Student, который наследуется от Person и добавляет свойство Group (string). Конструктор Student должен вызывать конструктор Person через base.
- Переопределите Introduce() в Student так, чтобы он также выводил группу, например: "My group is 201." (Подсказка: можно вызвать base.Introduce().)
- В Main создайте один объект Person и один объект Student и вызовите Introduce() для обоих.

## Задание 4. Транспортные средства (10 баллов)

- Создайте класс Vehicle со свойствами Brand и Year, конструктором и виртуальным методом GetInfo(), который возвращает строку вида "Toyota, 2018".
- Создайте классы Car : Vehicle (свойство Doors) и Truck : Vehicle (свойство Capacity — грузоподъёмность в тоннах). Оба класса вызывают конструктор базового класса через base и переопределяют GetInfo(), добавляя свои данные, например: "Toyota, 2018, 4 doors".
- В Main создайте List<Vehicle> минимум с 2 легковыми машинами и 2 грузовиками и выведите GetInfo() каждого с помощью foreach.
- Выведите только те транспортные средства, которые выпущены после 2015 года.

## Задание 5. Животные (10 баллов)

- Создайте абстрактный класс Animal со свойством Name, абстрактным методом MakeSound() и виртуальным методом Move(), который выводит "{Name} walks".
- Создайте классы Dog, Bird и Fish. Каждый класс переопределяет MakeSound(). Bird переопределяет Move() ("flies"), Fish тоже ("swims"). Dog не переопределяет Move().
- В Main создайте List<Animal> и для каждого животного вызовите MakeSound() и Move().
- В комментарии напишите: какой метод Move() вызывается для Dog и почему?

## Задание 6. Фигуры (10 баллов)

- Создайте абстрактный класс Shape со свойством Name и абстрактными методами double GetArea() и double GetPerimeter().
- Создайте классы Circle (Radius) и Rectangle (Width, Height), которые наследуются от Shape. Для круга используйте Math.PI.
- Создайте класс Square, который наследуется от Rectangle. Конструктор Square(double side) должен вызывать base(side, side).
- В Main создайте List<Shape> минимум с 4 фигурами. Выведите название, площадь и периметр каждой (2 знака после запятой), общую площадь и название фигуры с наибольшей площадью.

## Задание 7. Банковские счета (10 баллов)

- Создайте класс BankAccount со свойствами Owner и Balance, методом Deposit(double amount) (принимает только положительную сумму) и виртуальным методом bool Withdraw(double amount): снятие возможно, только если amount <= Balance.
- Создайте класс SavingsAccount : BankAccount и переопределите Withdraw(): после снятия на счёте должно остаться не меньше 100.
- Создайте класс CreditAccount : BankAccount и переопределите Withdraw(): баланс может уйти в минус до -500.
- В Main создайте List<BankAccount> с тремя счетами разных типов, у каждого баланс 800. Попробуйте снять 1000 с каждого счёта и выведите владельца, результат (успешно / отказ) и новый баланс.

## Задание 8. Стоимость поездки (10 баллов)

- Создайте абстрактный класс Transport со свойством Name и абстрактным методом double CalculateFare(double km).
- Создайте три класса-наследника: Taxi — стоимость = 5 + 2 × km; Bus — всегда 3; Metro — 2, если km ≤ 10, иначе 4.
- В Main создайте List<Transport> с объектами Taxi, Bus и Metro. Попросите пользователя ввести расстояние в км.
- Выведите стоимость поездки на каждом транспорте и название самого дешёвого варианта.

## Задание 9. Корзина покупок (10 баллов)

- Создайте класс Product со свойствами Name и Price и виртуальным методом double GetFinalPrice(), который возвращает Price.
- Создайте класс DiscountedProduct : Product со свойством DiscountPercent и переопределите GetFinalPrice(): цена минус скидка в процентах.
- Создайте класс ShoppingCart с приватным полем List<Product> и методами AddProduct(Product p), bool RemoveProduct(string name), double GetTotal() и PrintAll().
- В Main добавьте в корзину 4 товара (минимум 2 со скидкой), выведите корзину и сумму, затем удалите один товар и снова выведите сумму.

## Задание 10. Мини-проект: зарплаты сотрудников (10 баллов)

В компании работают сотрудники разных типов. Напишите программу:

- Создайте абстрактный класс Employee со свойствами Name и BaseSalary, конструктором, абстрактным методом double CalculateSalary() и обычным методом PrintInfo(), который выводит имя и рассчитанную зарплату.
- Создайте три дочерних класса: Manager — зарплата = BaseSalary + премия 20%; Developer — имеет свойство OvertimeHours (сверхурочные часы), зарплата = BaseSalary + OvertimeHours × 50; Intern — зарплата = BaseSalary / 2.
- В Main создайте List<Employee> минимум с 4 сотрудниками разных типов.
- Вызовите PrintInfo() для каждого сотрудника, затем выведите общую сумму зарплат всех сотрудников и имя сотрудника с самой высокой зарплатой.

---

# C# — Practical Tasks (Writing Code) (ENGLISH)

**Inheritance · Abstraction · Polymorphism · List**


*For every task, write complete C# code that compiles. Each task is worth 10 points, 100 points in total.*

## Task 1. List<string>: names (10 points)

- Create a List<string> and add 6 names: Ali, Madina, Bob, Anora, Tom, Farrukh.
- Print all names with their index (for example: 0 - Ali).
- Remove all names shorter than 4 letters.
- Sort the list and print it again.
- Ask the user to enter a name and print whether it is in the list (use Contains).
- Count and print how many names start with the letter "A".

## Task 2. List<int>: numbers (10 points)

Start with this list:

```csharp
List<int> numbers = new List<int> { 5, -3, 12, 0, -7, 8, 15, -1, 20 };
```

Write a program that:

- removes all negative numbers from the list;
- prints how many numbers are left (Count);
- prints the sum and the average of the numbers;
- finds and prints the largest number without using numbers.Max();
- creates a new List<int> containing only the numbers greater than 10 and prints it.

## Task 3. Person and Student (10 points)

- Create a class Person with properties Name (string) and Age (int), a constructor, and a virtual method Introduce() that prints: "Hi, I am Ali, 19 years old."
- Create a class Student that inherits from Person and adds the property Group (string). The Student constructor must call the Person constructor using base.
- Override Introduce() in Student so it also prints the group, for example: "My group is 201." (Tip: you can call base.Introduce().)
- In Main, create one Person and one Student and call Introduce() for both.

## Task 4. Vehicles (10 points)

- Create a class Vehicle with properties Brand and Year, a constructor, and a virtual method GetInfo() that returns a string like "Toyota, 2018".
- Create the classes Car : Vehicle (property Doors) and Truck : Vehicle (property Capacity, in tons). Both call the base constructor using base and override GetInfo() to add their own data, for example: "Toyota, 2018, 4 doors".
- In Main, create a List<Vehicle> with at least 2 cars and 2 trucks, and print GetInfo() for each one using foreach.
- Print only the vehicles made after 2015.

## Task 5. Animals (10 points)

- Create an abstract class Animal with a property Name, an abstract method MakeSound(), and a virtual method Move() that prints "{Name} walks".
- Create the classes Dog, Bird and Fish. Each class overrides MakeSound(). Bird overrides Move() ("flies"), and so does Fish ("swims"). Dog does not override Move().
- In Main, create a List<Animal> and call MakeSound() and Move() for every animal.
- In a comment, write which Move() method is called for Dog and why.

## Task 6. Shapes (10 points)

- Create an abstract class Shape with a property Name and the abstract methods double GetArea() and double GetPerimeter().
- Create the classes Circle (Radius) and Rectangle (Width, Height) that inherit from Shape. Use Math.PI for the circle.
- Create a class Square that inherits from Rectangle. The constructor Square(double side) must call base(side, side).
- In Main, create a List<Shape> with at least 4 shapes. Print the name, area and perimeter of each one (2 decimal places), the total area, and the name of the shape with the largest area.

## Task 7. Bank accounts (10 points)

- Create a class BankAccount with properties Owner and Balance, a method Deposit(double amount) (accepts only positive amounts), and a virtual method bool Withdraw(double amount): withdrawing is allowed only if amount <= Balance.
- Create a class SavingsAccount : BankAccount and override Withdraw(): at least 100 must stay in the account after withdrawing.
- Create a class CreditAccount : BankAccount and override Withdraw(): the balance can go down to -500.
- In Main, create a List<BankAccount> with three accounts of different types, each with a balance of 800. Try to withdraw 1000 from each account and print the owner, the result (success / declined) and the new balance.

## Task 8. Trip fare (10 points)

- Create an abstract class Transport with a property Name and an abstract method double CalculateFare(double km).
- Create three child classes: Taxi — fare = 5 + 2 × km; Bus — always 3; Metro — 2 if km ≤ 10, otherwise 4.
- In Main, create a List<Transport> with Taxi, Bus and Metro objects. Ask the user to enter the distance in km.
- Print the fare for each type of transport and the name of the cheapest option.

## Task 9. Shopping cart (10 points)

- Create a class Product with properties Name and Price and a virtual method double GetFinalPrice() that returns Price.
- Create a class DiscountedProduct : Product with a property DiscountPercent and override GetFinalPrice(): the price minus the percentage discount.
- Create a class ShoppingCart with a private List<Product> field and the methods AddProduct(Product p), bool RemoveProduct(string name), double GetTotal() and PrintAll().
- In Main, add 4 products to the cart (at least 2 with a discount), print the cart and the total, then remove one product and print the total again.

## Task 10. Mini-project: employee salaries (10 points)

A company has different types of employees. Write a program:

- Create an abstract class Employee with properties Name and BaseSalary, a constructor, an abstract method double CalculateSalary(), and a normal method PrintInfo() that prints the name and the calculated salary.
- Create three child classes: Manager — salary = BaseSalary + 20% bonus; Developer — has a property OvertimeHours, salary = BaseSalary + OvertimeHours × 50; Intern — salary = BaseSalary / 2.
- In Main, create a List<Employee> with at least 4 employees of different types.
- Call PrintInfo() for every employee, then print the total salary of all employees and the name of the employee with the highest salary.
