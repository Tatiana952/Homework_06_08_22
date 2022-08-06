Console.WriteLine("Enter size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int j = 0;
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next(100 , 1000);
    if (arr[i] % 2 == 0) j++;
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine("There are/is "+ j + " even number(s)");
