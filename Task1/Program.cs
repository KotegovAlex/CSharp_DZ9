/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEvenTwoNaturalList(int M, int N)
{
    if (N < M)
    {
        return;
    }
    PrintEvenTwoNaturalList(M, N - 1);
    if (N % 2 == 0) Console.Write(N + " ");
}

int M = Promt("Введите натуральное число M > ");
int N = Promt("Введите натуральное число N > ");
PrintEvenTwoNaturalList(M, N);