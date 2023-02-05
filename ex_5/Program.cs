// Метод заполняет массив случайными числами
void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Метод выводит массив на консоль
void PrintArray(int[] col) {
    int count = col.Length;   // size
    int position = 0;         // index
    Console.Write("Массив: [ ");
    while (position < count) {
        Console.Write(col[position]);
        Console.Write(' ');
        position++;
    }
    Console.WriteLine("]");
}

// Метод ищет индекс числа в массиве
int IndexOf(int[] collection, int find) {
    int length = collection.Length;
    int index = 0;
    int position = -1;  // здесь будет храниться значение найденного индекса
    while (index < length) {
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}




// Основной код

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int pos = IndexOf(array, 4);

Console.Write("Индекс -> ");
Console.WriteLine(pos);

