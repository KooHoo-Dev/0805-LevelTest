namespace LevelTest.SetA;

// Q11에서 사용되는 학생 구조체. (시험 문제이므로 구조체 정의는 미리 제공됩니다)
public struct Student
{
    public string Name;
    public int Score;

    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public override string ToString() => $"{{{Name}, {Score}}}";
}

public static class Q11_TopStudent
{
    // Q11 (구조체 - 탐색) : 최고점 학생의 이름 반환
    //
    // 문제 설명:
    //   학생 구조체(Student) 배열이 주어집니다. Student는 다음 필드를 가집니다.
    //     - string Name : 이름
    //     - int    Score: 점수
    //
    //   점수가 가장 높은 학생의 Name을 반환하세요.
    //
    // 규칙:
    //   - 배열의 길이는 항상 1 이상입니다.
    //   - 최고점이 동점인 학생이 여러 명이면, 배열에서 더 앞에 있는 학생의 이름을 반환합니다.
    //
    // 예시:
    //   [ ("김철수", 90), ("이영희", 85), ("박지성", 95) ]      → "박지성"
    //   [ ("Alice", 70), ("Bob", 70), ("Carol", 60) ]            → "Alice"
    //   [ ("혼자", 0) ]                                          → "혼자"

    public static string Solve(Student[] students)
    {
        throw new NotImplementedException();
    }

    public static Student[][] Inputs =
    {
        new[] { new Student("김철수", 90), new Student("이영희", 85), new Student("박지성", 95) },
        new[] { new Student("Alice", 70), new Student("Bob", 70), new Student("Carol", 60) },
        new[] { new Student("혼자", 0) },
        new[] { new Student("A", 100), new Student("B", 100), new Student("C", 100) },
        new[] { new Student("최유리", 78), new Student("정해인", 92), new Student("강민서", 88) },
    };
    public static string[] Expected = { "박지성", "Alice", "혼자", "A", "정해인" };

    public static void Check() => Grader.Run("Q11 (최고점 학생)", Inputs, Expected, Solve);
}
