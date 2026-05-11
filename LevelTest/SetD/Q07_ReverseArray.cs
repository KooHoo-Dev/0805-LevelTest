namespace LevelTest.SetD;

public static class Q07_ReverseArray
{
    // Q07 : 배열 뒤집기
    //
    // 문제 설명:
    // 정수 배열 `numbers`가 주어집니다.
    // 배열의 순서를 뒤집어서 새로운 배열로 반환하는 함수를 작성하세요.
    
    // 예시:
    //   { 1, 2, 3, 4, 5, 6 }  → {6, 5, 4, 3, 2, 1 }
    //   {}                    → {}
    //   { 1 }                 → { 1 }
    
    public static int[] Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 1, 2, 3, 4, 5, 6 },
        new int[] { },
        new[] { 2, 4, 6 },
        new[] { 1 },
        new[] { -2, -1, 0, 1, 2 },
    };
    public static int[][] Expected =
    {
        new[] {6, 5, 4, 3, 2, 1 },
        new int[] { },
        new[] { 6, 4, 2 },
        new[] { 1 },
        new[] { 2, 1, 0, -1, -2 },
    };

    public static void Check() => Grader.Run("Q7 (배열 뒤집기)", Inputs, Expected, Solve);
}