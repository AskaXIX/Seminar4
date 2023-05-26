// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size, int left_range, int right_range)
{
    int[] temp = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        temp[i] = rand.Next(left_range, right_range + 1);
    }
    return temp;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArray(8, 0, 10);

PrintArray(array);