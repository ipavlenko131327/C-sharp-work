void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);    
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] collection1)
{
    int count = collection1.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection1[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position;
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 342);
Console.WriteLine(pos);
