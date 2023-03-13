System.Console.WriteLine($"Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0) System.Console.WriteLine("Введите положительные яисла");
else 
System.Console.WriteLine($"Функция Аккермана для m = {m} и n = {n} равна: {GetAck(m,n)}");

int GetAck(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return GetAck(m - 1, 1);
    else return GetAck(m - 1, GetAck(m, n - 1));
}
