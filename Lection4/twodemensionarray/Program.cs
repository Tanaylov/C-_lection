// int [,] matrix = {{1, 2}, 
//                   {3, 4}, 
//                   {5, 6}, 
//                   {7, 5}};  matrix[4, 2];


string [,] table = new string [2,5];
table[1, 2] = "word ";

for(byte str = 0; str < 2; str++)
{
  for(byte c = 0; c < 5; c++)
  {
    if(table[str, c] != table[1, 2])
      table[str, c] = "  +  ";
    System.Console.Write($"{table[str, c]}");
  }
  System.Console.WriteLine();
}  

//int[,] matrix = new int[4, 3];

int[,] mat = Get2DArray();
Print2DArray(mat);

int [,] Get2DArray()
{
  byte row = Convert.ToByte(new Random().Next(1, 5));
  byte col = Convert.ToByte(new Random().Next(1, 5));
  int[,] matrix = new int[row, col];
  for(byte i = 0; i < row; i++)
    for(byte j = 0; j < col; j++) 
      matrix[i, j] = new Random().Next(1, 10);
  return matrix;
}

void Print2DArray(int[,] matrix)
{
  for(byte row = 0; row < matrix.GetLength(0); row++)
  {
    for(byte col = 0; col < matrix.GetLength(1); col++)
        System.Console.Write(matrix[row, col] + "  ");
    System.Console.WriteLine();
  }
}
