namespace LevelTest.SetC;

public static class Q07_InvertedTriangle
{
    // Q7 (중첩 반복문) : 역삼각형 (위가 가장 긴 좌측 정렬)
    //
    // 문제 설명:
    //   정수 height가 주어집니다.
    //   위에서부터 별('*')의 개수가 height, height - 1, ..., 1 순서로 줄어드는
    //   왼쪽 정렬 역삼각형을 string[] 으로 반환하세요.
    //
    // 규칙:
    //   - height는 0 이상의 정수입니다.
    //   - height가 0이면 빈 배열(new string[0])을 반환합니다.
    //
    // 예시:
    //   3 → [ "***", "**", "*" ]
    //   5 → [ "*****", "****", "***", "**", "*" ]
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
        new[] { "***", "**", "*" },
        new[] { "*****", "****", "***", "**", "*" },
    };

    public static void Check() => Grader.Run("Q7 (별 찍기 - 역삼각형)", Inputs, Expected, Solve);
}
