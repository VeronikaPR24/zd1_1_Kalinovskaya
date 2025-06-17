using zd1_Kalinovskaya;
string name;
double weight;
while (true)
{
    Console.Write("Введите имя кота: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name))
        break;
    Console.WriteLine("Имя не может быть пустым!");
}
Cat cat = new Cat(name);// Создаем экземпляр класса Cat
if (!cat.SetCatName(name))
{
    return;
}

while (true)
{
    Console.Write($"Введите вес кота {name}: ");
    string input = Console.ReadLine();
    if (double.TryParse(input, out weight))
        break;
    Console.WriteLine("Вес введите числом");
}
Cat catW = new Cat(weight);// Создаем экземпляр класса Cat
if (!cat.SetCatWeight(weight))
{
    return;
}
cat.PrintInfo();
cat.Meow();
Console.ReadKey();