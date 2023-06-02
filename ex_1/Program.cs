// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int StepenChisla(int num, int stepen)
{
    int count = 1;
    for (int i = 0; i < stepen; i++)
    {
        count*=num;
    }
    return count;
}

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите степень: ");
int stepen = Convert.ToInt32(Console.ReadLine());

int result = StepenChisla(num,stepen);
System.Console.WriteLine($"Результат: {result}");