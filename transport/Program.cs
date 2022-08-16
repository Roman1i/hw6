int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n,n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(0,10);
        Console.Write(arr[i, j] + " ");
    }   
}

Console.WriteLine("");

for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[j, i] + " ");
    }
}