Console.Clear();

double[] arr = new double[new Random().Next(1, 9)];

for(byte i = 0; i < arr.Length; i++)
  arr[i] = Math.Round(new Random().NextDouble() * (11 + 11) - 11, 2);
System.Console.WriteLine(String.Join("/", arr));

System.Console.WriteLine("-------------------------------------------");

double[] arrCopy = new double[arr.Length];
for(byte j = 0; j < arr.Length; j++)
  arrCopy[j] = arr[j];
System.Console.WriteLine(String.Join("/", arrCopy));
