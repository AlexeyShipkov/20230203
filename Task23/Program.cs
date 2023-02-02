/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void  ThreeDegLine(int n)
{
    int i = 1;
    Console.Write ($"{n} -> "); //задаем начало вывода в необходимом формате
    while (i < n)
    {
        Console.Write($"{Math.Pow(i, 3)}, "); // вывод ряда кубов заданного числа
        i++;
    }
    Console.Write($"{Math.Pow(n, 3)}\n"); // последний элемент вывода
}
Console.WriteLine("input N");
int nn = Convert.ToInt32(Console.ReadLine());
ThreeDegLine(nn);