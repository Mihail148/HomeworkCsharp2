// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int dlina = number.Length;

if (dlina == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} это число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} это число неявляется палиндромом");
    }
}
else
{
    Console.WriteLine($"Наше число {number} не пятизначное ");
}