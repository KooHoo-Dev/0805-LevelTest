namespace LevelTest.SetA;

public static class Q03_TriangleType
{
    // Q3 (조건문 if-else) : 세 변의 길이로 삼각형 종류 판별
    //
    // 문제 설명:
    //   세 정수 a, b, c가 주어집니다. 이 세 수를 변의 길이로 하는 삼각형의 종류를 다음 중 하나로 반환하세요.
    //     - "정삼각형"   : 세 변이 모두 같음
    //     - "이등변삼각형" : 두 변만 같음
    //     - "일반삼각형" : 세 변이 모두 다름
    //     - "삼각형아님" : 삼각형이 성립하지 않음 (가장 긴 변이 나머지 두 변의 합 이상)
    //
    // 규칙:
    //   - a, b, c는 모두 양의 정수입니다.
    //   - 먼저 삼각형 성립 여부를 검사한 뒤, 변의 길이를 비교해 종류를 판별하세요.
    //
    // 예시:
    //   (3, 3, 3) → "정삼각형"
    //   (3, 3, 5) → "이등변삼각형"
    //   (3, 4, 5) → "일반삼각형"
    //   (1, 1, 5) → "삼각형아님"

    public static string Solve(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    public static (int a, int b, int c)[] Inputs =
    {
        (3, 3, 3),
        (3, 3, 5),
        (3, 4, 5),
        (1, 1, 5),
        (5, 5, 5),
        (10, 6, 6),
        (1, 2, 3),  // 1+2=3 → 삼각형 아님
    };
    public static string[] Expected =
    {
        "정삼각형",
        "이등변삼각형",
        "일반삼각형",
        "삼각형아님",
        "정삼각형",
        "이등변삼각형",
        "삼각형아님",
    };

    public static void Check() =>
        Grader.Run("Q3 (삼각형 판별)", Inputs, Expected, t => Solve(t.a, t.b, t.c));
}
