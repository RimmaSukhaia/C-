/*
// Задача 1(лекция). Упорядочить массив в порядке возрастания чисел.
int [] arr = {2,4, 1, 7, 8, 5, 6, 3, 1, 1};
void PrintArray (int [] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort (int [] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPozition = i;
        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPozition]) minPozition = j;
        }
        int temparary = array[i];
        array[i] = array[minPozition];
        array[minPozition] = temparary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);



// Задача 2(лекция). Упорядочить массив в порятке уменьшения чисел.
int [] arr2 = {3, 6, 3, 1, 6, 8 ,8 ,1, 4 ,5 ,1};
void PrintArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionMax(int [] array)
{
    for(int i =0; i < array.Length -1; i++)
    {
        int MaxPozit = i;
        for(int j= i + 1; j < array.Length; j++)
        {
            if (array [j] > MaxPozit) MaxPozit = j;
        }
        int peremennaya = array [i];
        array [i] = array[MaxPozit];
        array [MaxPozit] = peremennaya;
    }
}
PrintArray(arr2);
selectionMax(arr2);

PrintArray(arr2);


// задача1. вычислить сумму всех чисел от 1 до N
int NaturalSum (int n)
{
    int sum =0;
    if(n < 1) return 0;
    else
    {
        for(int i = 1; i <= n; i++)
        sum += i;
    }
    return sum;
}
Console.WriteLine("Ввудите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сумма элементов равна "+NaturalSum(num));


//задача 2. ввести число. Определить сколько цифр в числе
int digNum(int n)
{
    int i;
    for(i = 0; n >0; i++)
    {
        n = n/10;
    }
    return i;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество цифр в числе - "+ digNum(num));

//задача 3. Ввести число N. Найти произведение всех чисел от 1 до N
int factorial(int N)
{
    int factorial =1;
    if(N <1) return 0;
    else
    {
        for(int i = 1; i <= N; i++)
        factorial *=i;
    }
    return factorial;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("произведение чисел от 1 до заданного числа - "+ factorial(num));


// задача 4. Создать массив из 12ти случайных чисел в диапазоне от -9 до 9.
// найти сумму отрицательных чисел и сумму положительных.

int [] CreateRandomArray(int size, int min, int max)
{
    int [] array = new int[size];
    for(int i =0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
int [] CreateArray(int size)
{
    int [] array = new int[size];
    for(int i =0; i < size; i++)
    {
        Console.Write("введите "+ i +"элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void showArray(int [] array)
{
    for(int i =0; i < array.Length; i++)
    Console.Write(array [i]+" ");
    Console.WriteLine();
}
void FindSumOffElement(int [] array)
{
    int plusSum =0;
    int minusSum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            plusSum += array[i];
        else
            minusSum += array[i];
    }
    Console.WriteLine("Сумма положительный элементов "+plusSum);
    Console.WriteLine("Сумма отрицательных элементов "+minusSum);
}
int [] myArray = CreateRandomArray(12, -9, 9);
showArray(myArray);
FindSumOffElement(myArray);
*/

//задача 5. Создать случайный массив из 8 элементов, цифры 0 и 1
int [] newMassiv(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i]+ " ");
    }
    return array;                
}
newMassiv(8);
