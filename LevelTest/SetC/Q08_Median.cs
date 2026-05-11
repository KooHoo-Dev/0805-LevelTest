namespace LevelTest.SetC;

public static class Q08_Median
{
    // Q8 (배열 - 탐색) : 중앙값(median) 찾기
    //
    // 문제 설명:
    //   홀수 길이의 정수 배열 numbers가 주어집니다.
    //   배열을 오름차순으로 정렬했을 때 가운데(즉, 인덱스 length / 2) 위치의 값을 반환하세요.
    //
    // 규칙:
    //   - 배열의 길이는 항상 1 이상의 홀수입니다.
    //   - 중복된 값이 있어도 정렬 후 가운데 인덱스의 값을 반환합니다.
    //   - Array.Sort 등 라이브러리 함수를 사용해도 좋습니다.
    //
    // 예시:
    //   {3, 1, 4, 1, 5, 9, 2, 6, 5} → 4   (정렬 시 {1,1,2,3,4,5,5,6,9}, 가운데 = 4)
    //   {1, 2, 3}                   → 2
    //   {5, 5, 5}                   → 5
    //   {7}                         → 7
    //   {-3, -1, -5, -2, -4}        → -3  (정렬 시 {-5,-4,-3,-2,-1}, 가운데 = -3)
    //   {1, 2, 3, 4, 5}             → 3

    public static int Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 },
        new[] { 1, 2, 3 },
        new[] { 5, 5, 5 },
        new[] { 7 },
        new[] { -3, -1, -5, -2, -4 },
        new[] { 1, 2, 3, 4, 5 },
    };
    public static int[] Expected = { 4, 2, 5, 7, -3, 3 };

    public static void Check() => Grader.Run("Q8 (중앙값)", Inputs, Expected, Solve);
}
