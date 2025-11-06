using System.Linq;

namespace LevelTest;

class Program
{
    static void Main(string[] args)
    {
        //Quiz1
        {
            Console.WriteLine("==============Quiz1================");
            string[] testCase = new[] { "월요일", "화요일", "수요일", "목요일", "금요일", "토요일", "일요일" };
            string[] answerCase = new[] { "평일", "평일", "평일", "평일", "평일", "휴일", "휴일" };
            CheckQuiz1(testCase, answerCase);
        }
        
        //Quiz2
        {
            Console.WriteLine("==============Quiz2================");
            int[] testCase = new[] { 56, 77, 90, 87, 83 };
            string[] answerCase = new[] { "F", "C", "A", "B", "B" };
            CheckQuiz2(testCase, answerCase);
        }
        
        //Quiz3
        {
            Console.WriteLine("==============Quiz3================");
            int[][] testCases = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 2, 4, 6, 8, 10 },
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { }
            };
            int[] answerCases = new int[] { 2, 5, 0, 0 };
            CheckQuiz3(testCases, answerCases);
        }

        //Quiz4
        {
            Console.WriteLine("==============Quiz4================");
            int[][] testCases = { new int[] { 3, 8, 1, 9, 4 }, new int[] { -1, -5, -3 }, new int[] { } };
            int[] answerCases = { 9, -1, 0 };
            CheckQuiz4(testCases, answerCases);
        }
        
        //Quiz5
        {
            Console.WriteLine("==============Quiz5================");
            int[] testCases = { 3, 5 };
            string[][] answerCases = { new string[] { "*", "**", "***" }, new string[] { "*", "**", "***", "****", "*****" } };
            CheckQuiz5(testCases, answerCases);
        }

        //Quiz6
        {
            Console.WriteLine("==============Quiz6================");
            int[][] testCases = { new int[] { 1, -2, 3, -4, 5 }, new int[] { -1, -2, -3 }, new int[] { } };
            int[] answerCases = { 3, 0, 0 };
            CheckQuiz6(testCases, answerCases);
        }

        //Quiz7
        {
            Console.WriteLine("==============Quiz7================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 } };
            int[] targets = { 3, 6 };
            bool[] answerCases = { true, false };
            CheckQuiz7(testCases, targets, answerCases);
        }
    }

    private static string GetAnswerMessage(bool isCorrect) => isCorrect ? "정답" : "오답";
    private static void SelectColor(bool isCorrect) => Console.ForegroundColor = isCorrect ? ConsoleColor.Green : ConsoleColor.Red;
    
    private static void CheckQuiz1(string[] testCase, string[] answerCase)
    {
        try
        {
            for (int i = 0; i < testCase.Length; i++)
            {
                var answer = Quiz1.GetDayType(testCase[i]);
                bool isCorrect = answer.Equals(answerCase[i]);
                string message = GetAnswerMessage(isCorrect);
                
                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 1: 케이스 {i}, testCase = {testCase[i]}, return = {answer}, {message} ");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz1 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz2(int[] testCase, string[] answerCase)
    {
        try
        {
            for (int i = 0; i < testCase.Length; i++)
            {
                var answer = Quiz2.CalculateGrade(testCase[i]);
                bool isCorrect = answer.Equals(answerCase[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 2: 케이스 {i}, testCase = {testCase[i]}, return {answer}, {message} ");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz2 함수가 구현되지 않았습니다.");
        }
    }
    
    private static void CheckQuiz3(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz3.CountEvenNumber(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 3: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer} ,{message} ");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz3 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz4(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz4.FindMax(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 4: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz4 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz5(int[] testCases, string[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz5.PrintTriangle(testCases[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 5: 케이스 {i}, testCase = {testCases[i]}, return = {{{string.Join(",", answer.Select(s => $"\"{s}\""))}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz5 함수가 구현되지 않았습니다.");
        }
    }
    
    private static void CheckQuiz6(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz6.CountPositiveNumbers(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 6: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz6 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz7(int[][] testCases, int[] targets, bool[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz7.ContainsValue(testCases[i], targets[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 7: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, target = {targets[i]}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz7 함수가 구현되지 않았습니다.");
        }
    }
}
