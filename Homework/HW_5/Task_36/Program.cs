/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();

byte len = 0;
int [] arrayFromUser = UserslengthArray (ref len);

int sumOdd = SumOddNumbers(arrayFromUser);

PrintTaskSolustion(arrayFromUser, sumOdd);


int [] UserslengthArray(ref byte length)
{
  while(true)
  {
    System.Console.Write("Enter a number for detect array length: ");
    if(byte.TryParse(Console.ReadLine(), out length))
      break;
    System.Console.WriteLine("Incorret number or not a number. Try again.");
  } 
  int [] array = new int[length];
  for(byte i = 0; i < length; i++) array[i] = new Random().Next(-55, 111);
  return array;
}

int SumOddNumbers(int[] array)
{
  int sum = 0;
  for(byte i = 1; i < array.Length; i += 2) sum += array[i];
  return sum;
}

void PrintTaskSolustion(int [] array, int sum)
{
  System.Console.WriteLine($"|{String.Join("; ", array)}| -->> {sum}");
}