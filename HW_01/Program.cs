// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());

if (numM > numN)
    Console.WriteLine("Число M не может быть больше N");
else
{
    PrintNumbersToN(numN, numM);
}

void PrintNumbersToN(int N, int M)
{
    if (N < M) return;
    PrintNumbersToN(N - 1, M);
    Console.Write(N + " ");
}