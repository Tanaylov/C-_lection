int[] array = {48, 55, 97, 111, 139, 45, 1, 8, 9, 139};

int n = array.Length;
int find = 139;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.Write(index);
    break;
  }
  index++;
}
