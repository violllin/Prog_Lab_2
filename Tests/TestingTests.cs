using Laba_2;
namespace Tests
{
    [TestClass]
    public class TestingTests
    {
        [TestMethod]
        public void TestCompite_ScoreMeetsMin_ReturnsTrue()
        {
            var questions = new Laba_2.List<Question>
            {
                new Question("Q1", "D1", new Dictionary<int, string> { { 1, "A" } }, 1, 1),
                new Question("Q2", "D2", new Dictionary<int, string> { { 1, "B" } }, 1, 1)
            };
            var testing = new Testing(1, 2, questions);

            var result = testing.Complete();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestComplete_ScoreBelowMin_ReturnsFalse()
        {
            var questions = new Laba_2.List<Question>
            {
                new Question("Q1", "D1", new Dictionary<int, string> { { 1, "A" }, {2,"B"} }, 1, 2),
                new Question("Q2", "D2", new Dictionary<int, string> { { 1, "A" }, {2, "B"} }, 1, 2)
            };
            var testing = new Testing(2, 2, questions);

            var result = testing.Complete();

            Assert.IsFalse(result);
        }
    }
}