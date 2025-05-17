using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Items added with varying priorities. Dequeue returns highest priority item.
    // Expected Result: Dequeue returns item with highest priority (C)
    // Defect(s) Found: Incorrect comparison logic or missing removal
    public void TestPriorityQueue_HighestPriorityIsRemoved()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 2);
        pq.Enqueue("C", 5);
        pq.Enqueue("D", 3);

        var result = pq.Dequeue();
        Assert.AreEqual("C", result);
    }

    [TestMethod]
    // Scenario: Multiple items with the same highest priority.
    // Expected Result: The one added first among those is removed (FIFO).
    // Defect(s) Found: Tie-breaking not handled properly
    public void TestPriorityQueue_TieBreakerFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 4);
        pq.Enqueue("Y", 2);
        pq.Enqueue("Z", 4);

        var result = pq.Dequeue();
        Assert.AreEqual("X", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Remove all elements and ensure they come out in priority order.
    // Expected Result: Highest first (FIFO for ties), then next highest.
    public void TestPriorityQueue_RemoveAll()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);
        pq.Enqueue("D", 1);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("D", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: Exception is thrown
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception was expected but not thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}