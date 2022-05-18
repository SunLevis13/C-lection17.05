// отсортировать массив
int[] arr = { 1, 5, 3, 4, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // ставим задачу прописать массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // ставим задачу упорядочить массив
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) //ищем 
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j; //минимальную позицию
            }
        }


        int tmp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tmp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);