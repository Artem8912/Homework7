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

int [,] SortArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j; k < arr.GetLength(1)-1; k++)
            {
               if ( arr[i,j] < arr[i,k+1])
            {
                int box = arr[i,k+1];
                arr[i,k+1] = arr[i,j];
                arr[i,j] = box;
            } 
            
            }
            
        }
    } 
    return arr;
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

int [,] result = CreateMatrixRndInt(5,4,1,10);
PrintArray( result);
Console.WriteLine();
SortArray(result);
PrintArray( result);

