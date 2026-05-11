namespace LevelTest.SetB;

public static class Q05_EvenSum
{
    // Q5 (for 반복문) : 1부터 N까지의 짝수의 합 구하기
    //
    // 문제 설명:
    //   정수 n이 주어집니다. 1부터 n까지의 정수 중 짝수의 합을 반환하세요.
    //
    // 규칙:
    //   - n은 0 이상의 정수입니다.
    //   - n이 0이나 1이면 0을 반환합니다.
    //   - for문을 사용해 구현하세요.
    //
    // 예시:
    //   0  → 0
    //   1  → 0
    //   2  → 2
    //   5  → 6     (2 + 4)
    //   10 → 30    (2 + 4 + 6 + 8 + 10)

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs   = { 0, 1, 2, 5, 10, 11, 100 };
    public static int[] Expected = { 0, 0, 2, 6, 30, 30, 2550 };

    public static void Check() => Grader.Run("Q5 (1~N 짝수 합)", Inputs, Expected, Solve);
}
