// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int valueM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int valueN = int.Parse(Console.ReadLine()!);


int PeriodicSum(int FirstNum, int SecondNum)
{
    if (FirstNum == SecondNum) return SecondNum;
    else return (FirstNum+ (PeriodicSum(FirstNum + 1, SecondNum)));
}

System.Console.WriteLine($"сумма натуральных элементов в промежутке от M={valueM} до N={valueN} равняется {PeriodicSum(valueM, valueN)}");


/* метод для решения без рекурсии циклом 
int PeriodicSum(int valueM, int valueN)
{
    int sum = 0;
    {
        for (int i = valueM; i <= valueN; i++)
        {
            sum += i;
        }
        if (valueM == valueN)
        {
            sum += valueN;
        }
    }
    return sum;
} */
