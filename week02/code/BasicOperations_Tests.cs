using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StackTests
{
    [TestMethod]
    public void TestPushAndPop()
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);

        Assert.AreEqual(2, stack.Pop());
        Assert.AreEqual(1, stack.Pop());
    }

    [TestMethod]
    public void TestPeek()
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);

        Assert.AreEqual(2, stack.Peek());
        stack.Pop();
        Assert.AreEqual(1, stack.Peek());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPopEmptyStack()
    {
        var stack = new Stack();
        stack.Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPeekEmptyStack()
    {
        var stack = new Stack();
        stack.Peek();
    }
}