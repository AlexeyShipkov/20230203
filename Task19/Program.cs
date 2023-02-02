/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void Pldr (int n)
{
    if (n/10000 == n%10 && n/1000%10 == n/10%10) // проверка совпадений первой-пятой и второй-четвертой цифры в числе
    Console.WriteLine("yes");
        else
        Console.WriteLine("no");
}
Console.WriteLine("Input 5digits number");       // ввод пользователя
int nn = Convert.ToInt32(Console.ReadLine());
if (nn < 10000 || nn > 99999)                    // проверка на пятизначность
    Console.WriteLine("Not a 5digits number");
else
    Pldr(nn);
