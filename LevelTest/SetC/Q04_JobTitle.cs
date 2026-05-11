namespace LevelTest.SetC;

public static class Q04_JobTitle
{
    // Q4 (조건문 switch) : 직급 번호를 직급명으로 변환
    //
    // 문제 설명:
    //   정수 level이 주어집니다. 해당 번호의 직급명을 반환하세요.
    //     - 1 → "신입"
    //     - 2 → "대리"
    //     - 3 → "과장"
    //     - 4 → "차장"
    //     - 5 → "부장"
    //     - 그 외 → "잘못된 직급"
    //
    // 규칙:
    //   - 가능하면 switch 문을 사용해 구현하세요.
    //
    // 예시:
    //   1   → "신입"
    //   3   → "과장"
    //   5   → "부장"
    //   0   → "잘못된 직급"
    //   6   → "잘못된 직급"

    public static string Solve(int level)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 1,      2,      3,      4,      5,      0,            6 };
    public static string[] Expected = { "신입", "대리", "과장", "차장", "부장", "잘못된 직급", "잘못된 직급" };

    public static void Check() => Grader.Run("Q4 (직급 판별)", Inputs, Expected, Solve);
}
