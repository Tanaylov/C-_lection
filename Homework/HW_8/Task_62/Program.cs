/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();
int size1 = 4, size2 = 4;
int[,] array2D = new int[size1, size2];
int k = 0;
for(int i = 0; i < size1; i++)
  for(int j = 0; j < size2; j++)
  {
    if(i == 0)
    {
      array2D[i, j] = k;
      k++;
    }
    else if (i == 1)
    {
      k = size2 * 3;
      array2D[i, j] = k;
      k++;
      if(j == size2 - 1) array2D[i, j] = size1 + 1;
    }
    else if (i == 2)
    {      
      if(j == 0)
      {
        k = size2 * 3 - 1;
        array2D[i, j] = k;
      }
      else if(j > 1 && j < size2 - 1)
      {
        k = size1 + 1;
        array2D[i, j] = k;
        k--;
      }
      else array2D[i, j] = size1 + 2;
    }
    
    if(i == 3)
    { 
      k = size1 * 3 - 2;
      array2D[i, j] = k;
      k--;
    }
  }

Print2DArray(array2D);

void Print2DArray(int[,] arr2D)
{
  for(byte i = 0; i < arr2D.GetLength(0); i++)
  {
    for(byte j = 0; j < arr2D.GetLength(1); j++)
      Console.Write(arr2D[i, j] + " | ");
    Console.WriteLine();
  }
}