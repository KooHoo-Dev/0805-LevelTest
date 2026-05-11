namespace LevelTest.SetB;

public static class Q03_AverageGrade
{
    // Q3 (조건문 if-else) : 세 과목 점수의 평균으로 학점 계산
    //
    // 문제 설명:
    //   세 정수 kor, eng, math가 주어집니다. 각각 국어/영어/수학 점수입니다.
    //   세 점수의 평균을 계산해, 다음 기준에 따른 학점 문자열을 반환하세요.
    //     - 평균이 90 이상       → "A"
    //     - 80 이상 90 미만      → "B"
    //     - 70 이상 80 미만      → "C"
    //     - 70 미만              → "F"
    //
    // 규칙:
    //   - 평균은 (kor + eng + math) / 3.0 으로 실수(double)로 계산하세요.
    //   - 각 점수는 0 이상 100 이하의 정수입니다.
    //
    // 예시:
    //   (95, 95, 95) → "A"
    //   (80, 85, 90) → "B"
    //   (70, 70, 70) → "C"
    //   (60, 65, 70) → "F"

    public static string Solve(int kor, int eng, int math)
    {
        throw new NotImplementedException();
    }

    public static (int kor, int eng, int math)[] Inputs =
    {
        (95, 95, 95),
        (80, 85, 90),
        (70, 70, 70),
        (60, 65, 70),
        (90, 90, 90),
        (89, 89, 89),
        (0, 0, 0),
    };
    public static string[] Expected = { "A", "B", "C", "F", "A", "B", "F" };

    public static void Check() =>
        Grader.Run("Q3 (세 과목 평균 학점)", Inputs, Expected, t => Solve(t.kor, t.eng, t.math));
}
