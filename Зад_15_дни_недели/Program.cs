int number = new int();

Console.Write("Введите номер дня недели: ");
number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 6:
        {
            Console.Write("Является выходным днём");
            break;
        }
    case 7:
        {
            Console.Write("Является выходным днём");
            break;
        }
    case 1:
        {
            Console.Write("Не является выходным днём");
            break;
        }
    case 2:
        {
            Console.Write("Не является выходным днём");
            break;
        }
    case 3:
        {
            Console.Write("Не является выходным днём");
            break;
        }
    case 4:
        {
            Console.Write("Не является выходным днём");
            break;
        }
    case 5:
        {
            Console.Write("Не является выходным днём");
            break;
        }
    default:
        {
            Console.Write("Такого дня недели не существует");
            break;
        }
}
