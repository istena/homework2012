//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int rec(int m,int n)
{
    if (m==0) return n+1;
    if ((m>0)&&(n==0)) return rec(m-1,1);
    return rec(m-1,rec(m,n-1));
}


Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m,n));
