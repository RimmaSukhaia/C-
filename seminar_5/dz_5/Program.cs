/*
//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
void Cikl(int a, int b)
{
    int itog = a;
    for(int i = 0; i < b-1; i++)
    {
        itog *=a;
    }
    Console.Write("Число А в степени В - " + itog);
}
Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Cikl(numA, numB);


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void NumbersSum(int num)
{
    int sum = 0;
    while(num >10)
    {
        sum += num%10;
        num /= 10;
    }
    sum +=num;
    Console.Write("сумма цифр в числе = "+sum);
}
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersSum(number);
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 void Array()
 {
     int [] myArray = new int[8];
     for(int i = 0; i < myArray.Length; i++)
     {
         myArray[i] = new Random().Next(0, 20);
         Console.Write(myArray[i] + " ");
     }
 }
 Array();

