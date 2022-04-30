/*
// проверить 5 значне число, палиндром или нет
void palindrom(int pal)
{
    int pal1 = pal/10000;
    int pal5 = pal%10;
    int pal4 = pal/10%10;
    int pal2 = pal/1000%10;
    if(pal1 == pal5 && pal2 ==pal4)
        Console.WriteLine("это число - палиндром");
    else
        Console.WriteLine("это число не является палиндромом");
}
Console.WriteLine("введите 5-ти значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
palindrom(num);

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

double rast3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}
Console.Write("Введите координаты первой точки: х = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки: y = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки: z = ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки: х = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки: y = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки: z = ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Расстояние между точками = " + rast3D(xA, yA, zA, xB, yB, zB));

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void cybe(int A)
{
    int a = 1;
    while(a <= A)
    {
        int cub = a*a*a;
        Console.WriteLine(a +" -> "+ cub);
        a ++;
    }
}
Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
cybe(num);
*/