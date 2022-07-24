// Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// A(n, m) = m + 1, если n = 0,
// = A(n - 1, 1), если n <> 0, m = 0,
// = A(n - 1, A(n, m - 1)), если n> 0, m > 0.

Console.WriteLine("Введите число M: ");
int valueN = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int valueM = int.Parse(Console.ReadLine()!);

int Ackermann(int valueM,int valueN)
{
    if (valueM == 0)
    {
        return valueN+1;
    }
    if (valueN == 0 && valueM > 0)
    {
        return Ackermann(valueM - 1, 1);
    }
    if (valueN > 0 && valueM > 0)
    {
        return Ackermann((valueM - 1), Ackermann(valueM, (valueN - 1)));
    }
    else return 0;
}

int result = Ackermann(valueN, valueM);
System.Console.WriteLine(result);