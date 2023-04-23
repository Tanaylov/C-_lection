Console.Clear();

byte len = Convert.ToByte(new Random().Next(1, 10));
double st = new Random().NextDouble() * (-1 + 5) - 5,
       fin = new Random().NextDouble() * (15 - 3) + 3;

double [] myArray = GetRandomArray(len, st, fin);

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
void ArrayReverse(double [] array1)
{
  for(byte j = 0; j < array1.Length; j++)
  {
    array1[j] = array1[j] / -1;
    System.Console.WriteLine(array1[j] + "||");
  }
}

/*
if(array1[i] > 0) array1[i] *= -1; 
    else array1[i] = Math.Abs(array1[i]);
*/    