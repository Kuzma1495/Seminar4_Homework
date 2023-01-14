// Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int Summary(int a)
{
    int b = Convert.ToString(a).Length;
    int count = 0;
    int result = 0;

    for (int i = 0; i < b; i++)
    {
        count = a - a % 10;
        result = result + (a - count);
        a = a / 10;
    }
    return result;
}

int c = Summary(a);
Console.WriteLine(c);