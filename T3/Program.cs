// Найти максимму из 9 чисел (с помощью массива)
int Max(int arg1, int arg2, int arg3) //Ввод функции
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//           0  1  2  3  4  5  6  7  8 - номера элементов массива
int[] array = { 11, 21, 31, 41, 15, 161, 17, 18, 19 };

//array[0]=12;                    // обратится к массиву и записать значение элемента(индекс)
//Console.WriteLine(array[0]);    // обратится к массиву и получить значение элемента(индекса)

int result = Max(
    Max(array[0], array[1], array[2]),  // Решение с помощью введенной функции
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);

