// See https://aka.ms/new-console-template for more information
Console.Clear();

int[] arr = {1, 5, 6, 7, 4, 8, 3};
System.Console.WriteLine(String.Join(" ", arr));

// зеркалит массив.
for (byte i = 0; i < arr.Length; i++)
{
  arr[arr.Length - 1 - i] = arr[i]; // относительно начала массива
  // arr[i] = arr[arr.Length - 1 - i]; // щтносительно конца массива
}
System.Console.WriteLine(String.Join(" ", arr));

// создаёт новый массив, переворачивая исходный.
int[] arr1 = {1, 5, 6, 7, 4, 8, 3};
int[] array = new int[arr1.Length];
for (byte i = 0; i < arr1.Length; i++)
  array[i] = arr1[arr1.Length - 1 - i];
System.Console.WriteLine(String.Join(" ", array));

// переписывет исходный массив, переворачивая его
for(byte i = 0; i < arr1.Length / 2; i++)
{
  int konstanta = arr1[i];
  arr1[i] = arr1[arr1.Length - 1 - i];
  arr1[arr1.Length - 1 - i] = konstanta;
}
System.Console.WriteLine(String.Join(" ", arr1));
