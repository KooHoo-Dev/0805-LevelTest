namespace LevelTest.SetD;

public struct Book
{
    public string Title;
    public int Pages;

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public override string ToString() => $"{{{Title}, {Pages}}}";
}

public static class Q09_LongestBook
{
    // Q09 (구조체 - 탐색) : 페이지 수가 가장 많은 책의 제목 반환
    //
    // 문제 설명:
    //   책 구조체(Book) 배열이 주어집니다. Book은 다음 필드를 가집니다.
    //     - string Title : 제목
    //     - int    Pages : 페이지 수
    //
    //   페이지 수가 가장 많은 책의 Title을 반환하세요.
    //
    // 규칙:
    //   - 배열의 길이는 항상 1 이상입니다.
    //   - 최대 페이지 수가 동점인 책이 여러 권이면, 배열에서 더 앞에 있는 책의 제목을 반환합니다.
    //
    // 예시:
    //   [ ("토비", 800), ("자바", 600), ("러닝", 400) ]   → "토비"
    //   [ ("A", 100), ("B", 100), ("C", 50) ]             → "A"
    //   [ ("외톨이", 200) ]                                → "외톨이"

    public static string Solve(Book[] books)
    {
        throw new NotImplementedException();
    }

    public static Book[][] Inputs =
    {
        new[] { new Book("토비", 800), new Book("자바", 600), new Book("러닝", 400) },
        new[] { new Book("A", 100), new Book("B", 100), new Book("C", 50) },
        new[] { new Book("외톨이", 200) },
        new[] { new Book("X", 500), new Book("Y", 500), new Book("Z", 500) },
        new[] { new Book("Effective C#", 300), new Book("Pro C#", 750), new Book("C# in Depth", 700) },
    };
    public static string[] Expected = { "토비", "A", "외톨이", "X", "Pro C#" };

    public static void Check() => Grader.Run("Q09 (가장 두꺼운 책)", Inputs, Expected, Solve);
}