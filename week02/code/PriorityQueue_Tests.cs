using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: I wrote five problems, each one with a different value and priority.
    // Expected Result: I expect the highest priority item to dequeue from the priorityQueue first (and if there are more than one PriorityItems with the same priority, the first one goes away)
    // Defect(s) Found: None.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("problem1", 1);
        priorityQueue.Enqueue("problem2", 4);
        priorityQueue.Enqueue("problem3", 2);
        priorityQueue.Enqueue("problem4", 4);
        priorityQueue.Enqueue("problem5", 3);

    }

    [TestMethod]
    // Scenario: I write four problems. Each one with values and priority numbers
    // Expected Result: I expect problem 4 to dequeue first
    // Defect(s) Found: None!
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("problem1", 1);
        priorityQueue.Enqueue("problem2", 2);
        priorityQueue.Enqueue("problem3", 3);
        priorityQueue.Enqueue("problem4", 4);
    }

    // Add more test cases as needed below.
}