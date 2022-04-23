/*
void qvartDiapason(int q)
{
    if(q == 1)
        Console.WriteLine("Координаты точки в дивпазоне(x > 0; y > 0)");
    else if(q == 2)
        Console.WriteLine("Координаты точки в дивпазоне(x < 0; y > 0)");
    else if(q == 3)
        Console.WriteLine("Координаты точки в дивпазоне(x < 0; y < 0)");
    else if(q == 4)
        Console.WriteLine("Координаты точки в дивпазоне(x > 0; y < 0)");
    else if(q == 0)
        Console.WriteLine("Точка находится на одной из осей");
    else
        Console.WriteLine("Недопустимое значение четверти");
}

Console.WriteLine("Введите номер четверти: ");
int qvart = Convert.ToInt32(Console.ReadLine());
qvartDiapason(qvart);


// задача. нахождение номера четверти точки по координатам
int findQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;
}

Console.WriteLine("Введите значение х: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvart = findQvart(xDot, yDot);
if(qvart > 0)
    Console.WriteLine("Точка лежить в четверти под номером " + qvart);
else
    Console.WriteLine("Точка лежить на одной из осей");
findQvart(xDot, yDot);

// задача. найти расстояни между двумя точками в сист координат

void otrezok(double x1, double y1, double x2, double y2)
{
    double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    Console.WriteLine("Расстояние между точками ровняется "+ AB);
}
Console.Write("Введите координаты первой точки: х = ");
double xA = Convert.ToDouble(Console.ReadLine()); 
Console.Write(" y = ");
double yA = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координаты второй точки: х = ");
double xB = Convert.ToDouble(Console.ReadLine()); 
Console.Write(" y = ");
double yB = Convert.ToDouble(Console.ReadLine()); 
otrezok(xA, yA, xB, yB);

// метод 2
double AB(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}
Console.Write("Введите координаты первой точки: х = ");
double xA = Convert.ToDouble(Console.ReadLine()); 
Console.Write(" y = ");
double yA = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координаты второй точки: х = ");
double xB = Convert.ToDouble(Console.ReadLine()); 
Console.Write(" y = ");
double yB = Convert.ToDouble(Console.ReadLine()); 
Console.Write("расстояние между точками  = " + AB(xA, yA, xB, yB));


//задача. принять на ввод натуральное число и вывести на экран 
//табдицу квадратов чисел от 1 до заданного числа

void Qvadr(int A)
{
    int a = 1;
    while(A > a || A == a)
    {
        int q = a*a;
        Console.WriteLine(a + " -> " + q);
        a++;
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Qvadr(num);
*/