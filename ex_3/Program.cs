int[] array = { 2, 89, 312, 48, 15, 961, 15 };
int n = array.Length;

int find = 15;

int index = 0;
while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}