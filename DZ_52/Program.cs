// Task 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце

Console.Clear();

int m = 3;
int n = 4;


int[,] array = GetArray(m,n);
PrintArray(array);

PrintAverage(array); ///Метод нахождения и вывода среднего арифметического каждого столбца

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
}

void PrintAverage(int[,] array)
{
    double[] srArifm = new double[array.GetLength(1)]; // Задаем новый массив из средних арифм. столбцов

    for (int i = 0; i < array.GetLength(1); i++)               
    {   
        double summ = 0;                                       
        for (int j = 0; j < array.GetLength(0); j++)           
        {
            summ += array[j,i];
        }
        srArifm[i] = summ / array.GetLength(1);   //делим сумму элементов столбца на кол-во элементов в столбце,
                                                  //и передаём в массив состоящий из ср. арифметических srArifm[i]
    }

    //////////////////////////////Вывод/////////////////////////////////////////////

    Console.Write($"Среднее арифметическое каждого столбца: ");

    for (int i = 0; i < array.GetLength(1) - 1; i++) // Выводим в консоль ср. арифм. каждого столбца
        Console.Write($"{srArifm[i]}; ");
    Console.Write($"{srArifm[array.GetLength(1) - 1]}. "); // Красивое окончание с точкой на конце
}