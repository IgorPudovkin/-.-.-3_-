//Упорядочить массивы. Алшоритм сортировки (метод выбора минимального или
//максимального). 1. Найти позицию минимальног (максимального) элемента в
//неотсортированной части массива. 2. Произвести обмен этого значения со
//значением первой неотсортированной позиции. 3. Повторять пока есть
//неотсортированные элементы. Напишем кодЖ
int[] arr = {1,5,4,3,2,6,7,1,1};
void PintArray(int[] array)//метод void, в качестве аргумента будет массив
{
    int count = array.Length;//полученин, количество элементов Length
    for (int i = 0; i < count; i++)//цикл for
    {
        Console.Write($"{array[i]} ");//напишем действие array[i]
    }
    Console.WriteLine();
}
void selectionSort(int[] array)//selectionSort - метод, который будет упорядо-
//чивать наш массив. в качестве аргумента - некий массив array
{
    for (int i = 0; i < array.Length - 1; i++)//array.Length -длина массива
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;

        }
        int temporary = array[i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
    }
}
PintArray(arr);//arr - это наименование нашего метода
selectionSort(arr);
PintArray(arr);

