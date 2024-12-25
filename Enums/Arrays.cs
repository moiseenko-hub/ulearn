namespace Enums;

public class Arrays
{
    /*
     * Напишите метод, который создает массив длинной count элементов, содержащий последовательные четные числа в порядке возрастания.
       
       Например, GetFirstEvenNumbers(3) должен вернуть массив 2, 4, 6
     */
    public static int[] GetFirstEvenNumbers(int count)
    {
        int[] arr = new int[count];
        for (int i = 1; i <= count; i++)
        {
            arr[i-1] = i*2;
        }

        return arr;
    }
    
    /*
     * А вам выпала задача посложнее — написать метод поиска индекса максимального элемента. То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
       
       Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
       
       Если массив пуст, вывести нужно -1.
     */
    public static int MaxIndex(double[] array)
    {
        if (array.Length == 0)
            return -1;
        var maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
                maxIndex = i;
        }

        return maxIndex;
    }
    
    /*
     * Тренировки продолжаются. На этот раз вы с Васей наперегонки решаете одну задачу — найти количество вхождений заданного числа в массив чисел.
       
       Например, в массиве 1, 2, 1, 1 число 1 встречается 3 раза.
     */
    
    public static int GetElementCount(int[] items, int itemToCount)
    {
        var counter = 0;
        foreach (var item in items)
        {
            if (item == itemToCount)
                counter++;
        }

        return counter;
    }
    
    /*
     * Если подмассив найден в массиве, то вернуть нужно минимальный индекс, с которого начинается подмассив в исходном массиве. Например, поиск подмассива "3,4" в массиве "1,2,3,4,3,4" должен вернуть 2.
     */
    
    public static bool ContainsAtIndex(int[] array, int[] subArray, int targetIndex){

        foreach (var item in subArray)
        {
            if (item != array[targetIndex])
                return false;
            targetIndex++;
        }

        return true;
    }
    /* Помогите Васе написать метод, который принимает массив int[], возводит все его элементы в заданную степень и возвращает массив с результатом этой операции.
       
       Исходный массив при этом должен остаться неизменным. */
    public static int[] GetPoweredArray(int[] arr, int power)
    {
        int[] new_arr = new int[arr.Length];
        for (var i = 0; i < new_arr.Length; i++)
        {
            var temp = arr[i];
            var result = 1;
            for (var j = 1; j <= power; j++)
            {
                result = result * temp;
            }

            new_arr[i] = result;
        }
        return new_arr;
    }
    
    

    
}