using System.Linq;

namespace LevelTest;

class Program
{
    static void Main(string[] args)
    {
        // int number = 100;
        // int result = Quiz6.RunHanoi(number, "A", "C", "B");
        //
        // Console.WriteLine($"이동횟수는 {result} 입니다");
        // return;

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

        //Quiz6
        {
            Console.WriteLine("==============Quiz6================");
            int[][] testCases = { new int[] { 3, 8, 1, 9, 4 }, new int[] { -1, -5, -3 }, new int[] { } };
            int[] answerCases = { 9, -1, 0 };
            CheckQuiz6(testCases, answerCases);
        }
        
        //Quiz7
        {
            Console.WriteLine("==============Quiz7================");
            int[] testCases = { 3, 5 };
            string[][] answerCases = { new string[] { "*", "**", "***" }, new string[] { "*", "**", "***", "****", "*****" } };
            CheckQuiz7(testCases, answerCases);
        }

        //Quiz8
        {
            Console.WriteLine("==============Quiz8================");
            int[][] testCases = { new int[] { 3, 8, 1, 9, 4 }, new int[] { -1, -5, -3 }, new int[] { } };
            int[] answerCases = { 1, -5, 0 };
            CheckQuiz8(testCases, answerCases);
        }

        //Quiz9
        {
            Console.WriteLine("==============Quiz9================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 10, 20, 30 }, new int[] { } };
            double[] answerCases = { 3.0, 20.0, 0.0 };
            CheckQuiz9(testCases, answerCases);
        }

        //Quiz10
        {
            Console.WriteLine("==============Quiz10================");
            int[][] testCases = { new int[] { 1, -2, 3, -4, 5 }, new int[] { -1, -2, -3 }, new int[] { } };
            int[] answerCases = { 3, 0, 0 };
            CheckQuiz10(testCases, answerCases);
        }

        //Quiz11
        {
            Console.WriteLine("==============Quiz11================");
            int[] testCases = { 5, 1, 0 };
            string[] answerCases = { "1,2,3,4,5", "1", "" };
            CheckQuiz11(testCases, answerCases);
        }

        //Quiz12
        {
            Console.WriteLine("==============Quiz12================");
            int[] testCases = { 15 };
            string[][] answerCases = { new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } };
            CheckQuiz12(testCases, answerCases);
        }

        //Quiz13
        {
            Console.WriteLine("==============Quiz13================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5 }, new int[] { } };
            int[][] answerCases = { new int[] { 5, 4, 3, 2, 1 }, new int[] { } };
            CheckQuiz13(testCases, answerCases);
        }

        //Quiz14
        {
            Console.WriteLine("==============Quiz14================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 } };
            int[] targets = { 3, 6 };
            bool[] answerCases = { true, false };
            CheckQuiz14(testCases, targets, answerCases);
        }

        //Quiz15
        {
            Console.WriteLine("==============Quiz15================");
            int[] testCases = { 5, 0 };
            long[] answerCases = { 120, 1 };
            CheckQuiz15(testCases, answerCases);
        }

        //Quiz16
        {
            Console.WriteLine("==============Quiz16================");
            int[] testCases = { 7, 10, 1 };
            bool[] answerCases = { true, false, false };
            CheckQuiz16(testCases, answerCases);
        }

        //Quiz17
        {
            Console.WriteLine("==============Quiz17================");
            int[][] testCases1 = { new int[] { 1, 3, 5 }, new int[] { 1, 2 } };
            int[][] testCases2 = { new int[] { 2, 4, 6 }, new int[] { 3, 4 } };
            int[][] answerCases = { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4 } };
            CheckQuiz17(testCases1, testCases2, answerCases);
        }

        //Quiz18
        {
            Console.WriteLine("==============Quiz18================");
            string[] testCasesStr = { "hello world", "programming" };
            char[] testCasesChar = { 'l', 'P' };
            int[] answerCases = { 3, 0 };
            CheckQuiz18(testCasesStr, testCasesChar, answerCases);
        }

        //Quiz19
        {
            Console.WriteLine("==============Quiz19================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 10, 20, 30 } };
            int[] ks = { 2, 1 };
            int[][] answerCases = { new int[] { 4, 5, 1, 2, 3 }, new int[] { 30, 10, 20 } };
            CheckQuiz19(testCases, ks, answerCases);
        }

        //Quiz20
        {
            Console.WriteLine("==============Quiz20================");
            int[][] testCases = { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 3, 5 } };
            int[][] answerCases = { new int[] { 2, 4, 6 }, new int[] { } };
            CheckQuiz20(testCases, answerCases);
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

    private static void CheckQuiz6(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz6.FindMax(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 7: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz7 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz7(int[] testCases, string[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz7.PrintTriangle(testCases[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 20: 케이스 {i}, testCase = {testCases[i]}, return = {{{string.Join(",", answer.Select(s => $"\"{s}\""))}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz20 함수가 구현되지 않았습니다.");
        }
    }
    
    private static void CheckQuiz8(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz8.FindMin(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 8: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz8 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz9(int[][] testCases, double[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz9.CalculateAverage(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 9: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz9 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz10(int[][] testCases, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz10.CountPositiveNumbers(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 10: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz10 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz11(int[] testCases, string[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz11.CreateNumberString(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 11: 케이스 {i}, testCase = {testCases[i]}, return = \"{answer}\", {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz11 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz12(int[] testCases, string[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz12.FizzBuzz(testCases[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 12: 케이스 {i}, testCase = {testCases[i]}, return = {{{string.Join(",", answer)}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz12 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz13(int[][] testCases, int[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz13.ReverseArray(testCases[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 13: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {{{string.Join(",", answer)}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz13 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz14(int[][] testCases, int[] targets, bool[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz14.ContainsValue(testCases[i], targets[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 14: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, target = {targets[i]}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz14 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz15(int[] testCases, long[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz15.Factorial(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 15: 케이스 {i}, testCase = {testCases[i]}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz15 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz16(int[] testCases, bool[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz16.IsPrime(testCases[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 16: 케이스 {i}, testCase = {testCases[i]}, return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz16 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz17(int[][] testCases1, int[][] testCases2, int[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases1.Length; i++)
            {
                var answer = Quiz17.MergeSortedArrays(testCases1[i], testCases2[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 17: 케이스 {i}, testCase1 = {{{string.Join(",", testCases1[i])}}}, testCase2 = {{{string.Join(",", testCases2[i])}}}, return = {{{string.Join(",", answer)}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz17 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz18(string[] testCasesStr, char[] testCasesChar, int[] answerCases)
    {
        try
        {
            for (int i = 0; i < testCasesStr.Length; i++)
            {
                var answer = Quiz18.CountCharacter(testCasesStr[i], testCasesChar[i]);
                bool isCorrect = answer.Equals(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 18: 케이스 {i}, str = \"{testCasesStr[i]}\", ch = '{testCasesChar[i]}', return = {answer}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz18 함수가 구현되지 않았습니다.");
        }
    }

    

    private static void CheckQuiz19(int[][] testCases, int[] ks, int[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz19.RotateArray(testCases[i], ks[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 21: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, k = {ks[i]}, return = {{{string.Join(",", answer)}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz21 함수가 구현되지 않았습니다.");
        }
    }

    private static void CheckQuiz20(int[][] testCases, int[][] answerCases)
    {
        try
        {
            for (int i = 0; i < testCases.Length; i++)
            {
                var answer = Quiz20.RemoveOddNumbers(testCases[i]);
                bool isCorrect = answer.SequenceEqual(answerCases[i]);
                string message = GetAnswerMessage(isCorrect);

                SelectColor(isCorrect);
                Console.WriteLine($"Quiz 23: 케이스 {i}, testCase = {{{string.Join(",", testCases[i])}}}, return = {{{string.Join(",", answer)}}}, {message}");
                Console.ResetColor();
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Quiz23 함수가 구현되지 않았습니다.");
        }
    }
}
