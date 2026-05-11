namespace LevelTest.SetC;

public static class Q03_MaxPosition
{
    // Q3 (조건문 if-else) : 세 수 중 가장 큰 수의 위치
    //
    // 문제 설명:
    //   세 정수 a, b, c가 주어집니다.
    //   가장 큰 수가 어떤 변수인지에 따라 다음 중 하나를 반환하세요.
    //     - a가 유일하게 최댓값 → "a"
    //     - b가 유일하게 최댓값 → "b"
    //     - c가 유일하게 최댓값 → "c"
    //     - 최댓값을 갖는 변수가 2개 이상(즉, 같은 최댓값이 둘 이상 존재) → "동점"
    //
    // 규칙:
    //   - a, b, c는 정수입니다.
    //
    // 예시:
    //   (1, 2, 3) → "c"
    //   (3, 1, 2) → "a"
    //   (1, 3, 2) → "b"
    //   (5, 5, 5) → "동점"
    //   (5, 5, 3) → "동점"
    //   (3, 3, 5) → "c"   (c=5 가 유일한 최댓값)

    public static string Solve(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    public static (int a, int b, int c)[] Inputs =
    {
        (1, 2, 3),
        (3, 1, 2),
        (1, 3, 2),
        (5, 5, 5),
        (5, 5, 3),
        (3, 3, 5),
        (7, 3, 2),
    };
    public static string[] Expected = { "c", "a", "b", "동점", "동점", "c", "a" };

    public static void Check() =>
        Grader.Run("Q3 (최댓값 위치)", Inputs, Expected, t => Solve(t.a, t.b, t.c));
}
