/*
Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем
*/

Console.WriteLine("Введите первое целое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество целых чисел: ");
int numAmount = Convert.ToInt32(Console.ReadLine());

void numSumm(int numFirst, int numSecond, int numAmount)
{
    if (numAmount <= 1) 
        Console.Write($", {numFirst + numSecond}");
    else
    {
        Console.Write($", {numFirst + numSecond}");
        numSumm(numSecond, numFirst + numSecond, numAmount - 1);
    }
}

Console.Write($"{numFirst}, {numSecond}");
numSumm(numFirst, numSecond, numAmount);