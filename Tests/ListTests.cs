namespace Tests;

using Laba_2;
[TestClass]
public class ListTests
{
    [TestMethod]
    public void OperatorPlus_AddsElementToBeginning()
    {
        var list = new List<int>(new int[] { 3, 6, 1 });

        var result = 1 + list;

        Assert.AreEqual("List(1, 3, 6, 1)", result.ToString());
    }

    [TestMethod]
    public void OperatorDecrement_RemovesFirstElement()
    {
        // Arrange
        var list = new Laba_2.List<int>(new int[] { 3, 6, 1 });

        // Act
        var result = --list;

        // Assert
        Assert.AreEqual("List(6, 1)", result.ToString());
    }

    [TestMethod]
    public void OperatorEquality_TwoListsAreEqual_ReturnsTrue()
    {
        // Arrange
        var list1 = new Laba_2.List<int>(new int[] { 3, 6, 1 });
        var list2 = new Laba_2.List<int>(new int[] { 3, 6, 1 });

        // Act
        var result = list1 == list2;

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OperatorInequality_TwoListsAreNotEqual_ReturnsTrue()
    {
        // Arrange
        var list1 = new Laba_2.List<int>(new int[] { 3, 6, 1 });
        var list2 = new Laba_2.List<int>(new int[] { 1, 2, 3 });

        // Act
        var result = list1 != list2;

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OperatorMultiply_CombinesTwoLists()
    {
        // Arrange
        var list1 = new Laba_2.List<int>(new int[] { 3, 6, 1 });
        var list2 = new Laba_2.List<int>(new int[] { 4, 5 });

        // Act
        var result = list1 * list2;

        // Assert
        Assert.AreEqual("List(3, 6, 1, 4, 5)", result.ToString());
    }
}