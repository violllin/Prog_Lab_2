namespace Tests;

using Laba_2;

[TestClass]
public class FinalExamTests
{
    [TestMethod]
    public void PrintInfo_ReturnsCorrectExamName()
    {
        var questions = new List<Question>();
        var finalExam = new FinalExam("Graduation Exam", 120, questions, 1, 2);

        var result = finalExam.PrintInfo();

        StringAssert.Contains(result, "Graduation Exam");
    }
}