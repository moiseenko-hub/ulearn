using System.Runtime.InteropServices.JavaScript;

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
}