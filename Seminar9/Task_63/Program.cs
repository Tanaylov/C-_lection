Console.Clear();

byte numN = (byte) new Random().Next(1, byte.MaxValue + 100);
string interval = PrintIntervalFrom1toN(numN, numN);
System.Console.WriteLine(interval);

string PrintIntervalFrom1toN(byte num, byte num1)
{
  if(num > 1) return $"{num1 - num + 1}, {PrintIntervalFrom1toN(Convert.ToByte(num - 1), num1)}";
  else return $"{num1}";
}
