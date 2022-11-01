// Task 50. Напишите программу которая на вход принимает позицию элемента
// и возращает его значение, или сообщает что такого элемента нет

Console.Clear();

Console.Write("Введите номер строки: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца: ");
int y = int.Parse(Console.ReadLine() ?? "");

int m = 5;
int n = 5;

int[,] array = GetArray(m,n);
PrintArray(array);
GetNumFromArray(array, x, y);

if (x > m || y > n)
{
    Console.Write("Такого элемента нет");
}
//----------------------------Logic----------------------------

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m,n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetNumFromArray(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && j == y) Console.Write($"Значение элемента [{x}, {y}] = {array[i,j]}");
        }
    }
}