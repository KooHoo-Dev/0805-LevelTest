namespace LevelTest.SetB;

public static class Q02_CmFormat
{
    // Q2 (연산자) : 센티미터를 "Xm Ycm" 형식 문자열로 변환
    //
    // 문제 설명:
    //   0 이상의 정수 cm가 주어집니다.
    //   이를 "{미터}m {센티미터}cm" 형식의 문자열로 변환해 반환하세요.
    //   1m = 100cm 입니다.
    //
    // 규칙:
    //   - cm는 0 이상의 정수입니다.
    //   - 0 채움(zero-padding)은 하지 않습니다. 그대로 정수 출력합니다.
    //   - 힌트: / 와 % 연산자를 사용하세요.
    //
    // 예시:
    //   0     → "0m 0cm"
    //   5     → "0m 5cm"
    //   100   → "1m 0cm"
    //   250   → "2m 50cm"
    //   1003  → "10m 3cm"

    public static string Solve(int cm)
    {
        throw new NotImplementedException();
    }

    public static int[]    Inputs   = { 0,        5,        100,      250,      1003 };
    public static string[] Expected = { "0m 0cm", "0m 5cm", "1m 0cm", "2m 50cm", "10m 3cm" };

    public static void Check() => Grader.Run("Q2 (cm → m·cm 변환)", Inputs, Expected, Solve);
}
