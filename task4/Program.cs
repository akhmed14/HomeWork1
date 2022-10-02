//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
if (N > 0)
{
        for (int i = 2; i < N+1; i=i+2)
        {
            if (i == N+1)
            break;
        Console.Write(" "+i);  
        }
}
else 
{
    Console.Write("Число должно быть натуральным");  
}