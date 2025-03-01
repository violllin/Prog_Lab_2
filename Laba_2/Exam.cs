using System.Text;

namespace Laba_2
{
    public class Exam : Trial
    {
        public int TimeLimit { get; set; }
        public Exam(int _TimeLimit, List<Question> _Questions, int _MinScore, int _MaxScore) : base (_Questions, _MinScore, _MaxScore)
        {
            TimeLimit = _TimeLimit;
        }
        public override string ToString()
        {
            var res = new StringBuilder();
            CalculateScore();
            res.AppendLine($"Final Score: {CurrentScore}/{MaxScore}");
            res.AppendLine(TestComplete() ? "You have passed the test!" : "You failed the test!");
            return res.ToString();
        }

        private void CalculateScore()
        {
            foreach (var q in Questions)
            {
                if (q.ChoiceAnswer)
                {
                    CurrentScore += 1;
                }
            }
        }
    }
}
