/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();

byte size1 = (byte)new Random().Next(3, 5);
byte size2 = (byte)new Random().Next(3, 5);
byte size3 = (byte)new Random().Next(3, 5);

int[] array1D = GetRandom1DArrayWithNonRepeatingElements(size1, size2, size3);
int[,,] array3D = Get3DArrayFrom1DArray(array1D, size1, size2, size3);
Print3DArray(array3D);

int[,,] array3DAlternative = Get3DArray(size1, size2, size3);
Print3DArray(array3DAlternative);

int[] GetRandom1DArrayWithNonRepeatingElements(byte dimension1, byte dimension2, byte dimension3)
{
  byte size = Convert.ToByte(dimension1 * dimension2 * dimension3);
  int[] arr = new int[size];
  for(byte i = 0; i < size; i++)
  {
    int num = new Random().Next(10, 200);
    if(arr.Contains(num)) i--;
    else arr[i] = num;
  }
  System.Console.Write(String.Join("|", arr));
  return arr;
}
int[,,] Get3DArrayFrom1DArray(int[] arr1D, byte dimension1, byte dimension2, byte dimension3)
{
  int[,,] arr3D = new int[dimension1, dimension2, dimension3];
  byte index = 0;
  for(byte i = 0; i < dimension1; i++)
    for(byte j = 0; j < dimension2; j++)
      for(byte k = 0; k < dimension3; k++)
        {
          arr3D[i, j, k] = arr1D[index];
          index++;
        }
  return arr3D;
}
void Print3DArray(int[,,] array)
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
  Console.WriteLine();
}

// Попытался реализовать генерацию случайных чисел с пмощью while(true), но что-то не получилось.
// Где я делаю неправильно так и не понял?

int[,,] Get3DArray(byte dimen1, byte dimen2, byte dimen3)
{
  int[,,] arr3D = new int[dimen1, dimen2, dimen3];

  for(byte i = 0; i < dimen1; i++)
    for(byte j = 0; j < dimen2; j++)
      for(byte k = 0; k < dimen3; k++) 
      { 
        while(true)
        {
          int num = new Random().Next(10, 200);
          for(byte a = 0; a < dimen1; a++)
            for(byte b = 0; b < dimen2; b++)
              for(byte c = 0; c < dimen3; c++) 
                if(arr3D[a, b, c] != num) arr3D[i, j, k] = num;
          break;
        }
          
      } 
  return arr3D;
}


