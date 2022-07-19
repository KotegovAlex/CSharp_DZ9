/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int NaturalNumbersSum(int M, int N)
{
    if (N < M)
    {
        return 0;
    }
    return NaturalNumbersSum(M, N - 1) + N;
}

int M = Promt("Введите натуральное число M > ");
int N = Promt("Введите натуральное число N > ");
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {NaturalNumbersSum(M, N)}");