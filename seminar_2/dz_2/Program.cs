/*
// задача 10

void secondNum(int num)
{
    int num2 = num/10;
    int second = num2%10;
    Console.WriteLine("Вторая цифра - " + second);
}
Console.WriteLine("Введите исходное число: ");
int num = Convert.ToInt32(Console.ReadLine());
secondNum(num);

// задача 13

void threeNum(int num)
{
    if(num/100 < 1)
    {
        Console.WriteLine("третей цифры нет");
    }
    else
    {
        while (num/100 > 10)
            num = num/10;
        int three = num%10;
        Console.WriteLine("Третья цифра равна "+ three);
    }
}
Console.WriteLine("Введите исходное число: ");
int num = Convert.ToInt32(Console.ReadLine());
threeNum(num);

*/
// задача 15

void weekend(int day)
{
    if(day > 7)
    {
        Console.WriteLine("Дня недели с таким номером не существует");
    }
    else
    {
        if(day < 6)
        {
            Console.WriteLine("нет");
        }
        else
        {
            Console.WriteLine("да");
        }
    }
}
Console.WriteLine("введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
weekend(day);