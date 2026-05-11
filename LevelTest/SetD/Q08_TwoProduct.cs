namespace LevelTest.SetD;

public class Q08_TwoProduct
{
    // Q07 (배열 - 알고리즘) : 두 수의 곱이 target이 되는 쌍 존재 여부
    //
    // 문제 설명:
    //   정수 배열 numbers와 정수 target이 주어집니다.
    //   numbers의 서로 다른 두 위치(i, j, i != j)의 값을 곱해 target이 되는 쌍이
    //   존재하면 true, 그렇지 않으면 false를 반환하세요.
    //
    // 규칙:
    //   - 같은 인덱스를 두 번 사용할 수는 없지만, 값이 같아도 인덱스가 다르면 사용 가능합니다.
    //     예) numbers = {4, 4}, target = 16 → true
    //   - 배열의 길이가 1 이하이면 false를 반환합니다.
    //   - 0이 포함된 경우도 정상 처리합니다.
    //     예) numbers = {0, 5}, target = 0 → true
    //   - 힌트: 중첩 for문을 사용하세요.
    //
    // 예시:
    //   ({1, 3, 5, 7, 9}, 15) → true   (3 × 5)
    //   ({1, 2, 3},       7)  → false
    //   ({4, 4},          16) → true
    //   ({5},             5)  → false
    //   ({-2, -3},        6)  → true
    //   ({0, 5},          0)  → true

    public static bool Solve(int[] numbers, int target)
    {
        throw new NotImplementedException();
    }

    public static (int[] numbers, int target)[] Inputs =
    {
        (new[] { 1, 3, 5, 7, 9 }, 15),
        (new[] { 1, 2, 3 },       7),
        (new[] { 4, 4 },          16),
        (new[] { 5 },             5),
        (new[] { -2, -3 },        6),
        (new int[] { },           0),
        (new[] { 0, 5 },          0),
    };
    public static bool[] Expected = { true, false, true, false, true, false, true };

    public static void Check() =>
        Grader.Run("Q08 (Two Product)", Inputs, Expected, t => Solve(t.numbers, t.target));
}