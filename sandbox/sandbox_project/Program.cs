using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        var stack = new SneakyStack();

        Console.WriteLine("Test 1: Push + Pop");
        stack.Push(100);
        stack.Push(200);
        Console.WriteLine("Expected: 200, Got: " + stack.Pop()); // LIFO
        Console.WriteLine("Expected: 100, Got: " + stack.Pop());

        Console.WriteLine("-----------");

        Console.WriteLine("Test 2: Pop vacío");
        try {
            stack.Pop();
            Console.WriteLine("Oops! No lanzó excepción.");
        }
        catch (Exception ex) {
            Console.WriteLine("Exception esperada: " + ex.Message);
        }
    }
}

public class SneakyStack
{
    private List<int> _data = new();

    public void Push(int value)
    {
        _data.Add(value);
    }

    public int Pop()
    {
        if (_data.Count == 0)
            throw new InvalidOperationException("The stack is empty!");

        int lastIndex = _data.Count - 1;
        int val = _data[lastIndex];
        _data.RemoveAt(lastIndex);
        return val;
    }

    public int Peek()
    {
        if (_data.Count == 0)
            return -1;

        return _data[_data.Count - 1];
    }

    public bool IsEmpty()
    {
        return _data.Count == 0;
    }
}