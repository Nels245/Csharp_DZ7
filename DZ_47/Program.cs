// Task 47. Create array with size MxN with random double numbers

Console.Clear();

Console.Write("Введите количество строк ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(m,n);
PrintArray(array);

//----------------------------Logic----------------------------

double[,] GetArray(int m, int n)
{
    double[,] array = new double[m,n];

    Random random = new Random(); ///Вот такую конструкцию я узнал из исправленной домашки, но смысл её не совсем понятен)
                                  ///Как я понял это своеобразный костыль? с int всё проще, в одну строчку)

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(random.NextDouble() * 10, 1);  /// Округлил до 1 знака после запятой для красоты
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
