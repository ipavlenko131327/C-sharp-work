int[] array = { 1, 3, 5, 7, 9, 3, 6, 1, 4, 2, 8, 10 };
void printarray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

    }
    Console.WriteLine();
} 

void selectionsort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minposition]) minposition = j;
        }

        int temp = array[i];
        array[i] = array[minposition];
        array[minposition] = temp;
    }
}

printarray(array);
selectionsort(array);

printarray(array);