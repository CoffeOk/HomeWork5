/* Ввод: массив вещественных чисел
Вывод: разница между max & min элементами массива */

double[] RandomArr (int min, int max, int length)
{
    double[] arr = new double[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.NextDouble () * (max - min) + min;
    }
    return arr;
}

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {        
        //double nRound = Math.Round (array[i], 1);
        if (i < arr.Length - 1)
            //Console.Write ($"{nRound}, ");
            Console.Write ($"{arr[i]:F1}; ");
        else
            //Console.Write ($"{nRound}")
            Console.Write ($"{arr[i]:F1}");
    }
}

double MinNumArr (double[] arr)
{   
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        
        if (arr[i] < min)
            min = arr[i];
        
    }
    return min;
}

double MaxNumArr (double[] arr)
{   
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        
        if (arr[i] > max)
            max = arr[i];
        
    }
    return max;
}

double[] arr = RandomArr (1, 5 , 7);
Console.Write ("[");
PrintArray (arr);
Console.Write ("] => ");

double minuend = MaxNumArr (arr);
double subtrahend = MinNumArr (arr);
double difference = minuend - subtrahend;
if (subtrahend < 0)
Console.Write ($"{minuend:F1} - ({subtrahend:F1}) = {difference:F1}");
else
Console.Write ($"{minuend:F1} - {subtrahend:F1} = {difference:F1}");