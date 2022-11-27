// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM > numN)
    Console.WriteLine("Число M не может быть больше N");
else
{
    int sum = SumCountFromMToN(numN, numM);
    Console.WriteLine(sum);
}

int SumCountFromMToN(int n, int m)
{
    if (n < m) return 0;
    int sum = SumCountFromMToN(n - 1, m);
    return sum += n;
}