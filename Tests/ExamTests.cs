namespace Tests;

using Laba_2;

[TestClass]
public class ExamTests
{
    [TestMethod]
    public void Exam_ToString_ReturnsCorrectScore()
    {
        var questions = new List<Question>
        {
            new Question("Q1", "D1", new Dictionary<int, string> { { 1, "A" } }, 1, 1),
            new Question("Q2", "D2", new Dictionary<int, string> { { 2, "B" } }, 2, 1)
        };
        var exam = new Exam(60, questions, 1, 2);

        var result = exam.ToString();

        StringAssert.Contains(result, "Final Score: 1/2");
    }
}