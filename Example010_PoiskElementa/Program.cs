// Поиск определённого элемента массива
int[] array={1,21,13,4,5,6,4,7,8,9};

int n = array.Length;
int find=4;

int index=0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
