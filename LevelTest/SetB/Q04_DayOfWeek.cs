namespace LevelTest.SetB;

public static class Q04_DayOfWeek
{
    // Q4 (조건문 switch) : 요일 번호를 요일 이름으로 변환
    //
    // 문제 설명:
    //   정수 day가 주어집니다. 해당 번호의 요일 이름을 반환하세요.
    //     - 1 → "월요일"
    //     - 2 → "화요일"
    //     - 3 → "수요일"
    //     - 4 → "목요일"
    //     - 5 → "금요일"
    //     - 6 → "토요일"
    //     - 7 → "일요일"
    //     - 그 외 → "잘못된 요일"
    //
    // 규칙:
    //   - 가능하면 switch 문을 사용해 구현하세요.
    //
    // 예시:
    //   1   → "월요일"
    //   5   → "금요일"
    //   7   → "일요일"
    //   0   → "잘못된 요일"
    //   8   → "잘못된 요일"

    public static string Solve(int day)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 1,        3,        5,        6,        7,        0,            8 };
    public static string[] Expected = { "월요일", "수요일", "금요일", "토요일", "일요일", "잘못된 요일", "잘못된 요일" };

    public static void Check() => Grader.Run("Q4 (요일 판별)", Inputs, Expected, Solve);
}
