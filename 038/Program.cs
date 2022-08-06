Console.WriteLine("Enter size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
for (int i = 0; i < n; i++) arr[i] = new Random().Next(-1000, 1000) + new Random().NextDouble();
double max = arr[0];
double min = arr[0]; 
for (int j = 0; j < n; j++)
{
    if (arr[j] > max ) max = arr[j];
    if (arr[j] < min ) min = arr[j];
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine();
Console.WriteLine("Max = " + max);
Console.WriteLine("Min = " + min);
Console.WriteLine();
Console.WriteLine("Difference is = "+ (max - min));