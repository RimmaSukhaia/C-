
void ShowNumber(int num)
{
    int firstNum = num/10;
    int secondNum = num%10;
    if(firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
int num = new Random().Next(10,99); 
Console.Write(num +" -> ");
ShowNumber(num);
/*
// задача 1

void NewNumber()
{
    int num = new Random().Next(100,999);
    int firstNum = num/100;
    int threeNum = num%10;
    int newN = firstNum*10 + threeNum;
    Console.WriteLine(num +" -> " + newN);
}
NewNumber();


//задача 2

void delenie(int num1, int num2)
{
    int ost = num1%num2;
    if(ost == 0)
    {
      Console.WriteLine(num1 + " кратно " + num2);
    }
    else
    {
        Console.WriteLine(num1+ " не кратно " + num2 + ". Остаток = " + ost);
    }
}
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
delenie(num1, num2);


// задача3

void delenie(int num)
{
    int del7 = num%7;
    int del23 = num%23;
    if (del7 == 0 && del23 == 0)
    {
        Console.WriteLine(num +" делиться на 7 и 23 нацело");
    }
    else
    {
        Console.WriteLine(num +" не делиться ");
    }
}
Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
delenie(num);


// задача 4

void kvadrat(int num, int kvadr)
{
    if(kvadr == num*num)
    {
        Console.WriteLine(kvadr + " является квадратом числа " + num);
    }
    else
    {
        Console.WriteLine(kvadr + " НЕ является квадратом числа " + num);
    }
}
Console.WriteLine("Ввудите число возводимое в квадрат: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите предполагаемый квадрат первого числа: ");
int kvadr = Convert.ToInt32(Console.ReadLine());
kvadrat(num, kvadr);

*/