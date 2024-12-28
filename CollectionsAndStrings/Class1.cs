using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;

namespace CollectionsAndStrings;

public class Class1
{
    
    private static string DecodeMessage(string[] lines)
    {
        var result = new List<string>();
        foreach (var item in lines)
        {
            var splitString = item.Split();
            foreach (var j in splitString)
            {
                if(!String.IsNullOrEmpty(j))
                    if(Char.IsUpper(j[0]))
                        result.Add(j);
            }
        }
        result.Reverse();
        return String.Join(" ", result);
    }
    
    // Sа : { Sasha:sasha1995@sasha.ru, Sanya:alex99@mail.ru, Sasha:shurik2020@google.com }
    
    public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var pair in contacts)
        {
            var splitElems = pair.Split(':');
            var twoFirstSymbols = pair.Substring(0, 2).Replace(":", "");
            if (dictionary.ContainsKey(twoFirstSymbols))
            {
                dictionary[twoFirstSymbols].Add(pair);
            }
            else
            {
                var temp = new List<string> { pair };
                dictionary.Add(twoFirstSymbols, temp);
            }
        }
        return dictionary;
    }
    
    /*
     * Вчера Вася узнал про удивительный закон Бенфорда и хочет проверить его действие. Для этого он взял текст с актуальными данными по самым высоким зданиям в мире и хочет получить статистику: сколько раз каждая цифра стоит на месте старшего разряда в числах из его текста.
       
       Метод GetBenfordStatistics должен вернуть массив чисел, в котором на i-ой позиции находится статистика для цифры i.
     */
    
    public static int[] GetBenfordStatistics(string text)
    {
        var statistics = new int[10];
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsDigit(text[i]) && (i == 0 || !Char.IsDigit(text[i-1])))
                statistics[text[i] - '0']++;
        }
        return statistics;
    }
    
    public static string ReplaceIncorrectSeparators(string text)
    {
        string[] arrayToSplit = text.Split(new char[] { ' ', ':', ';', '-',',' }, StringSplitOptions.RemoveEmptyEntries);
        return String.Join('\t', arrayToSplit);
    }
    
    public static string ApplyCommands(string[] commands)
    {
        var builder = new StringBuilder();
        
        foreach (var str in commands)
        {
            int firstSpaceIndex = str.IndexOf(' ');
            if (str.StartsWith("push"))
            {
                builder.Append(str.Substring(firstSpaceIndex+1));
            }
            else if(str.StartsWith("pop"))
            {
                int removedSymbols = Convert.ToInt32(str.Substring(firstSpaceIndex+1));
                builder.Remove(builder.Length - removedSymbols, removedSymbols);
            }
        }
        return builder.ToString();
    }
}