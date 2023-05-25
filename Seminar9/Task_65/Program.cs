Console.Clear();

byte num1 = 5, num2 = 11;
byte num11 = 11, num22 = 5;

string sequenceAB = GetNumberFromAtoB(num11, num1); 
Console.WriteLine(sequenceAB);
char[] sequence = sequenceAB.ToArray();
System.Console.WriteLine(String.Join("|", sequence));

string GetNumberFromAtoB(byte a, byte b)
{
  if(a > b)
    {
      if(b < a) return $"{a}, {GetNumberFromAtoB(Convert.ToByte(a - 1), b)}";
      else return $"{a}"; 
    }
  else
  {
    if(b > a) return $"{a}, {GetNumberFromAtoB(Convert.ToByte(a + 1), b)}";
    else return $"{a}";
  }
}