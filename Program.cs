/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

// первая матрица:
int[,] ferstMatrix = GetMatrix(2,2,0,10);
//вторая матрица
int[,] seckondMatrix = GetMatrix(2,2,0,10);
/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненнвй двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{    
    int[,] matrix = new int[rows, cols];    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
//===========================================================
/// <summary>
/// Метод печатает матрицу, переданную на вход
/// </summary>
/// <param name="inputMatrix"> Входная матрица</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0);i ++)
    {
            for (int j = 0; j < inputMatrix.GetLength(1);j ++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//===========================================================

Console.WriteLine(" Первая матрица : ");
PrintMatrix(ferstMatrix);
Console.WriteLine();
Console.WriteLine(" Вторая матрица : ");
PrintMatrix(seckondMatrix);
Console.WriteLine();
Console.WriteLine(" Результирующая матрица : ");


/// <summary>
/// метод, который ,будет перемножать матрицы
/// </summary>
/// <param name="matr1">первая матрица</param>
/// <param name="matr2">вторая матрица</param>
/// <returns>готовая матрица</returns>
int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2) // метод будет воспринимать две матрицы
{
 
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = matr1[i, j] * matr2[i, j];// просто перемножаем, автоматом считает.
        }
    }    
    return matr1;
}
// Третья результируюцая
int[,] rezultMatrix = MultiplicationMatrix( ferstMatrix, seckondMatrix);
// и мы так же вызываем метод который печатает матрицу с замененными данными
PrintMatrix(rezultMatrix);

// Сама!! Легко и быстро!! не то, что те два!!