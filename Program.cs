//Написать метод для поиска индекса элемента массива (тип элементов в массиве - int),
//метод должен вернуть индекс первого найденного элемента (если он будет найден).
//Так же мы напишем метод для с помощью которого мы можем массив случайных чисел в C#
using System.Net.Http.Headers;
using System.Security.Cryptography;

class Program
{
    static int IndexOf(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }
    static void Main(string[] args)
    {
        int[] array = GetRandomArray(10, -20, 15);
        int result = IndexOf(array, 1000);
        Console.WriteLine(result);
    }
    static int[] GetRandomArray(uint length, int minValue, int maxValue)
    {
        int[] Array = new int[length];
        Random random = new Random();
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = random.Next(minValue, maxValue);
        }
        return Array;
    }

}