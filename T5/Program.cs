// Запись  массива(любого размера) и вывода его элементов(любого количества) 
// с пощью гениратора псевдослучайных чисел-new Random().Next() и методов-void.

void FillArray(int[] collection) // 1 метод вычисления массива
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 300);
        index++;
    }
}

void PrintArray(int[] col) //2 метод.Печать void-метод который ничего не возвращает,return с ним не используют
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[1];

FillArray(array);
PrintArray(array);
