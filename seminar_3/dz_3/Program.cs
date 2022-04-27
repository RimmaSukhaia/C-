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
*/