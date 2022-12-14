// Имеется одномерный массив array из n элементов,
//требуется найти элемент массива,равный find.

//           Алгоритм
//1. Установить счетчик index в позицию 0
//2. Если array[index]=find,алгоритм завершил работу успешно.
//3. Увеличить index на 1.
//4. Если index<n, то перейти к шагу 2. В противном случае
//   алгоритм завершил работу безуспешно. 

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length; // возвращает длину иди количество элементов массива
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find) // Знак == показывает равенство правой и левой части выражения(условия)
    {
        Console.WriteLine(index);
        break; // оператор прерывания,чтобы не показывать элементы одинакового значения
    }

    index++;
    //index=index+1;
}