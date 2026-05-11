namespace LevelTest.SetB;

public static class Q01_SquareNumber
{
    // Q1 (자료형/형변환) : 문자열을 정수로 변환 후 제곱(자기 자신을 곱함) 반환
    //
    // 문제 설명:
    //   숫자 문자열 input이 매개변수로 주어집니다.
    //   이 문자열을 정수(int)로 변환한 뒤, 그 값을 제곱한 결과(즉, 자기 자신을 곱한 값)를 반환하세요.
    //
    // 규칙:
    //   - input은 항상 유효한 정수 문자열입니다. (음수 가능, 공백 없음)
    //
    // 예시:
    //   "5"   → 25
    //   "10"  → 100
    //   "-3"  → 9
    //   "0"   → 0

    public static int Solve(string input)
    {
        throw new NotImplementedException();
    }

    public static string[] Inputs   = { "5", "10", "-3", "0", "12" };
    public static int[]    Expected = { 25,  100,  9,    0,   144 };

    public static void Check() => Grader.Run("Q1 (자료형 변환 - 제곱)", Inputs, Expected, Solve);
}
