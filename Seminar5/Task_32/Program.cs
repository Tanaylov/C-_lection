Console.Clear();

byte len = Convert.ToByte(new Random().Next(1, 10));
double st = new Random().NextDouble() * (-1 + 5) - 5,
       fin = new Random().NextDouble() * (15 - 3) + 3;

double [] myArray = GetRandomArray(len, st, fin);
System.Console.WriteLine(String.Join(" // ", myArray));

myArray = GetReversedArray(len, myArray);
System.Console.WriteLine(String.Join(" // ", myArray));

ArrayReverse(myArray);

double [] GetRandomArray(byte length, double start, double finish)
{
  double [] array = new double[length];
  for(byte i = 0; i < length; i++) 
  {
    array[i] = new Random().NextDouble() * (finish - start) + start;
    array[i] = Math.Round(array[i], 4);
  }
  return array;
}

double [] GetReversedArray(byte len, double [] array)
{
  for(byte i = 0; i < len; i++)
    array[i] = array[i] * -1;
  return array;
}

void ArrayReverse(double [] array1)
{
  double index = 0;
  foreach(double el in array1)
  {
    index = el / -1;
    System.Console.Write(index + " || ");
  }
}

  