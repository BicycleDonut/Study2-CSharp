// // Имеется одномерный массив array из n элементов,
//требуется найти элемент массива,равный find.(c использованием метода)

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;//если придать значение int position = -1,то при вводе  
                     // числа  выходящего за размер массива отобразится pos = -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // добавляем оператор,чтобы показывал 
                   //первое вхождение в заданный индекс массива
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
