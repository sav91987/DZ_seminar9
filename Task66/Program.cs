Console.WriteLine("Введите начальное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите конечное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0) System.Console.WriteLine("Введите положительные яисла");
else
{
    if (M > N)
    {
        int temp = N;
        N = M;
        M = temp;
    }
    System.Console.WriteLine($"Сумма чисел, лежащих в промежутке от {M} до {N} равна {GetSum(N, M)}");
}

int GetSum(int start, int end)
{
    if (start == end) return end;
    else start += GetSum(start - 1, end);
    return start;
}

