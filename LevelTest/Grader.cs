using System.Collections;
using System.Runtime.CompilerServices;

namespace LevelTest;

public static class Grader
{
    private static int s_setCorrect;
    private static int s_setTotal;
    private static string s_setName = "";

    public static void StartSet(string setName)
    {
        s_setCorrect = 0;
        s_setTotal = 0;
        s_setName = setName;
        Console.WriteLine();
        Console.WriteLine($"================ {setName} 시작 ================");
    }

    public static void EndSet()
    {
        Console.WriteLine();
        Console.WriteLine($"================ {s_setName} 종료: 총 {s_setCorrect}/{s_setTotal} 케이스 통과 ================");
    }

    public static void Run<TInput, TExpected>(
        string quizName,
        TInput[] inputs,
        TExpected[] expected,
        Func<TInput, TExpected> solver)
    {
        Console.WriteLine();
        Console.WriteLine($"--- {quizName} ---");

        if (inputs.Length != expected.Length)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [출제 오류] 입력 케이스 수({inputs.Length})와 기대값 수({expected.Length})가 다릅니다.");
            Console.ResetColor();
            return;
        }

        int correctInQuiz = 0;
        for (int i = 0; i < inputs.Length; i++)
        {
            s_setTotal++;
            try
            {
                TExpected actual = solver(inputs[i]);
                bool ok = AreEqual(actual, expected[i]);

                if (ok)
                {
                    s_setCorrect++;
                    correctInQuiz++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"  [정답] 케이스{i}: 입력={Format(inputs[i])}, 반환={Format(actual)}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"  [오답] 케이스{i}: 입력={Format(inputs[i])}, 반환={Format(actual)}, 기대={Format(expected[i])}");
                }
                Console.ResetColor();
            }
            catch (NotImplementedException)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  [미구현] {quizName} 함수가 아직 구현되지 않았습니다. 이후 케이스 채점을 건너뜁니다.");
                Console.ResetColor();
                // 남은 케이스도 total 에 반영해 점수가 부풀려지지 않도록 처리
                s_setTotal += (inputs.Length - i - 1);
                return;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  [예외] 케이스{i}: 입력={Format(inputs[i])}, {ex.GetType().Name}: {ex.Message}");
                Console.ResetColor();
            }
        }

        Console.WriteLine($"  → {quizName}: {correctInQuiz}/{inputs.Length} 통과");
    }

    private static bool AreEqual<T>(T a, T b)
    {
        if (a is null) return b is null;
        if (b is null) return false;

        if (a is string sa && b is string sb) return sa == sb;

        if (a is IEnumerable ea && b is IEnumerable eb)
        {
            var ia = ea.GetEnumerator();
            var ib = eb.GetEnumerator();
            while (true)
            {
                bool ha = ia.MoveNext();
                bool hb = ib.MoveNext();
                if (ha != hb) return false;
                if (!ha) return true;
                var va = ia.Current;
                var vb = ib.Current;
                if (va is null && vb is null) continue;
                if (va is null || vb is null) return false;
                if (!va.Equals(vb)) return false;
            }
        }

        return a.Equals(b);
    }

    private static string Format(object? obj)
    {
        if (obj is null) return "null";
        if (obj is string s) return $"\"{s}\"";
        if (obj is bool b) return b ? "true" : "false";
        if (obj is ITuple tuple)
        {
            var parts = new List<string>();
            for (int i = 0; i < tuple.Length; i++) parts.Add(Format(tuple[i]));
            return "(" + string.Join(", ", parts) + ")";
        }
        if (obj is IEnumerable e)
        {
            var items = new List<string>();
            foreach (var item in e) items.Add(Format(item));
            return "[" + string.Join(", ", items) + "]";
        }
        return obj.ToString() ?? "null";
    }
}
