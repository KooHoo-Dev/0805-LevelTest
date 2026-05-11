namespace LevelTest.SetC;

public static class Q05_MultipleOfThreeSum
{
    // Q5 (for 반복문) : 1부터 N까지의 3의 배수의 합 구하기
    //
    // 문제 설명:
    //   정수 n이 주어집니다. 1부터 n까지의 정수 중 3의 배수의 합을 반환하세요.
    //
    // 규칙:
    //   - n은 0 이상의 정수입니다.
    //   - n이 0이거나 1이거나 2이면 0을 반환합니다.
    //   - for문을 사용해 구현하세요.
    //
    // 예시:
    //   0   → 0
    //   2   → 0
    //   3   → 3
    //   9   → 18    (3 + 6 + 9)
    //   10  → 18
    //   100 → 1683  (3 + 6 + 9 + ... + 99)

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs   = { 0, 1, 2, 3, 9, 10, 11, 100 };
    public static int[] Expected = { 0, 0, 0, 3, 18, 18, 18, 1683 };

    public static void Check() => Grader.Run("Q5 (1~N 3의 배수 합)", Inputs, Expected, Solve);
}
