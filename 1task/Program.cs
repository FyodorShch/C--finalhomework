/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

int N = Convert.ToInt32(Console.ReadLine());
SequenceOfNumbers(N);

void SequenceOfNumbers(int M)
{
    if(M < 1)
    {
        return;
    }
    Console.Write($"{M} ");
    SequenceOfNumbers(M-1);
}  