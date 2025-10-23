using System.Linq;

namespace LevelTest;

class Program
{
    static void Main(string[] args)
    {
        int number = 100;
        int result = Quiz6.RunHanoi(number, "A", "C", "B");

        Console.WriteLine($"이동횟수는 {result} 입니다");
        return;

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
            int[] startNums = new int[] { 1, 5, 10, 0, -5 };
            int[] endNums = new int[] { 5, 1, 10, 0, 5 };
            int[] answerCases = new int[] { 15, 15, 20, 0, 0 }; 
            CheckQuiz4(startNums, endNums, answerCases);
        }

        //Quiz5
        {
            Console.WriteLine("==============Quiz5================");
            
            try
            {
                Quiz5.TextBattle();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Quiz5 함수가 구현되지 않았습니다.");
            }
        }
        
        //Quiz6
        {
            Console.WriteLine("==============Quiz6================");
            int[] testCases = new int[] { 15, 16, 17, 18, 19, 20, 21 };
            int[] answerCases = new int[] { 32767, 65535, 131071, 262143, 524287, 1048575, 2097151 };
            
            CheckQuiz6(testCases, answerCases);
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

    private static void CheckQuiz4(int[] startNums, int[] endNums, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < startNums.Length; i++)
            {
                var answer = Quiz4.SumRange(startNums[i], endNums[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 4: 케이스 {i}, startNum = {startNums[i]}, endNum = {endNums[i]}, return = {answer}, {message} ");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz4 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz6(int[] n, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < n.Length; i++)
            {
                int answer = Quiz6.RunHanoi(n[i], "A", "C", "B");
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);
                
                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 6: 케이스 {i}, n = {n[i]}, return = {answer}, {message} ");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz6 함수가 구현되지 않았습니다.");
        }
    }
}