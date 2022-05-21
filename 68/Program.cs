
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
Console.WriteLine("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = RekursA(n,m);
Console.WriteLine(result);


int RekursA(int n, int m)
{
    if (n==0)
        return m+1;
    else
        if ((n!=0) && (m==0))
            return RekursA(n-1,1);
        else
            return RekursA(n-1,RekursA(n,m-1));
}