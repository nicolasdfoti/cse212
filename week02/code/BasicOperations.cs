using System;
using System.Collections.Generic;

public class StackQueue
{
    private List<int> _items = new List<int>();

    public void Push(int item)
    {
        _items.Add(item);
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("StackQueue is empty.");

        int item = _items[0];
        _items.RemoveAt(0);
        return item;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("StackQueue is empty.");

        return _items[_items.Count - 1];
    }

    public bool IsEmpty()
    {
        return _items.Count == 0; 
    }

    public int Count()
    {
        return _items.Count; 
    }
}