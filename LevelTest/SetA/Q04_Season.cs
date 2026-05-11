namespace LevelTest.SetA;

public static class Q04_Season
{
    // Q4 (조건문 switch) : 월(month)을 계절로 변환
    //
    // 문제 설명:
    //   정수 month가 주어집니다. 해당 월의 계절을 반환하세요.
    //     - 3, 4, 5월   → "봄"
    //     - 6, 7, 8월   → "여름"
    //     - 9, 10, 11월 → "가을"
    //     - 12, 1, 2월  → "겨울"
    //     - 그 외       → "잘못된 월"
    //
    // 규칙:
    //   - 가능하면 switch 문을 사용해 구현하세요.
    //
    // 예시:
    //   3   → "봄"
    //   7   → "여름"
    //   10  → "가을"
    //   12  → "겨울"
    //   1   → "겨울"
    //   13  → "잘못된 월"
    //   0   → "잘못된 월"

    public static string Solve(int month)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 3,     7,      10,     12,     1,      13,         0 };
    public static string[] Expected = { "봄", "여름", "가을", "겨울", "겨울", "잘못된 월", "잘못된 월" };

    public static void Check() => Grader.Run("Q4 (계절 판별)", Inputs, Expected, Solve);
}
