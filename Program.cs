/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}

int FuncAker(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return FuncAker(n - 1, 1);
        }
        else
        {
            return FuncAker(n - 1, FuncAker(n, m - 1));
        }
    }
}

int x = GetDataFromUser("Введите число N");
int y = GetDataFromUser("Введите число M");
int res = FuncAker(x, y);
Console.WriteLine($"A({x},{y}) = {res}");