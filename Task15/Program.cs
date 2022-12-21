// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Нет такого дня");
}
else if (number > 5)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это будний день");
}