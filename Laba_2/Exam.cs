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
            StringBuilder res = new StringBuilder();
            foreach (var q in Questions)
            {
                if (q.ChoiceAnswer)
                {
                    CurrentScore += 1;
                }
            }
            res.AppendLine($"Final Score: {CurrentScore}/{MaxScore}");
            if (TestComplite())
            {
                res.AppendLine("You have passed the test!");
            }
            else
            {
                res.AppendLine("You failed the test!");
            }
            return res.ToString();
        }
        public virtual string PrintInfo()
        {
            return $"TimeLimit in minutes: {TimeLimit}";
        }
    }
}
