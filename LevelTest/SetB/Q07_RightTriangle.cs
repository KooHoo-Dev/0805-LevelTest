namespace LevelTest.SetB;

public static class Q07_RightTriangle
{
    // Q7 (중첩 반복문) : 오른쪽 정렬 별 삼각형
    //
    // 문제 설명:
    //   정수 height가 주어집니다.
    //   높이가 height인 오른쪽 정렬 직각삼각형 모양으로 별('*')을 찍은 결과를 string[] 으로 반환하세요.
    //   각 행의 전체 길이는 height이며, i번째(0-based) 행은 (height - 1 - i)개의 공백 ' ' 다음에 (i + 1)개의 별이 옵니다.
    //
    // 규칙:
    //   - height는 0 이상의 정수입니다.
    //   - height가 0이면 빈 배열(new string[0])을 반환합니다.
    //
    // 예시:
    //   3 → [ "  *", " **", "***" ]
    //   5 → [ "    *", "   **", "  ***", " ****", "*****" ]
    //   0 → []
    //   1 → [ "*" ]

    public static string[] Solve(int height)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs = { 0, 1, 3, 5 };
    public static string[][] Expected =
    {
        new string[] { },
        new[] { "*" },
        new[] { "  *", " **", "***" },
        new[] { "    *", "   **", "  ***", " ****", "*****" },
    };

    public static void Check() => Grader.Run("Q7 (별 찍기 - 오른쪽 정렬)", Inputs, Expected, Solve);
}
