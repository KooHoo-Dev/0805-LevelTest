namespace LevelTest.SetB;

// Q12에서 사용되는 점수 구조체. (시험 문제이므로 구조체 정의는 미리 제공됩니다)
public struct Score
{
    public string Subject;
    public int Value;

    public Score(string subject, int value)
    {
        Subject = subject;
        Value = value;
    }

    public override string ToString() => $"{{{Subject}, {Value}}}";
}

public static class Q12_AboveAverageScore
{
    // Q12 (구조체 - 집계) : 평균을 "초과"하는 과목 개수 세기
    //
    // 문제 설명:
    //   점수 구조체(Score) 배열이 주어집니다. Score는 다음 필드를 가집니다.
    //     - string Subject : 과목명
    //     - int    Value   : 점수
    //
    //   전체 과목의 평균 점수를 구한 뒤, 평균 점수를 "초과"하는(즉, 평균보다 큰 - 같지 않음) 과목의 개수를 반환하세요.
    //
    // 규칙:
    //   - 배열이 비어 있으면 0을 반환합니다.
    //   - 평균은 정수 나눗셈이 아니라 실수(double 등)로 계산하세요.
    //   - 평균과 정확히 같은 점수는 "초과"가 아니므로 포함하지 않습니다. (예: 평균 50, 점수 50 → 제외)
    //
    // 예시:
    //   [ (국어, 100), (영어, 200), (수학, 300) ]    → 1   (평균 200, 초과는 300만)
    //   [ (a, 100), (b, 200), (c, 301) ]              → 1   (평균 200.33..., 초과는 301)
    //   [ (X, 50) ]                                   → 0   (평균 50, 초과 없음)
    //   [ ]                                           → 0

    public static int Solve(Score[] scores)
    {
        throw new NotImplementedException();
    }

    public static Score[][] Inputs =
    {
        new[] { new Score("국어", 100), new Score("영어", 200), new Score("수학", 300) },
        new[] { new Score("a", 100), new Score("b", 200), new Score("c", 301) },
        new[] { new Score("X", 50) },
        new Score[] { },
        new[] { new Score("a", 10), new Score("b", 20), new Score("c", 30), new Score("d", 40) },
        new[] { new Score("p", 1000), new Score("q", 1000), new Score("r", 1000) },
    };
    public static int[] Expected = { 1, 1, 0, 0, 2, 0 };

    public static void Check() => Grader.Run("Q12 (평균 초과 과목 수)", Inputs, Expected, Solve);
}
