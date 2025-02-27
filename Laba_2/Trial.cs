using System.Text;

namespace Laba_2;

public class Trial
{
    public string TrialName { get; set; }
    public List<Question> Questions { get; set; }
    public int CurrentScore { get; set; }
    public int MinScore { get; set; }
    public int MaxScore { get; set; }

    public Trial(List<Question> _Questions, int _MinScore, int _MaxScore)
    {
        Questions = _Questions;
        MinScore = _MinScore;
        MaxScore = _MaxScore;
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
        res.AppendLine(TestComplete() ? "You have passed the test!" : "You failed the test!");

        return res.ToString();
    }

    public bool TestComplete()
    {
        return CurrentScore <= MinScore;
    }
}