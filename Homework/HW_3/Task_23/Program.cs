// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27

Console.Clear();

int userNum;

while(true)
{
  Console.WriteLine("Please, enter a whole number from 1 to N: ");
  if(int.TryParse(Console.ReadLine(), out userNum) && userNum >= 1)
  break;
  Console.WriteLine("You entered not a number or not correct number");
}

int index;
int[] cube = new int[userNum + 1];

Console.Write($"{userNum} -> ");

for (index = 1; index < userNum + 1; index ++)
{
  cube [index] = index*index*index;
  Console.Write(cube[index].ToString() + ", ");
  if (index == userNum)
  {
    Console.Write(cube[index].ToString());
  }
  
} 
