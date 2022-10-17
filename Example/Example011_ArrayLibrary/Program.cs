void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
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
        Console.WriteLine(col[position]); // Будем выводить значение текущего элемента через текущ позицию
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Вводим переменную куда будем сохранять наш индекс
//  Сделали минус1 , тк если переменной нет, автоматом будет писать в ноль.нам так не надо

    while (index < count)
    {
        if(collection[index]== find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // Определили массив из 10ти элементов

FillArray(array); // Метод заполняет массив
array[4] = 4; // Принудительно добавили неск четверок для проверки работы
array[6] = 4;


PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444); // Ищем элемант 444
Console.WriteLine(pos);




// int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {
//    if(array[index] == find)
//    {
//     Console.WriteLine(index);
//     break;
//    }

//    index++;

// }
