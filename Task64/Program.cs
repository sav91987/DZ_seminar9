Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == 1) return end.ToString();
    return (start + "," + PrintNumbers(start - 1, end));
}
System.Console.WriteLine(PrintNumbers(N, 1));
