Console.Clear();

byte[,] array2D = new byte[4, 4];

for(var i = 0; i < array2D.GetLength(0); i++)
  for(var j = 0; j < array2D.GetLength(1); j++)
    array2D[i, j] = (byte)new Random().Next(10, 20);

for(var i = 0; i < array2D.GetLength(0); i++)
  {
    for(var j = 0; j < array2D.GetLength(1); j++)
      System.Console.Write(array2D[i, j] + " \\ ");
    System.Console.WriteLine();
  }

var min = 0;
for(var i = 0; i < array2D.GetLength(0); i++)
  {
    for(var j = 0; j < array2D.GetLength(1) - 1 ; j++)
      if(array2D[i, j] < array2D[i, j + 1] && array2D[i, j] < min) min = array2D[i, j];
      else if(array2D[i, j] < array2D[i, j + 1] && i == 0) min = array2D[i, j];
  }

System.Console.WriteLine(min);