// Напишите программу которая проверяет наличие числа в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void CheckNumArray(int[] arr, int num)
{
    bool check = false;
    num = Math.Abs(num);
    foreach(int el in arr)
    {
        if (el == num)
        {
            Console.WriteLine($"Число {num} есть в массиве {String.Join(" ",arr)} ");
            check = true;
            break;
        }
    }
        if (check == false)
        {
            Console.WriteLine($"Числа {num} нет в массиве {String.Join(" ",arr)} ");
        }
}

int[] array = GetArray(7, -10, 10);
Console.WriteLine();
CheckNumArray(array, 4);