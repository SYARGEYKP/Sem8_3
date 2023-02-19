// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array) // печатаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] ProizvArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
        return resultArray;
}
int[,] matrix1 = GenerateArray(5,3);
int[,] matrix2 = GenerateArray(3,5);
PrintArray (matrix1);
System.Console.WriteLine();
PrintArray (matrix2);
int [,] resultMatrix = ProizvArray(matrix1,matrix2);
System.Console.WriteLine();
PrintArray(resultMatrix);







