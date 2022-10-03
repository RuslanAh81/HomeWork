/*
//  Задача номер 1. Напишите программу, которая на вход принимает 2 числа и выдает,какое число больше.
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine( a + " Больше чем " + b);
}
else
{
       Console.WriteLine( b + " Больше чем " + a);
}
*/

/*
// Задача 2. Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.

Console.Write("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b>max) max = b;
if (c>max) max = c;
 Console.WriteLine(max);

*/
// Задача 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.Write("Введите число :");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)

{
    Console.WriteLine("Число четное");
}
else 
{   Console.WriteLine("Число нечетное");
}