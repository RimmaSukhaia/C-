/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int [] ThreedigitArray (int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
void Pariti (int [] array)
{
    int even = 0;
    int uneven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            even ++;
        else
            uneven ++;
    }
    Console.WriteLine("количество нечетных чисел - "+ uneven);
    Console.WriteLine("количество четных чисел - "+ even);
}
int [] myArray = ThreedigitArray(4);
Pariti(myArray);

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int [] ParitiPozitionArray (int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,101);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
void ParitiPozitionSum(int [] array)
{
    int unevenPositionSum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 > 0)
        {
            unevenPositionSum += array[i];
        }    
    }
    Console.WriteLine("сумма элементов, на нечетных позииях = "+ unevenPositionSum);
}
int [] myArray = ParitiPozitionArray(4);
ParitiPozitionSum(myArray);
*/

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
double [] RealNumberArray (int size)
{
    double [] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
    return array;
}
void DiffMaxMinNumbers(double [] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNum)
            maxNum = array[i];
        else if(array[i] < minNum)
            minNum = array[i];
    }
    double diff = maxNum-minNum;
    Console.WriteLine("Разниц между максимальным и минимальным числом - "+ diff);
}
double [] myArray = RealNumberArray(6);
DiffMaxMinNumbers(myArray);
