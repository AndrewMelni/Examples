// Задание массива
void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count=col.Length;
    int positionn=0;
    while (positionn<count)
    {
        Console.WriteLine(col[positionn]);
        positionn++;
    }
}


int[] array=new int[10];

FillArray(array);
PrintArray(array);
