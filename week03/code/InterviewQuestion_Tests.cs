using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class InterviewQuestionTests
{
    [TestMethod]
    public void Union_BasicCombination_WithoutDuplicates()
    {
        // Arrange
        string[] words1 = { "hi", "world" };
        string[] words2 = { "world", "fantastic" };
        string[] expected = { "hi", "world", "fantastic" };

        // Act
        var result = InterviewQuestion.Union(words1, words2);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_EmptyArray()
    {
        string[] words1 = { };
        string[] words2 = { "one", "two" };
        string[] expected = { "one", "two" };

        var result = InterviewQuestion.Union(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_TwoEmptyArrays()
    {
        var result = InterviewQuestion.Union(new string[0], new string[0]);
        Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void Union_DuplicateWords()
    {
        string[] words1 = { "a", "b", "a" };
        string[] words2 = { "b", "c", "c" };
        string[] expected = { "a", "b", "c" };

        var result = InterviewQuestion.Union(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Union_CaseSensitive()
    {
        string[] words1 = { "Hi" };
        string[] words2 = { "hi" };
        string[] expected = { "Hi", "hi" };

        var result = InterviewQuestion.Union(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_BasicOverlap_ReturnsCommonElements()
    {
        // Arrange
        string[] words1 = { "hello", "world" };
        string[] words2 = { "world", "fantastic" };
        string[] expected = { "world" };

        // Act
        var result = InterviewQuestion.Intersection(words1, words2);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_NoCommonElements_ReturnsEmptyArray()
    {
        string[] words1 = { "a", "b", "c" };
        string[] words2 = { "x", "y", "z" };
        string[] expected = { };

        var result = InterviewQuestion.Intersection(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_OneEmptyArray_ReturnsEmptyArray()
    {
        string[] words1 = { };
        string[] words2 = { "test", "case" };
        string[] expected = { };

        var result = InterviewQuestion.Intersection(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_BothEmptyArrays_ReturnsEmptyArray()
    {
        var result = InterviewQuestion.Intersection(new string[0], new string[0]);

        Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void Intersection_DuplicateElementsInInputs_ReturnsUniqueCommonElements()
    {
        string[] words1 = { "a", "b", "a", "c" };
        string[] words2 = { "b", "c", "c", "d" };
        string[] expected = { "b", "c" };

        var result = InterviewQuestion.Intersection(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void Intersection_CaseSensitiveBehavior()
    {
        string[] words1 = { "Hello" };
        string[] words2 = { "hello" };
        string[] expected = { };

        var result = InterviewQuestion.Intersection(words1, words2);

        CollectionAssert.AreEquivalent(expected, result);
    }
}