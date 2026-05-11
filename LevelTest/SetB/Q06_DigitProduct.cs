namespace LevelTest.SetB;

public static class Q06_DigitProduct
{
    // Q6 (while 반복문) : 자릿수의 곱 구하기
    //
    // 문제 설명:
    //   0 이상의 정수 n이 주어집니다. n의 각 자릿수를 모두 곱한 결과를 반환하세요.
    //
    // 규칙:
    //   - n은 0 이상의 정수입니다.
    //   - n이 0이면 0을 반환합니다.
    //   - 자릿수 중 0이 포함되어 있으면 결과는 0이 됩니다.
    //   - while문을 사용해 구현하세요. (힌트: n % 10, n /= 10)
    //
    // 예시:
    //   0      → 0
    //   7      → 7
    //   123    → 6      (1 × 2 × 3)
    //   12345  → 120    (1 × 2 × 3 × 4 × 5)
    //   999    → 729    (9 × 9 × 9)
    //   1024   → 0      (1 × 0 × 2 × 4 = 0)

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs   = { 0, 7, 10, 123, 12345, 999, 1024 };
    public static int[] Expected = { 0, 7, 0,  6,   120,   729, 0 };

    public static void Check() => Grader.Run("Q6 (자릿수의 곱)", Inputs, Expected, Solve);
}
