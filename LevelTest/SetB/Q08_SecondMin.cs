namespace LevelTest.SetB;

public static class Q08_SecondMin
{
    // Q8 (배열 - 탐색) : 두 번째로 작은 값 찾기
    //
    // 문제 설명:
    //   정수 배열 numbers가 주어집니다.
    //   배열을 오름차순으로 정렬했을 때 인덱스 1에 위치하는 값(즉, 두 번째로 작은 위치의 값)을 반환하세요.
    //
    // 규칙:
    //   - 배열의 길이는 항상 2 이상입니다.
    //   - 중복된 값이 있어도 정렬 기준 인덱스 1의 값을 반환합니다.
    //     예) {5, 5, 5} → 정렬해도 {5, 5, 5} → 인덱스 1의 값 5
    //     예) {1, 1, 9} → 정렬 후 {1, 1, 9} → 인덱스 1의 값 1
    //   - Array.Sort 등 라이브러리 함수를 사용해도 좋습니다.
    //
    // 예시:
    //   {3, 1, 4, 1, 5, 9, 2, 6} → 1
    //   {1, 2, 3, 4, 5}          → 2
    //   {5, 5, 5}                → 5
    //   {1, 1, 9}                → 1
    //   {10, 20}                 → 20
    //   {-3, -1, -5, -2}         → -3

    public static int Solve(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[][] Inputs =
    {
        new[] { 3, 1, 4, 1, 5, 9, 2, 6 },
        new[] { 1, 2, 3, 4, 5 },
        new[] { 5, 5, 5 },
        new[] { 1, 1, 9 },
        new[] { 10, 20 },
        new[] { -3, -1, -5, -2 },
    };
    public static int[] Expected = { 1, 2, 5, 1, 20, -3 };

    public static void Check() => Grader.Run("Q8 (두 번째로 작은 값)", Inputs, Expected, Solve);
}
