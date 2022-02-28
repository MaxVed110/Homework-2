int number = new int();
int TwoNumber = new int();

number = new Random().Next(100, 1000);
TwoNumber = (number / 10) % 10;


Console.Write("Рандомное трёхзначное число: ");
Console.WriteLine(number.ToString());
Console.WriteLine($"Вторая цифра числа - {TwoNumber}");
