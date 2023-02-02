/*
Напишите программу, которая принимает на вход ЛЮБОЕ число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void PlndrAnyNumber(int number) // 
{
int digits = 0; // кол-во цифр в числе
int i = 1; 
int number1 = number;
int d1 = 0; // цифры в числе от начала
int d2 = 0;  // цифры в числе от конца
int check = 0; // флаг проверки, для вывода да/нет
while (number > 0)  // вычисление длины числа
{
  digits++;
  number = number/10;
}
while (i < digits/2+1)  // сравнение цифр числа в цикле от начала и от конца, проходим до середины числа с каждой стороны
{
  d1 = number1/Convert.ToInt32(Math.Pow(10,digits-i))%10;
  d2 = number1/Convert.ToInt32(Math.Pow(10,i-1))%10;
if (d1 != d2) // проверка на палиндромность не пройдена, пишем НЕТ и выход, флаг меняет значение
{
Console.WriteLine("no");
check = 1;
break;
}
  i++;
}
if (check == 0) Console.WriteLine("yes");   // флаг значнеие не поменял, проверка на палиндромность пройдена, пишем ДА
}

Console.WriteLine("input number: "); //ввод пользователя
int user_number = Convert.ToInt32(Console.ReadLine());
PlndrAnyNumber(user_number);