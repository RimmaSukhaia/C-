/*
//Создать случайный массив и написать программу. которая будет давать массив
// с противоположными цифрами.
int [] firstArray (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
int [] ChangeNums(int [] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write(arr[i]+ " ");
    }
    return arr;
}
int [] myArray = firstArray(6, -10, 10);
ChangeNums(myArray);


//Создать массив и написать программуб которая определит, 
//присутствует ли в массиве заданное число
int [] numArray (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
int CheckingNum(int [] array, int num)
{
    int yes = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
           yes = 1;
    }
    if(yes == 1)
        Console.WriteLine("число "+num + " присутствует в массиве");
    else
        Console.WriteLine("число "+num + " отсутствует в массиве");
    return num;
}
    
Console.WriteLine("Введите нижнюю границу массива ");
int minDiapason = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу массива ");
int maxDiapason = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов массива ");
int volumeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > maxDiapason || number < minDiapason)
    Console.WriteLine("число для проверки не входит в диапазон заданного массива");
else
{
    int [] myArray = numArray(volumeArray, minDiapason, maxDiapason);
    CheckingNum(myArray, number);
}

// метод 2
int [] numArray2 (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
string FindNum (int[] array, int num)
{
    for(int i =0; i<array.Length; i++)
    {
        if(array[i]== num)
        return "Число присутствует в массиве";
    }
    return "число отсутствует";
}
Console.WriteLine("Введите нижнюю границу массива ");
int minDiapason = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу массива ");
int maxDiapason = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов массива ");
int volumeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > maxDiapason || number < minDiapason)
    Console.WriteLine("число для проверки не входит в диапазон заданного массива");
else
{
    int [] myArray = numArray2(volumeArray, minDiapason, maxDiapason);
    Console.WriteLine(FindNum(myArray, number));
}


//задача 3. Создать массив из 15 случайных элементов.
//Найти количество элементов которое находится в отрезке от 10 до 99. Вывести их на экран.
int [] diapArray (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
int [] SpecDiapason (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>10 && array[i]<101)
            Console.Write(array[i]+" ");
    }
    return array;
}
int [] myArray = diapArray(15,0, 150);
SpecDiapason(myArray);

*/
//задача 4. Нещбходимо найти произведения крайнихчисел в массиве.
// И вывести их на экран.
int [] ArrayForMultiplication (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
    return array;
}
int [] multiplication (int [] array)
{
    int size= array.Length; 
    for(int i = 0; i < size/2; i++)
    {
        int firstMult = array[i];
        int secondMult = array[size-1-i];
        int mult = firstMult*secondMult;
        Console.Write(mult+ " ");
    }
    return array;
}
// метод 2 - не получился
// int[] newMagicArray (int[] array2)
// {
//     int newSize = array2.Length /2;
//     int[] newArray2 = new int[newSize];
//     for(int i = 0, j = array2.Length-1; i < newSize; i++, j++)
//     {
//         newArray2[i] = array2[i]*array2[j];
//     }
//     return newArray2;
// }
int [] myArray = ArrayForMultiplication(10, 1, 10);
multiplication(myArray);
//Console.Write(" "+ newMagicArray(myArray));