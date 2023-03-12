Console.WriteLine("Введите начальное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите конечное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M>N)
{
    int temp = N;
    N=M;
    M=temp;
}

int GetSum(int start, int end)
{
    //if (start == 0) return end
    if (start == end) return end;
    else start += GetSum(start - 1, end);
    return start;
}
System.Console.WriteLine($"Сумма чисел, лежащих в промежутке от {M} до {N} равна {GetSum(N, M)}");
