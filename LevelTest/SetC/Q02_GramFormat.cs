namespace LevelTest.SetC;

public static class Q02_GramFormat
{
    // Q2 (연산자) : 그램을 "Xkg Yg" 형식 문자열로 변환
    //
    // 문제 설명:
    //   0 이상의 정수 gram이 주어집니다.
    //   이를 "{킬로그램}kg {그램}g" 형식의 문자열로 변환해 반환하세요.
    //   1kg = 1000g 입니다.
    //
    // 규칙:
    //   - gram은 0 이상의 정수입니다.
    //   - 0 채움(zero-padding)은 하지 않습니다. 그대로 정수 출력합니다.
    //   - 힌트: / 와 % 연산자를 사용하세요.
    //
    // 예시:
    //   0      → "0kg 0g"
    //   500    → "0kg 500g"
    //   1500   → "1kg 500g"
    //   2000   → "2kg 0g"
    //   10001  → "10kg 1g"

    public static string Solve(int gram)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 0,         500,         1500,        2000,       10001 };
    public static string[] Expected = { "0kg 0g",  "0kg 500g",  "1kg 500g",  "2kg 0g",   "10kg 1g" };

    public static void Check() => Grader.Run("Q2 (g → kg·g 변환)", Inputs, Expected, Solve);
}
