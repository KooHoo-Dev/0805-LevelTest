namespace LevelTest.SetC;

public static class Q01_NegateNumber
{
    // Q1 (자료형/형변환) : 문자열을 정수로 변환 후 부호 반전 (-1을 곱함)
    //
    // 문제 설명:
    //   숫자 문자열 input이 매개변수로 주어집니다.
    //   이 문자열을 정수(int)로 변환한 뒤, 부호를 반전한 값(즉, -1을 곱한 값)을 반환하세요.
    //
    // 규칙:
    //   - input은 항상 유효한 정수 문자열입니다. (음수 가능, 공백 없음)
    //
    // 예시:
    //   "5"      → -5
    //   "100"    → -100
    //   "-3"     → 3
    //   "0"      → 0

    public static int Solve(string input)
    {
        throw new NotImplementedException();
    }

    public static string[] Inputs   = { "5", "100", "-3", "0", "12345" };
    public static int[]    Expected = { -5,  -100,  3,    0,   -12345 };

    public static void Check() => Grader.Run("Q1 (자료형 변환 - 부호 반전)", Inputs, Expected, Solve);
}
