int number = new int();
int TwoNumber = new int();

Console.Write("Введите трёхзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

TwoNumber = (number / 10) % 10;

Console.WriteLine($"Вторая цифра числа - {TwoNumber}");
