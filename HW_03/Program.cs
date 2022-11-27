// Написать программу вычисления функции Аккермана

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int AckermanFunc(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    if (numM > 0 && numN == 0)
        return AckermanFunc(numM - 1, 1);
    else
        return AckermanFunc(numM - 1, AckermanFunc(numM, numN - 1));
}
Console.WriteLine($"A({numM}, {numN}) = {AckermanFunc(numM, numN)}");
