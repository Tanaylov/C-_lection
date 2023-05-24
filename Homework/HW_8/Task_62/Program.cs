/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05  
11 16 15 06 
10 09 08 07   */
Console.Clear();

int number = new Random().Next(1, 500);
int[,] array2D = GetSpiralMatrix4X4(number);
Print2DArray(array2D);

// Будет работать только с массивами 4 на 4, как написать общий метод я так и не понял.
int[,] GetSpiralMatrix4X4(int num) 
{
  num--;
  int size1 = 4, size2 = 4;
  int[,] array2D = new int[size1, size2];
  for(int i = 0; i < size1; i++)
    for(int j = 0; j < size2; j++)
      switch(i)
      {
        case 0: array2D[i, j] = num + 1 + j; break;
        case 1: array2D[i, j] = ((size2 * 2 + size1) + num) + j;
                if(j == size2 - 1) array2D[i, j] = num + size2 + 1;
                break;
        case 2: if(j == 0) array2D[i, j] = (size2 * 2 + size1 - 1) + num;
                else if (j == size2 - 1) array2D[i, j] = num + size2 + 2;
                else array2D[i, j] = (num + size1 * size2) - j + 1; 
                break;
        case 3: array2D[i, j] = (size2 * 2 + size1 / 2) + num - j;
                break;
      }
  return array2D;  
}

void Print2DArray(int[,] arr2D)
{
  
  for(byte i = 0; i < arr2D.GetLength(0); i++)
  {
    Console.Write("|");
    for(byte j = 0; j < arr2D.GetLength(1); j++)
      {
        if(arr2D[i, j] < 10) Console.Write("00" + arr2D[i, j] + "|");
        else if(arr2D[i, j] < 100) Console.Write("0" + arr2D[i, j] + "|");
        else Console.Write(arr2D[i, j] + "|");
      }
    Console.WriteLine();
  }
}
