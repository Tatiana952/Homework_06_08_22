Console.WriteLine("Enter size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next(-1000, 1000);
    if (i % 2 != 0) sum = sum + arr[i];
}

Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine("Sum is = "+ sum);