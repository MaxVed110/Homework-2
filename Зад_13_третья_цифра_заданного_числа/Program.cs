int number = new int();
int numeral = new int();
int count = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

count = 0;
numeral = number;
while (numeral > 0)
{
    numeral = numeral / 10;
    count++;
}
if (count >= 3)
{
    number = number / Convert.ToInt32(Math.Pow(10, (count-3)));
    number = number % 10;
    Console.WriteLine($"Третья цифра числа - {number}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
