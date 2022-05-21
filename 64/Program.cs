/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int numbEnd = 1;
int result = Rekurs(n, numbEnd);
Console.WriteLine(result);

int Rekurs(int n, int numbEnd)
{  
    if (numbEnd == n) 
    {
    return numbEnd;
    }
    Console.Write(Rekurs(n, numbEnd + 1) + ", ");
    return numbEnd;
}
