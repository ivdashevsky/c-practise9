//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1,1);
    else return Akk(m - 1, Akk(m,n - 1));
}

Console.WriteLine(Akk(2,3));