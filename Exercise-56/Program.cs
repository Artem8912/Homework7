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

int[] SumOfElementsInRow(int[,] arr)
{
    int sum =0;
    int[] array = new int[arr.GetLength(0)]; 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+= arr[i,j];

        }
        array[i] = sum;
        Console.WriteLine ($"Сумма элементов в строке №{i+1}: {sum} ");
        sum = 0;
    }
    return array;
}

void RowNumberWithMinElement (int[] arr)
{
    int indexmin = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
        
            if (arr[i]<arr[i+1] )
            {
               indexmin = i;
               int box = arr[i+1];
               arr[i+1] = arr[i];
               arr[i] = box;

            }
            else 
            {
                indexmin = i+1;

            }
            
        }
        Console.WriteLine($"Номер строки с минимальной суммой элементов равен: {indexmin+1} ");
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
int[] resultsum = SumOfElementsInRow(result);
RowNumberWithMinElement(resultsum);
