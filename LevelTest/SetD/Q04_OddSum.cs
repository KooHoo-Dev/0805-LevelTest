namespace LevelTest.SetD;

public static class Q04_OddSum
{
    // Q4 : 1부터 N까지의 홀수의 합 구하기
    //
    // 문제 설명:
    //   정수 n이 주어집니다. 1부터 n까지의 정수 중 홀수의 합을 반환하세요.
    //
    // 규칙:
    //   - n은 0 이상의 정수입니다.
    //   - n이 0이면 0을 반환합니다.
    //   - for문을 사용해 구현하세요.
    //
    // 예시:
    //   1  → 1
    //   5  → 9    (1 + 3 + 5)
    //   10 → 25   (1 + 3 + 5 + 7 + 9)
    //   0  → 0

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs   = { 0, 1, 5, 10, 11, 100 };
    public static int[] Expected = { 0, 1, 9, 25, 36, 2500 };

    public static void Check() => Grader.Run("Q4 (1~N 홀수 합)", Inputs, Expected, Solve);
}
