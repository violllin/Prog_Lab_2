using System.Text;

namespace Laba_2
{
    public class FinalExam : Exam
    {
        public string ExamName { get; set; }
        public FinalExam(string _ExamName, int _TimeLimit, List<Question> _Questions, int _MinScore, int _MaxScore)
            : base(_TimeLimit, _Questions, _MinScore, _MaxScore)
        { 
            ExamName = _ExamName;
        }
        
        public override string ToString()
        {
            return ExamName;
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
