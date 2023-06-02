// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.Clear();

int Lengthnum(int num)
{
    int Length = 0;
    while(Length<num)
    {
        Length++;
        num/=10;
    }
    return Length;
}

int SumNum(int num)
{
    int result = 0;
    int length = Lengthnum(num);
    for (int i = 0; i <= length; i++)
    {
        result += num%10;
        num/=10; 
    }
    return result;
}


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum = SumNum(num);
System.Console.WriteLine($"Сумма чисел: {Sum}");