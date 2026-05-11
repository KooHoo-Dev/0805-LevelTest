namespace LevelTest.SetC;

// Q12에서 사용되는 영화 구조체. (시험 문제이므로 구조체 정의는 미리 제공됩니다)
public struct Movie
{
    public string Title;
    public int Rating;

    public Movie(string title, int rating)
    {
        Title = title;
        Rating = rating;
    }

    public override string ToString() => $"{{{Title}, {Rating}}}";
}

public static class Q12_BelowAverageMovie
{
    // Q12 (구조체 - 집계) : 평균 평점 "미만"인 영화 개수 세기
    //
    // 문제 설명:
    //   영화 구조체(Movie) 배열이 주어집니다. Movie는 다음 필드를 가집니다.
    //     - string Title  : 제목
    //     - int    Rating : 평점
    //
    //   전체 영화의 평균 평점을 구한 뒤, 평균 평점 "미만"인(즉, 평균보다 작은 - 같지 않음) 영화의 개수를 반환하세요.
    //
    // 규칙:
    //   - 배열이 비어 있으면 0을 반환합니다.
    //   - 평균은 정수 나눗셈이 아니라 실수(double 등)로 계산하세요.
    //   - 평균과 정확히 같은 평점은 "미만"이 아니므로 포함하지 않습니다. (예: 평균 50, 점수 50 → 제외)
    //
    // 예시:
    //   [ (A, 100), (B, 200), (C, 300) ]    → 1   (평균 200, 미만은 100)
    //   [ (A, 100), (B, 200), (C, 301) ]    → 2   (평균 200.33..., 미만은 100, 200)
    //   [ (X, 50) ]                         → 0   (평균 50, 미만 없음)
    //   [ ]                                 → 0

    public static int Solve(Movie[] movies)
    {
        throw new NotImplementedException();
    }

    public static Movie[][] Inputs =
    {
        new[] { new Movie("A", 100), new Movie("B", 200), new Movie("C", 300) },
        new[] { new Movie("A", 100), new Movie("B", 200), new Movie("C", 301) },
        new[] { new Movie("X", 50) },
        new Movie[] { },
        new[] { new Movie("a", 10), new Movie("b", 20), new Movie("c", 30), new Movie("d", 40) },
        new[] { new Movie("p", 1000), new Movie("q", 1000), new Movie("r", 1000) },
    };
    public static int[] Expected = { 1, 2, 0, 0, 2, 0 };

    public static void Check() => Grader.Run("Q12 (평균 미만 영화 수)", Inputs, Expected, Solve);
}
