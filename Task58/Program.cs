//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите число строк 1-ой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-ой матрицы и строк 2-ой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-ой матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());


int[,] firstMartrix = new int[m, n];
CreateMatrix(firstMartrix);
Console.WriteLine($"Первая матрица: ");
PrintMatrix(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateMatrix(secomdMartrix);
Console.WriteLine($"Вторая матрица: ");
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц: ");
PrintMatrix(resultMatrix);


void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}