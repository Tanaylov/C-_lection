Console.Clear();

float[,] array2D_1 = Fill2DArray();
Print2DArray(array2D_1);

System.Console.WriteLine("/////////////////////////////////");

// array2D_1 = Modify2DArray(array2D_1);
// Print2DArray(array2D_1);

System.Console.WriteLine("/////////////////////////////////");

float[,] array2D_2 = Modify2DArray(array2D_1);
Print2DArray(array2D_2);


void Print2DArray(float[,] arr2D)
{
  float[] arr = new float[arr2D.GetLength(1)];
  for(byte i = 0; i < arr2D.GetLength(0); i++)
  {
    for(byte j = 0; j < arr2D.GetLength(1); j++) arr[j] = arr2D[i, j];
    System.Console.Write("{ " + String.Join(" | ", arr) + " }");
    System.Console.WriteLine();
  }
}

float[,] Modify2DArray(float[,] arr2D)
{
  for(byte i = 1; i < arr2D.GetLength(0); i++)
    for(byte j = 1; j < arr2D.GetLength(1); j++)
    {
      if(i % 2 == 1 && j % 2 == 1) arr2D[i, j] = arr2D[i, j] * arr2D[i, j];
    }
  return arr2D;  
}

float[,] Fill2DArray()
{
  byte row = (byte)new Random().Next(3, 5);
  byte column = (byte)new Random().Next(3, 5);
  float[,] arr2d = new float[row, column];
  for(byte i = 0; i < row; i++)
    for(byte j = 0; j < column; j++)
      arr2d[i, j] = (float)Math.Round((float)new Random().NextDouble() * (7 + 7) - 7, 1);
  return arr2d;
}