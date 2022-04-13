/*
// Задача 1.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine("Наибольшее число - " + num1);
else
    Console.WriteLine("Наибольшее число - " + num2);


// Задача 2.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
        Console.WriteLine("Наибольшее число - " + num1);
    else
        Console.WriteLine("Наибольшее число - " + num3);
}
else
{
    if(num2 > num3)
        Console.WriteLine("Наибольшее число - " + num2);
    else
        Console.WriteLine("Наибольшее число - " + num3);
}

//Задача 3.
Console.WriteLine("Введите число, для проверки на четность: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine(num +" - четное число.");
else
    Console.WriteLine(num +" - не четное число.");

*/

//Задача 4.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= num)
    if(current % 2 == 0)
    {
        Console.Write(current +" ");
        current ++;
    }
    else
        current ++;

