int number = new int();
int numeral = new int();
int count = 0;
int length = 0;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

numeral = number;
while (numeral > 0)
{
    numeral = numeral / 10;
    count++;
}

int[] array = new int[count];
while (length < count)
{
    array[length] = number % 10;
    number = number / 10;
    length++;
}
if (count >= 3)
{
    Console.WriteLine($"Третья цифра числа - {array[count - 3]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
