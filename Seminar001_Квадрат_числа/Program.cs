Console.WriteLine("Введите число № 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == Math.Pow(number2, 2))
{
    Console.WriteLine("Число № 2 является квадратом числа 1");
}
else
{
    if (number2 == Math.Pow(number1, 2)) 
    {
        Console.WriteLine("Число № 1 является квадратом числа 2");
    }
    else
    {
        Console.WriteLine("Не являются");
    }
}
