/* Ввод: одномерный массив из случайных чисел
Вывод: сумма элементов стоящих на нечётных позициях */

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

int SumNumsNeChetPos (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
    }
    return sum;
}

int[] arr = RandomAray (-10, 10 , 11);
Console.Write ("-> [");
PrintArray (arr);
Console.Write ("] -> ");
int sumNums = SumNumsNeChetPos(arr);
Console.Write (sumNums);