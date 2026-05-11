namespace LevelTest.SetA;

public static class Q02_TimeFormat
{
    // Q2 (연산자) : 초(second)를 "MM:SS" 형식 문자열로 변환
    //
    // 문제 설명:
    //   0 이상의 정수 totalSeconds가 주어집니다.
    //   이를 "MM:SS" 형식의 문자열로 변환해 반환하세요.
    //   분과 초는 각각 두 자리로 0 채움(zero-padding)합니다.
    //
    // 규칙:
    //   - totalSeconds는 0 이상의 정수입니다.
    //   - 분이 99를 넘을 수도 있습니다. (그래도 두 자리 이상은 그대로 출력, 즉 "120:05" 형태도 허용)
    //   - 분/초 모두 1자리 수면 앞에 0을 붙여 두 자리로 만듭니다.
    //   - 힌트: / 와 % 연산자를 사용하세요.
    //
    // 예시:
    //   0     → "00:00"
    //   65    → "01:05"
    //   125   → "02:05"
    //   600   → "10:00"
    //   3661  → "61:01"

    public static string Solve(int totalSeconds)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 0,       65,      125,     600,     3661 };
    public static string[] Expected = { "00:00", "01:05", "02:05", "10:00", "61:01" };

    public static void Check() => Grader.Run("Q2 (시간 포맷)", Inputs, Expected, Solve);
}
