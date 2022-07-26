//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string numbers(int m, int n)
{
    return (m == n && m != 0 && m > 0) ? n.ToString() : 
           (m < 0) ? numbers(1,n) :
           (m < n && m > 0 && n > 0) ? m.ToString() + " " + numbers(m+=1,n) :
           ((m < 0) | (m < n && m == 0 && n > 0)) ? numbers(1,n) : 
           "No numbers";
}

Console.Write(numbers(10,0));