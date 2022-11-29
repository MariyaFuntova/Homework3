Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] GetCubeTable(int N)
{
    int[] cub = new int[N + 1];
    for (int i = 1; i < cub.Length; i++)
    {
        cub[i] = i * i * i;
    }
    return cub;
}
void PrintCubs(int [] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{i} ^ 3 = ");
        Console.WriteLine(array[i]);
    }
}
int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);