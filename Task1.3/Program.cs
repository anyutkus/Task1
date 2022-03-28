/*При старте приложение запрашивает у пользователя количество элементов в числовом массиве (минимум – два), а затем в цикле – сами элементы (типа int). 
 * После ввода элементов приложение распечатывает исходный массив и выводит сумму элементов массива, 
 * расположенных между наименьшим элементом массива (самым левым, если их несколько) и наибольшим элементом (самым правым, если их несколько). 
 * Разработать консольное приложение, реализующее указанный функционал.
 * Пример: массив [1,  3,  5,  1,  0,  3,  0,  1]. Сумма нужных элементов = 5 + 1 + 0 = 6.
 * Примечание 1: корректность длины массива можно не контролировать.
 * Примечание 2: наименьший и наибольший элементы включаются в сумму.
 */

using System;

Console.Write("Input number of elements: ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

int min, max, minPosition, maxPosition;

for (int i = 0; i < n; i++)
{
    Console.Write($"Input element {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

min = max = numbers[0];
minPosition = maxPosition = 0;

for (int i = 0; i < n; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
        minPosition = i;
    }
    if (numbers[i] >= max)
    {
        max = numbers[i];
        maxPosition = i;
    }
}

calculate(minPosition, maxPosition);

void calculate(int a, int b)
{
    int sum = 0;
    if (a > b)
    {
        a += b;
        b = a - b;
        a -= b;
    }
    while (a <= b)
    {
        sum += numbers[a];
        a++;
    }
    Console.WriteLine($"Sum = {sum}");
}
