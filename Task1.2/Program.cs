﻿/* 10-значный ISBN – это цифровой код, уникально идентифицирующий книгу. Он имеет следующий вид: . Цифра  – контрольная. 
 * Она вычисляется согласно условию, что выражение
 *(сумма произведений элементов кода на вес их позиций) должно быть кратно 11.
 * Создайте программу, которая запрашивает у пользователя строку из 9 символов-цифр (это первые девять цифр ISBN), 
 * вычисляет контрольную цифру и выводит итоговый ISBN. Корректность ввода пользователя не проверяйте – считайте, 
 * что пользователь не допускает ошибок при вводе.
 *Примечание 1: контрольная «цифра» может быть равна 10. В этом случае для её обозначения используется символ X.
*/
using System;

Console.Write("Input first 9 digits of ISBN: ");
var a = int.Parse(Console.ReadLine());

var result = a.ToString() + FindLastNumber(a);

Console.WriteLine(result);

string FindLastNumber(int number)
{
    var sum = 0;

    for (var i = 2; i <= 10; i++)
    {
        sum += number % 10 * i;
        number /= 10;
    }

    var num10 = 11 - (sum % 11);

    string lastNumber = num10 switch
    {
        10 => "X",
        11 => "0",
        _ => num10.ToString()
    };

    return lastNumber;
}
