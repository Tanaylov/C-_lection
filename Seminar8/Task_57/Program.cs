Console.Clear();

byte[,] array2D = new byte[4, 4];

for(var i = 0; i < array2D.GetLength(0); i++)
  for(var j = 0; j < array2D.GetLength(1); j++)
    array2D[i, j] = (byte)new Random().Next(10, 20);

for(var i = 0; i < array2D.GetLength(0); i++)
  {
    for(var j = 0; j < array2D.GetLength(1); j++)
      System.Console.Write(array2D[i, j] + " \\ ");
    System.Console.WriteLine();
  }  
string[] match = new string[array2D.GetLength(0) * array2D.GetLength(1)];
byte b = 0;
for(var i = 0; i < array2D.GetLength(0); i++)
  for(var j = 0; j < array2D.GetLength(1); j++)
    {
      byte a = 0;
      for(var k = 0; k < array2D.GetLength(0); k++)
        for(var n = 0; n < array2D.GetLength(1); n++)
          if(array2D[k, n] == array2D[i, j]) a++; 
      match[b] = array2D[i, j] + " exist " + a + " count";
      b++;
    }

System.Console.WriteLine(String.Join("||", match));

//int[] s = { 1, 2, 3, 3, 4};
string[] q = match.Distinct().ToArray();

System.Console.WriteLine(String.Join("||", q));


for(byte i = 0; i < match.Length; i++)
  {
    byte count = 0;
    for(byte j = 0; j < match.Length; j++) 
      {
        if(match[i] == match[j]) count++;
        if(count > 1 && i >= j) break;
        else if(count > 1)
        {
          System.Console.WriteLine(match[i]);
          break;
        }
      }
    if(count == 1) System.Console.WriteLine(match[i]);
  }
  
    