using Enums;
using Class1 = CollectionsAndStrings.Class1;

namespace ulearn;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Class1.GetOrderDescription(2));
        //Console.WriteLine(Class1.AccessRight.Guest.HasFlag(Class1.AccessRight.Delete));
        //Console.WriteLine(Arrays.ContainsAtIndex(new int[] { 1, 2, 3, 4, 5, 6 }, new[] { 3, 4, 5, 6 }, 2));
        //Matrix.Launch();
        //Matrix.SortLines(false);
        //Matrix.Print();
        var contacts = new List<string>
        {
            ":dimka212@gmail.com",
            "Sasha:sasha1995@sasha.ru",
            "Alex:alex99@mail.ru",
            "Shurik:shurik2020@google.com",
            "Sonia:sonia@example.com",
            "Vanya:vanya123@mail.ru",
            "Masha:masha1990@gmail.com",
            "Sasha:sasha2000@gmail.com",
            "Alex:alex2000@mail.ru",
            "Sonia:sonia2021@yahoo.com",
            "Dima:dima@example.com",
            
        };
        foreach (var pair in Class1.OptimizeContacts(contacts))
        {
            Console.WriteLine(pair.Key);
            foreach (var item in pair.Value)
            {
                Console.WriteLine(item);
            }
        }

    }
    
}