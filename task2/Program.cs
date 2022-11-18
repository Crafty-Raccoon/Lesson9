//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15-> 120
//M = 4; N = 8-> 30


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Recursion(m, n));

int Recursion(int m, int n)
{
    if (m > n || m < 0 || n < 0)
        Console.WriteLine("M должно быть меньше N или натуральным");
    if (m == n) return n;
    else return m + Recursion(m + 1, n);
}
