/*
 * При старте приложение запрашивает у пользователя два целых числа a и b (считать, что пользователь вводит целые числа без ошибок). 
 * Затем приложение выводит все целые числа в диапазоне от a (включительно) до b (включительно), 
 * которые в своём троичном представлении имеют ровно две двойки. 
 * Разработать консольное приложение, реализующее указанный функционал.
 * Примечание: для преобразования строки s в значение типа int используйте метод-функцию int.Parse(s).
*/

using System;

Console.Write("Input a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b = ");
int b = int.Parse(Console.ReadLine());

int temp = a;
int a3 = 0;// number in ternary numeral system
int k = 1;

while (temp > 0) //conversion to ternary numeral system
{
    a3 += (temp % 3) * k;
    temp /= 3;
    k *= 10;
}

while (a <= b)
{
    temp = a3;
    amountOf2(temp);//counting the amount of 2 in a number
    a3 = addOne(a3);//adding 1 to the number in ternary numeral system
    a++;
}

void amountOf2(int number)
{
    int count = 0;
    while (number > 0)
    {
        if (number % 10 == 2)
        {
            count++;
        }
        number /= 10;
    }
    if (count == 2)
    {
        Console.WriteLine($"{a}  {a3}");
    }
}

int addOne(int number3)
{
    temp = number3;
    for (int i = 10; i <= k; i *= 10)
    {
        if ((temp % 10 == 2) && (temp / 10 == 0))
        {
            number3 = k;
            k *= 10;
            return number3;
        }
        if (temp % 10 == 2)
        {
            number3 -= 2 * i / 10;
        }
        else
        {
            number3 += i / 10;
            return number3;
        }
        temp /= 10;
    }
    return number3;
}