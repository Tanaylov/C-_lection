Console.Clear();

int randomNumber = new Random().Next(10, 100);
int digit1 = randomNumber / 10;
int digit2 = randomNumber % 10;
int max = digit1;

if (digit2 > max)
{
  max = digit2;
} 

Console.Write($"{randomNumber} -> {max}");
