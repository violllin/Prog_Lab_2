namespace Laba_2;

public class Program
{
    public static void Main()
    {
        var questions = new List<Question>();
        var finalExam = new FinalExam("Graduation Exam", 120, questions, 1, 2);
        Console.WriteLine(finalExam.PrintResult());
        Run_List();
    }

    private static void Run_List()
    {
        var list1 = new List<string>(new string[] { "3", "6", "1" });
        var list2 = new List<string>(new string[] { "1", "3", "6" });
        
        var list3 = "1" + list1;
        Console.WriteLine(list3);
        
        list3 = --list1;
        Console.WriteLine(list3);
        
        Console.WriteLine(list1 != list2);
        Console.WriteLine(list1 != new List<string>(new string[] { "1", "23", "45" }));
        
        var list4 = list1 * list2;
        Console.WriteLine(list4);
    }
}