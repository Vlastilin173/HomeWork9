// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaNaturalotMdoN (int M, int N)
{
    if (M == N) return N;     
    return N += SummaNaturalotMdoN(M, N - 1);
}

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"M = {M}; N = {N} -> {SummaNaturalotMdoN(M, N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Function(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Function(m - 1, 1);
    else return (Function(m - 1, Function(m, n - 1)));
}

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"m = {m}, n = {n} -> A(m,n) = {Function(m, n)}");
