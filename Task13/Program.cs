// Задача 13: Напишите программу, 
//которая выводит третью цифру (справа налево) заданного числа 
//или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 == 0)
{
    Console.Write($"У числа {number} нет третьей цифры.");
}

else 
{
    while (Math.Abs(number) >= 1000) 
    {
        number = Math.Abs(number)/10;
    }
    int result = number % 10;
    Console.Write(result);
}



