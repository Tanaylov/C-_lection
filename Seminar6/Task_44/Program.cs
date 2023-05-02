Console.Clear();

byte number = GetNumberForFibonacciSequence();
short[] numberFibonacci = GetFibonacciNumber(number);
System.Console.WriteLine(number + " ==> " + String.Join(", ", numberFibonacci));

byte GetNumberForFibonacciSequence()
{
  byte num;
  while(true)
  {
    System.Console.WriteLine("Enter a number: ");
    if(byte.TryParse(Console.ReadLine() ?? "", out num) && num > 0)
      break;
    System.Console.WriteLine("You enter uncorrect number, try again, please");
  }
  return num;
}


short[] GetFibonacciNumber(byte num)
{
  short[] array = new short[num];
  array[0] = 0;
  if(num == 1) return array;
  array[1] = 1;
  if(num == 2) return array;
  else
  {
    for(byte i = 2; i < number; i++)
      array[i] = (short)(array[i - 1] + array[i - 2]);
    return array;
  }
}