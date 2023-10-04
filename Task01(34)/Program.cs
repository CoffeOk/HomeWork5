/* Ввод: массив заполненный случайными положительными трёхзначными числами
Вывод: количество чётных чисел в массиве */

int[] RandomAray (int min, int max, int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next (min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {        
        if (i < array.Length)
            Console.Write ($"{array[i]}, ");
        else
            Console.Write ($"{array[i]}");
    }
}

int ChetNums (int[] array)
{
    int chet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        chet ++;
    }
    return chet;
}

int[] arr = RandomAray (100, 999 , 11);
Console.Write ("-> [");
PrintArray (arr);
Console.Write ("] -> ");
int cn = ChetNums(arr);
Console.Write (cn);