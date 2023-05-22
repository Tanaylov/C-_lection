/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();

sbyte[,,] array3D = Get3DArray2x2x2();

Print3DArray(array3D);

void Print3DArray(sbyte[,,] array)
{
  for(byte i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for(byte j = 0; j < array.GetLength(1); j++)
    {
      Console.WriteLine();
      for(byte k = 0; k < array.GetLength(2); k++)
        Console.Write($"{array[i, j, k]}({i}, {j}, {k}) | ");
    }
  }
}

sbyte[,,] Get3DArray2x2x2()
{
  sbyte[,,] arr3D = new sbyte[3, 3, 3];

  for(byte i = 0; i < 3; i++)
    for(byte j = 0; j < 3; j++)
      for(byte k = 0; k < 3; k++) 
      { 
        while(true)
        {
          sbyte num = (sbyte)new Random().Next(10, 100);
          for(byte a = 0; a < 3; a++)
            for(byte b = 0; b < 3; b++)
              for(byte c = 0; c < 3; c++) 
                if(num == arr3D[a, b, c]) arr3D[a, b, c] = Convert.ToSByte(num + 1);
                else arr3D[a, b, c] = num;
          break;
        } 
        arr3D[i, j, k] = arr3D[a, b, c]; 
      } 
  return arr3D;
}

