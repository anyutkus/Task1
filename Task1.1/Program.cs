/*
 * При старте приложение запрашивает у пользователя два целых числа a и b (считать, что пользователь вводит целые числа без ошибок). 
 * Затем приложение выводит все целые числа в диапазоне от a (включительно) до b (включительно), 
 * которые в своём троичном представлении имеют ровно две двойки. 
 * Разработать консольное приложение, реализующее указанный функционал.
 * Примечание: для преобразования строки s в значение типа int используйте метод-функцию int.Parse(s).
*/

using System;

Console.Write("Input a = ");
var a = int.Parse(Console.ReadLine());
Console.Write("Input b = ");
var b = int.Parse(Console.ReadLine());

if (a > b)
{
    a += b;
    b = a - b;
    a -= b;
}

while (a <= b)
{
    AmountOf2(a);
    a++;
}

void AmountOf2(int number)
{
    number = Math.Abs(number);
    
    var count = 0;
    while (number > 0)
    {
        if (number % 3 == 2)
        {
            count++;
        }
        number /= 3;
    }

    if (count == 2)
    {
        Console.WriteLine(a);
    }
}
