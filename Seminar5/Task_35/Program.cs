// 10 - 99 cout index
Console.Clear();

int [] array = GetArray (50);
System.Console.WriteLine(string.Join("*", array));

byte count = CountIndex(array, 10, 20);
System.Console.WriteLine($"Count elements on 10 to 99 equal {count}");



int [] GetArray(int num)
{
  int [] arr = new int[num];
  for(byte i = 0; i < num; i++)
    arr[i] = new Random().Next(1, num + 1);
  return arr;
}

byte CountIndex( int [] array, int numS, int numF)
{
  byte count = 0;
  foreach(byte el in array)
    if(el >= numS && el <= numF)
      count++;
  return count;
}