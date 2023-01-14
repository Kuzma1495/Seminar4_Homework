// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

int ABC(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res*a;
    }
    return res;
}


Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine(Math.Pow(a,b)); 

int c = ABC(a, b);
Console.WriteLine(c);
