//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = 10;
int n = 15;

int numbers(int a, int num)
{
    return (a == num && a != 0 && a > 0) ? num : 
           (a < num && a > 0 && num > 0) ? a + numbers(a+1,num) :
           ((a < 0) | (a < num && a == 0 && num > 0)) ? numbers(1,num): 
           0;
}



Console.WriteLine(numbers(m,n));