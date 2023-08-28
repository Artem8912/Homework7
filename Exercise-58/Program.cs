int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                
                Console.Write($"{arr[i,j],2} ");
                
        }
        Console.WriteLine();
    }
  
} 

int[,] MultiplyMatrixes(int[,] arr1, int[,] arr2)
{
   int[,] multiply = new int [arr2.GetLength(0),arr2.GetLength(1)];
   int sum =0;
   if (arr1.GetLength(1) != arr2.GetLength(0))
   {
    Console.WriteLine("Данные матрицы невозможно умножить");
   }
    else 
    {
           
           
           for (int i= 0; i < arr1.GetLength(0); i++)
           {
                
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        sum+= arr1[i,k]*arr2[k,j];
                    }
                
                Console.Write($"{sum,4}");
                sum=0;
           } 
           Console.WriteLine();
           
           }
    }
    return multiply;
}

Console.WriteLine(" Введите число строк первой матрицы: ");
int NumOfRows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число столбцов первой матрицы: ");
int NumOfColumns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число строк второй матрицы: ");
int NumOfRows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число столбцов второй матрицы: ");
int NumOfColumns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrixRndInt(NumOfRows1,NumOfColumns1,1,7);
int[,] matrix2 = CreateMatrixRndInt(NumOfRows2,NumOfColumns2,1,7);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
MultiplyMatrixes(matrix1,matrix2);

