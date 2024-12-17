namespace ulearn;

public class FirstAcquaintance
{
    public static void ConvertToDouble()
    {
        string doubleNumber = "894376.243643";
        double number = double.Parse(doubleNumber); // Вася уверен, что ошибка где-то тут
        Console.WriteLine(number + 1);
    }
}