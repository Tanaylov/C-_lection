Console.Clear();


int number = int.Parse(Console.ReadLine() ?? "");

byte len = LengthDetectionForBinaryNum(number);
long binaryNum = BinaryConversion(len, number);

byte LengthDetectionForBinaryNum(int num)
{
  if(num < 2) return 1;
  byte len = 1;
  int index = 2;
  for(byte i = 2; i < 100; i++)
    {
      int ind = index * 2;
      byte len1 = Convert.ToByte(len * i);
      if(num >= index && num < ind) return len1;
      index *= 2;
    }
  if(num > index) return 0;
  else return 0;
}

long BinaryConversion(byte length, int number1)
{
  byte[] binaryNum = new byte[length];
  for(byte i = 0; i < len; i++)
  {
    if(number1 % 2 != 0)  binaryNum[len - i - 1] = 1;
    else binaryNum[len - i - 1] = 0;
    number1 /= 2;
  }  
  long finalScore = 0;
  for (byte i = 0; i < len; i++)
  {
      finalScore += binaryNum[i] * Convert.ToInt64(Math.Pow(10, len - i - 1));
  }
  return finalScore;
}

System.Console.WriteLine(number + " = " +  binaryNum);
