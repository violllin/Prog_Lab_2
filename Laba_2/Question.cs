using System.Text;

namespace Laba_2
{
    interface IQuestion
    {
        void PrintInfo();
    }
    public class Question : IQuestion
    {
        public string? Problem { get; set; }
        public string? Description { get; set; }
        public Dictionary<int, string> AnswerOptions { get; set; }
        public int RightAnswer { get; set; }
        public bool ChoiceAnswer { get; private set; }
        public int UserChoice { get; set; }
        public Question(string _Problem, string _Description, Dictionary<int, string> _AnswerOptions, int _RightAnswer, int _UserChoice)
        {
            Problem = _Problem;
            Description = _Description;
            AnswerOptions = _AnswerOptions;
            RightAnswer = _RightAnswer;
            UserChoice = _UserChoice;
            ChoiceAnswer = CheckAnswer(_UserChoice);
        }
        public Question(string _Problem, string _Description, Dictionary<int, string> _AnswerOptions, int _RightAnswer)
        {
            Problem = _Problem;
            Description = _Description;
            AnswerOptions = _AnswerOptions;
            RightAnswer = _RightAnswer;
            ChoiceAnswer = CheckAnswer(_RightAnswer);
        }
        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine($"Problem: {Problem}");
            res.AppendLine($"Description: {Description}");
            res.AppendLine($"Answer: ");
            foreach (var (key, val) in AnswerOptions)
            {
                res.AppendLine($"{key}. {val}");
            }
            return res.ToString();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Проблема: {Problem}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine("Вопросы: ");
            foreach (var (key, val) in AnswerOptions)
            {
                Console.WriteLine($"{key}. {val}");
            }
            Console.WriteLine($"Правильный ответ: {RightAnswer}");
        }
        public bool CheckAnswer(int response)
        {
            return response == RightAnswer;
        }
        public void EnterAnswer()
        {
            string answer;
            short count = 0;
            AnswerOptions.Clear();
            AnswerOptions = new Dictionary<int, string>();
            
            Console.Write("Введите кол-во ответов: ");
            count = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Введите ответы: ");
            for (int i = 0; i < count; i++)
            {
                answer = Console.ReadLine();
                AnswerOptions.Add(i + 1,answer);
            }
            foreach (var item in AnswerOptions)
            {
                Console.WriteLine($"{item.Key}. {item.Value}");
            }

            Console.WriteLine("Установите номер правильного ответа: ");
            RightAnswer = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
