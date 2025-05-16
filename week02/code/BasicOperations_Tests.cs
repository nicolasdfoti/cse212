using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class StackQueueTests
{
    [TestMethod]
    public void TestPushAndDequeue()
    {
        var sq = new StackQueue();
        sq.Push(10);
        sq.Push(20);
        sq.Push(30);

        Assert.AreEqual(10, sq.Dequeue());
        Assert.AreEqual(20, sq.Dequeue());
        Assert.AreEqual(30, sq.Dequeue());
    }

    [TestMethod]
    public void TestPeek()
    {
        var sq = new StackQueue();
        sq.Push(99);
        Assert.AreEqual(99, sq.Peek());
        Assert.AreEqual(99, sq.Peek());
    }

    [TestMethod]
    public void TestIsEmpty()
    {
        var sq = new StackQueue();
        Assert.IsTrue(sq.IsEmpty());
        sq.Push(1);
        Assert.IsFalse(sq.IsEmpty());
        sq.Dequeue();
        Assert.IsTrue(sq.IsEmpty());
    }

    [TestMethod]
    public void TestCount()
    {
        var sq = new StackQueue();
        Assert.AreEqual(0, sq.Count());
        sq.Push(1);
        sq.Push(2);
        Assert.AreEqual(2, sq.Count());
        sq.Dequeue();
        Assert.AreEqual(1, sq.Count());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestDequeueEmpty()
    {
        var sq = new StackQueue();
        sq.Dequeue();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPeekEmpty()
    {
        var sq = new StackQueue();
        sq.Peek();
    }
}