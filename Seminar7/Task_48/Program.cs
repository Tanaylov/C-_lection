Console.Clear();

byte[,] arr2D = Fill2DArray();
Print2DArray(arr2D);

byte[,] Fill2DArray()
{
  byte row = (byte)new Random().Next(3, 7);
  byte column = (byte)new Random().Next(3, 7);
  byte[,] arr2d = new byte[row, column];
  for(byte i = 0; i < row; i++)
    for(byte j = 0; j < column; j++)
      arr2d[i, j] = Convert.ToByte(i + j); // Почему приходится приводить к byte, когда и так всё этого типа?
  return arr2d;
}

void Print2DArray(byte[,] arr2D)
{
  byte[] arr = new byte[arr2D.GetLength(1)];
  for(byte i = 0; i < arr2D.GetLength(0); i++)
  {
    for(byte j = 0; j < arr2D.GetLength(1); j++) arr[j] = arr2D[i, j];
    System.Console.Write("{ " + String.Join(" | ", arr) + " }");
    System.Console.WriteLine();
  }
}