// Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра в трехзначном числе -> {result} ");

int SecondDigit(int num)
{
    int result = ((number / 10) % 10);
    return result;
}