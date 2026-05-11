namespace LevelTest.SetA;

public static class Q07_LeftTriangle
{
    // Q7 (중첩 반복문) : 왼쪽 정렬 별 삼각형
    //
    // 문제 설명:
    //   정수 height가 주어집니다.
    //   높이가 height인 왼쪽 정렬 직각삼각형 모양으로 별('*')을 찍은 결과를 string[] 으로 반환하세요.
    //   배열의 i번째(0-based) 원소는 i+1개의 별로 이루어진 문자열입니다.
    //
    // 규칙:
    //   - height는 0 이상의 정수입니다.
    //   - height가 0이면 빈 배열(new string[0])을 반환합니다.
    //
    // 예시:
    //   3 → [ "*", "**", "***" ]
    //   5 → [ "*", "**", "***", "****", "*****" ]
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
        new[] { "*", "**", "***" },
        new[] { "*", "**", "***", "****", "*****" },
    };

    public static void Check() => Grader.Run("Q7 (별 찍기 - 직각삼각형)", Inputs, Expected, Solve);
}
