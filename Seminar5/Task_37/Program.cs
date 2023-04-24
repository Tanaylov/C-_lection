Console.Clear();
/*
double [] array = GetArray();
System.Console.WriteLine("[" + string.Join(" / ", array) + "]");
array = ArraySumElements(array);
System.Console.WriteLine("[" + string.Join(" | ", array) + "]");

double [] GetArray()
{
  byte len;
  double finish, start;
  while(true)
  {
    System.Console.WriteLine("Set the length of the array: ");
    if(byte.TryParse(Console.ReadLine(), out len))
      break;
    System.Console.WriteLine("Wrong enter!");
  }

  while(true)
  {
    System.Console.WriteLine("Set the beginning of the array: ");
    if(double.TryParse(Console.ReadLine() ?? "".Replace('.',','), out start))
      break;
    System.Console.WriteLine("Wrong enter!");
  }

  while(true)
  {
    System.Console.WriteLine("Set the end of the array: ");
    if(double.TryParse(Console.ReadLine() ?? "".Replace('.',','), out finish))
      break;
    System.Console.WriteLine("Wrong enter!");
  }

  double [] arr = new double[len];
  for(byte i = 0; i < len; i++)
  {
    arr[i] = new Random().NextDouble() * (finish - start) + start;
    arr[i] = Math.Round(arr[i], 3);
  }
  return arr;
}

double [] ArraySumElements(double [] arrOrigine)
{
  byte size = Convert.ToByte(arrOrigine.Length);
  if(size % 2 == 0)
  {
    double [] newArray = new double[size / 2];
    for(byte i = 0; i < size; i++)
  {
      newArray[i] = arrOrigine[i] * arrOrigine[size-1];
      newArray[i] = Math.Round(newArray[i], 3);
      size--;
  }
    return newArray;
  }
  else
  {
    byte newSize = Convert.ToByte(size / 2 + 1);
    double [] newArray = new double[newSize];
    for(byte i = 0; i < size; i++)
    {
      if(newSize < size)
      {
      newArray[i] = arrOrigine[i] * arrOrigine[size-1];
      newArray[i] = Math.Round(newArray[i], 3);
      }
      else
      {
      newArray[i] = arrOrigine[newSize - 1];
      newArray[i] = Math.Round(newArray[i], 3);
      }
      size--;
    }
    return newArray;
  }
}
*/

int [] array = {1, 5, 11, 11, 23, 7, 3};
int size = array.Length;
double newSize = Convert.ToDouble(size);
newSize = Math.Ceiling(newSize / 2);
int newSize2 = Convert.ToInt32(newSize);
int [] arr = new int[newSize2];
for(int i = 0; i < size; i++)
{
  arr[i] = i < size - 1 ? array[i]*array[size - 1] : array[newSize2 - 1];
  size--;
}
System.Console.WriteLine(string.Join("//", arr));
