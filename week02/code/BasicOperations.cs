using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

public class Stack
{
    private List<int> _items = new List<int>();

    public void Push(int item)
    {
        _items.Add(item);
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        int item = _items[_items.Count - 1];
        _items.RemoveAt(_items.Count - 1);
        return item;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        return _items[_items.Count - 1]; 
    }

    public bool IsEmpty()
    {
        return _items.Count <= 0; 
    }
}