using System.Text;

namespace Laba_2;

public sealed class Testing
{
    public List<Question> Questions { get; set; }
    public bool TestComplite { get; private set; }
    public int MinScoreForComplite { get; set; }
    public int MaxScoreInTest { get; set; }
    public int CurrentScore { get; private set; }

    public Testing(List<Question> _Questions)
    {
        Questions = _Questions;
    }

    public Testing(int _MinScore, int _MaxScore, List<Question> _Questions)
    {
        MinScoreForComplite = _MinScore;
        MaxScoreInTest = _MaxScore;
        Questions = _Questions;
    }

    public override string ToString()
    {
        CalculateCurrentScore();
        var res = new StringBuilder();

        res.AppendLine($"Final Score: {CurrentScore}/{MaxScoreInTest}");
        res.AppendLine(Complete() ? "You have passed the test!" : "You failed the test!");

        return res.ToString();
    }

    public void AddQuestions(Question question)
    {
        Questions = question + Questions;
    }

    public bool Complete()
    {
        CalculateCurrentScore();
        return CurrentScore >= MinScoreForComplite;
    }

    private void CalculateCurrentScore()
    {
        CurrentScore = 0;
        foreach (var q in Questions)
        {
            if (q.ChoiceAnswer)
            {
                CurrentScore += 1;
            }
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != typeof(Testing))
        {
            return false;
        }

        return true;
    }
}