Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 0) System.Console.WriteLine("Задано некорректное число");
else
{
    System.Console.WriteLine($"Список всех натуральных чисел в промежутке от {N} до 1: {PrintNumbers(N, 1)}");
}
string PrintNumbers(int start, int end)
{
    if (start == 1) return end.ToString();
    return (start + "," + PrintNumbers(start - 1, end));
}


