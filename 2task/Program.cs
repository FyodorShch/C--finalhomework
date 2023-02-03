/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
int sum = SummOfNumbers(N, M);
Console.Write($"{sum}");

int SummOfNumbers(int n, int m)
{
    int a = 0;
    if (n == m)
    {
        return n;
    }
    a = n + SummOfNumbers(n + 1, m);
    return a;
}