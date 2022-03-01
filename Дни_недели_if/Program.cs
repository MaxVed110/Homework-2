int number = new int();

Console.Write("Введите номер дня недели: ");
number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    Console.Write("Не является выходным днём");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.Write("Является выходным днём");
    }
    else
    {
        Console.Write("Такого дня недели не существует");
    }
}

