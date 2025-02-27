using Laba_2;

namespace Tests;

[TestClass]
public class QuestionTests
{
    [TestMethod]
    public void CheckAnswer_CorrectAnswer_ReturnsTrue()
    {
        var answers = new Dictionary<int, string> { { 1, "A" }, { 2, "B" } };
        var question = new Question("Test?", "Choose:", answers, 1);

        var result = question.CheckAnswer(1);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckAnswer_WrongAnswer_ReturnsFalse()
    {
        var answers = new Dictionary<int, string> { { 1, "A" }, { 2, "B" } };
        var question = new Question("Test?", "Choose:", answers, 1);

        var result = question.CheckAnswer(2);

        Assert.IsFalse(result);
    }
}