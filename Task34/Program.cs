//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRndNumbers(array);
Console.WriteLine("В этом массиве: ");
PrintArray(array);

int count = 0;
for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0) count++;

Console.WriteLine($"Всего {array.Length} чисел, {count} из них чётные");

void FillArrayRndNumbers(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}