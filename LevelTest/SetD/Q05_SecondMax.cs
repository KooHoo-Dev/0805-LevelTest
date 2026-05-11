namespace LevelTest.SetD;


public static class Q05_SecondMax
{
    // Q5 : (배열 - 선형 탐색) : 두 번째로 큰 값 찾기
    //
    // 문제 설명:
    //   정수 배열 numbers가 주어집니다.
    //   배열의 모든 요소를 탐색하여 2번째로 큰 값을 반환하세요
    //
    // 규칙:
    //   - 배열의 길이는 항상 2 이상입니다.
    //
    // 예시:
    //   {3, 1, 4, 1, 5, 9, 2, 6} → 6
    //   {1, 2, 3, 4, 5}          → 4
    //   {5, 5, 5}                → 5
    //   {1, 9, 9}                → 9
    //   {10, 20}                 → 10

    public static int Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 3, 1, 4, 1, 5, 9, 2, 6 },
        new[] { 1, 2, 3, 4, 5 },
        new[] { 5, 5, 5 },
        new[] { 1, 9, 9 },
        new[] { 10, 20 },
        new[] { -3, -1, -5, -2 },
    };
    public static int[] Expected = { 6, 4, 5, 9, 10, -2 };

    public static void Check() => Grader.Run("Q5 (두 번째로 큰 값)", Inputs, Expected, Solve);
}
