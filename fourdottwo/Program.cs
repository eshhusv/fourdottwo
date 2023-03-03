Random r = new Random();
int[,] arr = new int[4, 3];

for(int i = 0; i < 4; i++)
{
    for(int j = 0; j < 3; j++)
    {
        arr[i, j] = r.Next(1, 10);
        Console.Write(arr[i, j] + " ");
        int max = arr[i, 0];
        if (arr[i, j] > max) max = arr[i, j];
        if (j == 2) Console.WriteLine($"Наибольший элемент строки: {max}");
    }
}