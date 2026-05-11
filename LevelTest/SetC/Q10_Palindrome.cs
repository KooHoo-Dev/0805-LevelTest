namespace LevelTest.SetC;

public static class Q10_Palindrome
{
    // Q10 (배열 - 알고리즘) : 회문(Palindrome) 배열 판정
    //
    // 문제 설명:
    //   정수 배열 numbers가 주어집니다.
    //   이 배열이 회문 배열인지(즉, 앞에서 읽으나 뒤에서 읽으나 동일한 순서인지) 판정해 반환하세요.
    //   회문이면 true, 아니면 false 입니다.
    //
    // 규칙:
    //   - 길이가 0이거나 1인 배열은 항상 회문(true)으로 간주합니다.
    //   - 힌트: 양 끝의 인덱스(i = 0, j = length - 1)부터 안쪽으로 비교합니다.
    //           다른 값이 발견되면 즉시 false를 반환합니다.
    //
    // 예시:
    //   {1, 2, 3, 2, 1}    → true
    //   {1, 2, 3, 4, 5}    → false
    //   {1, 1}             → true
    //   {1}                → true
    //   {}                 → true
    //   {1, 2, 1}          → true
    //   {1, 2, 3, 2, 4}    → false
    //   {1, 2, 3, 4, 3, 2, 1} → true

    public static bool Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 1, 2, 3, 2, 1 },
        new[] { 1, 2, 3, 4, 5 },
        new[] { 1, 1 },
        new[] { 1 },
        new int[] { },
        new[] { 1, 2, 1 },
        new[] { 1, 2, 3, 2, 4 },
        new[] { 1, 2, 3, 4, 3, 2, 1 },
    };
    public static bool[] Expected = { true, false, true, true, true, true, false, true };

    public static void Check() => Grader.Run("Q10 (회문 배열 판정)", Inputs, Expected, Solve);
}
