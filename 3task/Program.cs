/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"{akkerman(N, M)}");

int akkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else
    {
        if (a != 0 && b == 0)
        {
            return akkerman(a - 1, 1);
        }
        else
        {
            return akkerman(a - 1, akkerman(a, b - 1));
        }
    }
}