namespace LevelTest.SetC;

public static class Q06_DigitCount
{
    // Q6 (while 반복문) : 자릿수의 개수 구하기
    //
    // 문제 설명:
    //   0 이상의 정수 n이 주어집니다. n이 몇 자리 수인지(자릿수의 개수)를 반환하세요.
    //
    // 규칙:
    //   - n은 0 이상의 정수입니다.
    //   - n이 0이면 1을 반환합니다. (0도 한 자리 수로 간주)
    //   - while문을 사용해 구현하세요. (힌트: n을 10으로 계속 나누며 카운트)
    //
    // 예시:
    //   0     → 1
    //   7     → 1
    //   10    → 2
    //   123   → 3
    //   12345 → 5
    //   999   → 3
    //   1000  → 4

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs   = { 0, 7, 10, 123, 12345, 999, 1000 };
    public static int[] Expected = { 1, 1, 2,  3,   5,     3,   4 };

    public static void Check() => Grader.Run("Q6 (자릿수의 개수)", Inputs, Expected, Solve);
}
