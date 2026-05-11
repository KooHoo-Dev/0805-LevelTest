namespace LevelTest.SetB;

public static class Q09_OddFilter
{
    // Q9 (배열 - 가공) : 홀수만 골라 새 배열에 담기
    //
    // 문제 설명:
    //   정수 배열 numbers가 주어집니다.
    //   배열에서 홀수만 골라, 입력 순서를 유지한 채 새로운 정수 배열에 담아 반환하세요.
    //
    // 규칙:
    //   - 음수 홀수도 홀수로 간주합니다. (예: -3은 홀수)
    //   - 홀수가 하나도 없으면 빈 배열(new int[0])을 반환합니다.
    //   - 입력 배열은 변경하지 마세요.
    //   - LINQ를 사용하지 말고, 반복문으로 직접 구현하세요.
    //     (힌트: 배열을 두 번 순회 - 1) 홀수 개수 세기, 2) 새 배열에 채우기)
    //
    // 예시:
    //   {1, 2, 3, 4, 5}    → {1, 3, 5}
    //   {2, 4, 6}          → {}
    //   {}                 → {}
    //   {1, 3, 5}          → {1, 3, 5}
    //   {-2, -1, 0, 1, 2}  → {-1, 1}

    public static int[] Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 1, 2, 3, 4, 5 },
        new[] { 2, 4, 6 },
        new int[] { },
        new[] { 1, 3, 5 },
        new[] { -2, -1, 0, 1, 2 },
    };
    public static int[][] Expected =
    {
        new[] { 1, 3, 5 },
        new int[] { },
        new int[] { },
        new[] { 1, 3, 5 },
        new[] { -1, 1 },
    };

    public static void Check() => Grader.Run("Q9 (홀수만 골라내기)", Inputs, Expected, Solve);
}
