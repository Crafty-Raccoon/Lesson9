//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5-> "2, 4"
//M = 4; N = 8-> "4, 6, 8"


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Recursion(m, n);

void Recursion(int m, int n)
{
    if (m > n)
        Console.WriteLine("M должно быть меньше N");
    if (m == n)
        Console.Write("");
    if (m < n)
    {
            if (m % 2 == 0)
                Console.WriteLine($"{m} ");
        Recursion(m+1, n);
    }
}