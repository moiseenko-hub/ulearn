namespace CollectionsAndStrings;

public class MyQueue
{
    private Stack<int> left = new Stack<int>();
    private Stack<int> right = new Stack<int>();

    public void Enqueue(int value)
    {
        if(right.Count == 0)
            left.Push(value);
        else
        {
            for (var i = 0; i < right.Count; i++)
            {
                left.Push(right.Pop());
            }
            left.Push(value);
        }
    }

    public int Dequeue()
    {
        var leftSize = left.Count;
        for (var i = 0; i < leftSize; i++)
        {
            right.Push(left.Pop());
        }
        return right.Pop();
    }
    
}