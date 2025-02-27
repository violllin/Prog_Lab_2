namespace Tests;

using Laba_2;

[TestClass]
public class TrialTests
{
    [TestMethod]
    public void TestComplite_ScoreBelowMin_ReturnsTrue()
    {
        var questions = new List<Question>
        {
            new Question("Q1", "D1", new Dictionary<int, string> { { 1, "A" } }, 1, 2)
        };
        var trial = new Trial(questions, 1, 10);

        var result = trial.TestComplete();

        Assert.IsTrue(result);
    }
}