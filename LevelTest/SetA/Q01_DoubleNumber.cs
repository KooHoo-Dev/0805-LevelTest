namespace LevelTest.SetA;

public static class Q01_DoubleNumber
{
    // Q1 (자료형/형변환) : 문자열을 정수로 변환 후 두 배 반환
    //
    // 문제 설명:
    //   숫자 문자열 input이 매개변수로 주어집니다.
    //   이 문자열을 정수(int)로 변환한 뒤, 두 배(×2)한 값을 반환하는 함수를 작성하세요.
    //
    // 규칙:
    //   - input은 항상 유효한 정수 문자열입니다. (음수 가능, 공백 없음)
    //
    // 예시:
    //   "5"    → 10
    //   "100"  → 200
    //   "-3"   → -6

    public static int Solve(string input)
    {
        throw new NotImplementedException();
    }

    public static string[] Inputs   = { "5", "100", "-3", "0", "12345" };
    public static int[]    Expected = { 10,  200,   -6,   0,   24690 };

    public static void Check() => Grader.Run("Q1 (자료형 변환)", Inputs, Expected, Solve);
}
